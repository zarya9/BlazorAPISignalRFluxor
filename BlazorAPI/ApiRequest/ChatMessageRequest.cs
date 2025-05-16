namespace BlazorAPI.ApiRequest
{
    public class ChatMessageRequest
    {
        public int Id { get; set; } // Добавлено
        public string Message { get; set; }
        public string? ImageUrl { get; set; }
        public int? MovieId { get; set; }
        public int? RecipientId { get; set; }
        public int? UserId { get; set; }
        public DateTime SentAt { get; set; } // Добавлено
        public string SenderName { get; set; } // Добавлено
        public int SenderId { get; set; } // Добавлено
        public string RecipientName { get; set; } // Добавлено
    }
}
