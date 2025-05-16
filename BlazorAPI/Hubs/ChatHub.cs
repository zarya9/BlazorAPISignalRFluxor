using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace BlazorAPI.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessageToGroup(int movieId, string senderName, string message)
        {       
            await Clients.Group($"Movie_{movieId}").SendAsync("ReceiveMessage", senderName, message, DateTime.UtcNow);
        }
        public async Task SendPrivateMessage(string recipientId, string senderName, string message)
        {
            await Clients.User(recipientId).SendAsync("ReceivePrivateMessage", senderName, message);
        }
        public async Task AddToGroup(int movieId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, $"Movie_{movieId}");
        }   

        public async Task RemoveFromGroup(int movieId)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, $"Movie_{movieId}");
        }
    }
}