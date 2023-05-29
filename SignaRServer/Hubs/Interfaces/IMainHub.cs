using Models;

namespace SignaRServer.Hubs.Interfaces
{
    public interface IMainHub
    {
        Task SendMessageToOtherClients(Message MessageToClients);
    }
}
