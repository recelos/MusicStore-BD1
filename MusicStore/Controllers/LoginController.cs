using System.Data;
using System.Data.SqlClient;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class LoginController : Controller
    {
        /// <summary>
        /// Finds users id based on given username
        /// </summary>
        /// <param name="username">Username which id is being searched</param>
        /// <returns>Id of user with given username or null if user doesn't exits</returns>
        public int? GetUserId(string username)
        {
            var query = $"SELECT Id FROM Users WHERE Username='{username}';";
            Connection.Open();
            var cmd = new SqlCommand(query, Connection);
            var output = (int?)cmd.ExecuteScalar();
            Connection.Close();
            return output;
        } 
        /// <summary>
        /// Compares password retrieved from UI with user's password in database
        /// </summary>
        /// <param name="userId">ID of the user whose password will be compared</param>
        /// <param name="password">Password to compare</param>
        /// <returns>True if given password matches password in the database</returns>
        public bool VerifyPassword(int userId, string password)
        {
            var query = $"SELECT Password FROM Users WHERE Id={userId};";
            Connection.Open();
            var cmd = new SqlCommand(query, Connection);
            var output = password == (string)cmd.ExecuteScalar();
            Connection.Close();
            return output;
        }
        /// <summary>
        /// Checks if given user is an employee
        /// </summary>
        /// <param name="userId">ID of the user who is being checked</param>
        /// <returns>True if user is an employee</returns>
        public bool CheckForEmployee(int userId)
        {
            var query = $"SELECT IsEmployee FROM Users WHERE Id={userId}";
            Connection.Open();
            var output = (bool)new SqlCommand(query, Connection).ExecuteScalar();
            Connection.Close();
            return output;
        }
        /// <summary>
        /// Returns user's data in form of UserModel based on given ID.
        /// </summary>
        /// <param name="userId">Id of the user who is being returned</param>
        /// <returns>Searched user</returns>
        public UserModel GetUser(int userId)
        {
            var query = $"SELECT * FROM Users WHERE Id={userId};";
            Connection.Open();
            var cmd = new SqlCommand(query, Connection);
            var output = new UserModel(cmd.ExecuteReader());
            Connection.Close();
            return output;
        }
    }
}
