using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Controllers
{
    public class CreateUserController : Controller
    {
        /// <summary>
        /// Inserts new user into the database based on data retrieved from the UI. <br/>
        /// CreatedAt column is determined by GETDATE() function from SQL Server. <br/>
        /// IsEmployee column is always FALSE since new user is not an employee.
        /// </summary>
        /// <param name="username">Username retrieved from the UI</param>
        /// <param name="password">Password retrieved from the UI</param>
        /// <param name="firstName">First name retrieved from the UI</param>
        /// <param name="lastName">Last name retrieved from the UI</param>
        /// <returns>True if the query has been executed properly. </returns>
        public bool CreateUser(string username, string password, string firstName, string lastName)
        {
            var query = "INSERT INTO Users(Username, Password, CreatedAt, FirstName, LastName, IsEmployee) " +
                            $"VALUES('{username}', '{password}', GETDATE(), '{firstName}', '{lastName}', 0);";
            Connection.Open();

            var cmd = new SqlCommand(query, Connection);

            var success = true;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch 
            {
                success = false;
            }
            Connection.Close();
            return success;
        }
    }
}
