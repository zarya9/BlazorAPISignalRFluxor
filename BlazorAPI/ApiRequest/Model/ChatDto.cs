namespace BlazorAPI.ApiRequest.Model
{
    public class ChatDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string LastMessage { get; set; }
        public DateTime LastMessageTime { get; set; }
    }
}
