//using 
//public class ChatService
//{
//    private readonly ContextDB _context;

//    public ChatService(ContextDB context)
//    {
//        _context = context;
//    }

//    public async Task<List<ChatMessage>> GetMessagesForMovieAsync(int movieId)
//    {
//        return await _context.ChatMessages
//            .Where(m => m.MovieId == movieId)
//            .OrderBy(m => m.SentAt)
//            .ToListAsync();
//    }

//    public async Task SaveMessageAsync(ChatMessage message)
//    {
//        _context.ChatMessages.Add(message);
//        await _context.SaveChangesAsync();
//    }
//}