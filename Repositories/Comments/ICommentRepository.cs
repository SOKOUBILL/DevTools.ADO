

using DevTools.ADO.Models;

namespace DevTools.ADO.Repositories.Comments
{
    public interface ICommentRepository : IBaseRepository<Comment>
    {
        /// <summary>
        /// This method get all comments concerned by the contact in parameter
        /// </summary>
        /// <param name="contactId">  </param>
        /// <returns>Represent the id of the contact</returns>
        ICollection<Comment> GetAllByContact(int contactId);
    }
}
