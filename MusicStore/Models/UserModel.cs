using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class UserModel
    {
        public int Id { get; }
        public string Username { get; }
        public string Password { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public bool IsEmployee { get; }
        public DateTime CreatedAt { get; }

        public UserModel(IDataReader reader)
        {
            if (!reader.Read())
                throw new Exception();
            Id = (int)reader[0];
            Username = reader[1].ToString();
            Password = reader[2].ToString();
            FirstName = reader[4].ToString();
            LastName = reader[5].ToString();
            IsEmployee = (bool)reader[6];

            var dateToParse = reader[3].ToString(); 

            reader.Close();
            CreatedAt = DateTime.Parse(dateToParse);
        }

    }
}
