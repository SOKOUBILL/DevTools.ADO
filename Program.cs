using DevTools.ADO.Models;
using DevTools.ADO.Repositories.Comments;

namespace DevTools.ADO
{
    public class Program
    {
        private static CommentRepository _CommentRepository = new CommentRepository();
        public static void Main(string[] args)
        {
            _CommentRepository.Delete(4);
        }
    
    }
}