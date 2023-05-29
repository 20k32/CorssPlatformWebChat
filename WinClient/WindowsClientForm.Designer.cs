namespace WinClient
{
    partial class WinClient
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StateLabel = new Label();
            NameLabel = new Label();
            TextLabel = new Label();
            ConnectionStateLabel = new Label();
            ConnectButton = new Button();
            UserNameTextBox = new TextBox();
            MessageRichTextBox = new RichTextBox();
            GetNameButton = new Button();
            SetNameButton = new Button();
            SendButton = new Button();
            ChatRichTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // StateLabel
            // 
            StateLabel.AutoSize = true;
            StateLabel.Location = new Point(12, 9);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(36, 15);
            StateLabel.TabIndex = 0;
            StateLabel.Text = "State:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(12, 50);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(42, 15);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Name:";
            // 
            // TextLabel
            // 
            TextLabel.AutoSize = true;
            TextLabel.Location = new Point(12, 124);
            TextLabel.Name = "TextLabel";
            TextLabel.Size = new Size(56, 15);
            TextLabel.TabIndex = 2;
            TextLabel.Text = "Message:";
            // 
            // ConnectionStateLabel
            // 
            ConnectionStateLabel.AutoSize = true;
            ConnectionStateLabel.ForeColor = Color.FromArgb(192, 0, 0);
            ConnectionStateLabel.Location = new Point(66, 9);
            ConnectionStateLabel.Name = "ConnectionStateLabel";
            ConnectionStateLabel.Size = new Size(79, 15);
            ConnectionStateLabel.TabIndex = 3;
            ConnectionStateLabel.Text = "Disconnected";
            // 
            // ConnectButton
            // 
            ConnectButton.Location = new Point(151, 5);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new Size(75, 23);
            ConnectButton.TabIndex = 4;
            ConnectButton.Text = "Connect";
            ConnectButton.UseVisualStyleBackColor = true;
            ConnectButton.Click += ConnectButton_Click;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(66, 47);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(160, 23);
            UserNameTextBox.TabIndex = 5;
            // 
            // MessageRichTextBox
            // 
            MessageRichTextBox.Location = new Point(66, 124);
            MessageRichTextBox.Name = "MessageRichTextBox";
            MessageRichTextBox.Size = new Size(160, 134);
            MessageRichTextBox.TabIndex = 6;
            MessageRichTextBox.Text = "";
            // 
            // GetNameButton
            // 
            GetNameButton.Location = new Point(66, 76);
            GetNameButton.Name = "GetNameButton";
            GetNameButton.Size = new Size(51, 23);
            GetNameButton.TabIndex = 7;
            GetNameButton.Text = "Get";
            GetNameButton.UseVisualStyleBackColor = true;
            GetNameButton.Click += GetNameButton_Click;
            // 
            // SetNameButton
            // 
            SetNameButton.Location = new Point(175, 76);
            SetNameButton.Name = "SetNameButton";
            SetNameButton.Size = new Size(51, 23);
            SetNameButton.TabIndex = 8;
            SetNameButton.Text = "Set";
            SetNameButton.UseVisualStyleBackColor = true;
            SetNameButton.Click += SetNameButton_Click;
            // 
            // SendButton
            // 
            SendButton.Location = new Point(66, 274);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(160, 47);
            SendButton.TabIndex = 9;
            SendButton.Text = "Send";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // ChatRichTextBox
            // 
            ChatRichTextBox.Location = new Point(255, 12);
            ChatRichTextBox.Name = "ChatRichTextBox";
            ChatRichTextBox.ReadOnly = true;
            ChatRichTextBox.Size = new Size(663, 678);
            ChatRichTextBox.TabIndex = 10;
            ChatRichTextBox.Text = "";
            // 
            // WinClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 702);
            Controls.Add(ChatRichTextBox);
            Controls.Add(SendButton);
            Controls.Add(SetNameButton);
            Controls.Add(GetNameButton);
            Controls.Add(MessageRichTextBox);
            Controls.Add(UserNameTextBox);
            Controls.Add(ConnectButton);
            Controls.Add(ConnectionStateLabel);
            Controls.Add(TextLabel);
            Controls.Add(NameLabel);
            Controls.Add(StateLabel);
            Name = "WinClient";
            Text = "Windows Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StateLabel;
        private Label NameLabel;
        private Label TextLabel;
        private Label ConnectionStateLabel;
        private Button ConnectButton;
        private TextBox UserNameTextBox;
        private RichTextBox MessageRichTextBox;
        private Button GetNameButton;
        private Button SetNameButton;
        private Button SendButton;
        private RichTextBox ChatRichTextBox;
    }
}