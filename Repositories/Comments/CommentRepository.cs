using DevTools.ADO.Models;
using MySql.Data.MySqlClient;

namespace DevTools.ADO.Repositories.Comments
{
    public class CommentRepository : ICommentRepository
    {
        private readonly  string connectionString;
        public CommentRepository()
        {
            connectionString = "Data Source=localhost;port=3306;Initial Catalog=contact_management_db;User Id=root;password=123456";
        }

        public void Add(Comment entity)
        {
            using(MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = $"INSERT INTO comment(content,createon,contact_id) VALUES(" +
                    $"@content,@cdate,@Contact_Id)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@content", entity.Content);
                cmd.Parameters.AddWithValue("@cdate", DateTime.Now.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@Contact_Id", entity.Contact_Id);


                con.Open();
                 var statuts = cmd.ExecuteNonQuery();

                con.Close();
            }
            
        }

        public void Delete(int id)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = $"DELETE FROM comment  WHERE id=@id ;";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", id);


                con.Open();
                var statuts = cmd.ExecuteNonQuery();

                con.Close();
            }
                
        }

        public Comment Get(int id)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                throw new NotImplementedException();

                string query = "SELECT * FROM comment WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                         
                    }
                }
            }
        }

        public ICollection<Comment> GetAll()
        {
            throw new NotImplementedException();
        }

        public ICollection<Comment> GetAllByContact(int contactId)
        {
            throw new NotImplementedException();
        }

        public void Update(Comment entity)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = $"UPDATE comment SET content=@content,updateon=@udate,Contact_Id=@Contact_Id" +
                    $" WHERE id=@id ;";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@content", entity.Content);
                cmd.Parameters.AddWithValue("@udate", DateTime.Now.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@Contact_Id", entity.Contact_Id);
                cmd.Parameters.AddWithValue("@id", entity.Id);


                con.Open();
                var statuts = cmd.ExecuteNonQuery();

                con.Close();
            }
        }
    }
}
