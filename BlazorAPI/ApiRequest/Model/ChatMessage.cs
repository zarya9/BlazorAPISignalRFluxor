using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorAPI.ApiRequest.Model
{
    public class ChatMessage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public DateTime SentAt { get; set; } = DateTime.UtcNow;

        public string? ImageUrl { get; set; }

        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public Users User { get; set; }

        public int? RecipientId { get; set; } // Для личных сообщений
        [ForeignKey("RecipientId")]
        public Users? Recipient { get; set; } // Ссылка на получателя
    }
}
