using Microsoft.AspNetCore.SignalR;
using Models;
using SignaRServer.Hubs.Interfaces;

namespace SignaRServer.Hubs
{
    public class MainHub : Hub<IMainHub>
    {
        private const string USER_NAME = "UserName";
        private const string DEFAULT_USER_NAME = "Anonymous";

        public Task SendToOhters(Message message)
        {
            return Clients.Others.SendMessageToOtherClients(message);
        }

        public Task SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return Task.CompletedTask;
            }
            if(Context.Items.ContainsKey(USER_NAME))
            {
                Context.Items[USER_NAME] = name;
            }
            else
            {
                Context.Items.Add(USER_NAME, name);
            }

            return Task.CompletedTask;
        }

        public Task<string> GetName()
        {
            if (Context.Items.ContainsKey(USER_NAME))
            {
                return Task.FromResult((string)Context.Items[USER_NAME]!);
            }
            return Task.FromResult(DEFAULT_USER_NAME);
        }
    }
}
