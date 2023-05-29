using Microsoft.AspNetCore.SignalR.Client;
using Models;
using System;
using System.Diagnostics;

namespace WinClient
{
    public partial class WinClient : Form
    {
        private readonly HubConnection Connection = null!;

        public WinClient()
        {
            InitializeComponent();

            Connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7253/notification")
                .WithAutomaticReconnect()
                .Build();

            Connection.On<Models.Message>("SendMessageToOtherClients", message =>
            {
                this.Invoke(() => WriteToChatTextBox(message.Header, message.Body, Color.Black));
            });

            Connection.Closed += exeption =>
            {
                MessageBox.Show($"Connection closed {(exeption == null ? "with no error" : exeption.Message)}");
                return Task.CompletedTask;
            };

            Connection.Reconnected += connectionId =>
            {
                MessageBox.Show($"Reconnected with Id {connectionId}");
                return Task.CompletedTask;
            };

            Connection.Reconnecting += exeption =>
            {
                MessageBox.Show($"Connection lost. Try to reconnect {(exeption == null ? "with no error" : exeption.Message)}");
                return Task.CompletedTask;
            };
        }

        private void WriteToChatTextBox(string UserName, string Data, Color TextColor)
        {
            ChatRichTextBox.SelectionStart = ChatRichTextBox.TextLength;
            ChatRichTextBox.SelectionLength = 0;
            ChatRichTextBox.SelectionColor = TextColor;

            string resultText = $"{UserName}:\n{Data}\n\n";
            ChatRichTextBox.AppendText(resultText);

            ChatRichTextBox.SelectionColor = ChatRichTextBox.ForeColor;
        }

        private async void ConnectButton_Click(object sender, EventArgs e)
        {
            if (Connection.State == HubConnectionState.Disconnected)
            {
                try
                {
                    await Connection.StartAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (Connection.State == HubConnectionState.Connected)
            {
                ConnectButton.Text = "Disconnect";
                ConnectionStateLabel.Text = "Connected";
                ConnectionStateLabel.ForeColor = Color.Green;
            }
        }

        private async Task<string> GetNameAsync()
        {
            string result = string.Empty;

            try
            {
                result = await Connection.InvokeAsync<string>("GetName");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }

        private async void GetNameButton_Click(object sender, EventArgs e)
        {
            if (Connection.State == HubConnectionState.Connected)
            {
                string name = await GetNameAsync();
                UserNameTextBox.Text = name;
            }
        }

        private async void SetNameButton_Click(object sender, EventArgs e)
        {
            if (Connection.State == HubConnectionState.Connected)
            {
                try
                {
                    await Connection.SendAsync("SetName", UserNameTextBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async void SendButton_Click(object sender, EventArgs e)
        {
            if (Connection.State == HubConnectionState.Connected)
            {
                var AuthorName = await GetNameAsync();
                var message = new Models.Message(AuthorName, MessageRichTextBox.Text);

                try
                {
                    await Connection.SendAsync("SendToOhters", message);
                    WriteToChatTextBox("Me", message.Body, Color.Green);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    MessageRichTextBox.Clear();
                }
            }
        }
    }
}