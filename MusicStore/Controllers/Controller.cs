using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Controllers
{
    public abstract class Controller
    {
        protected readonly SqlConnection Connection = new (Properties.Resources.ConnectionString);

        public IList<string> GetAllValuesFromTable(string tableName)
        {
            var query = "SELECT Name " +
                        $"FROM {tableName};";
            Connection.Open();

            var cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();

            IList<string> output = new List<string> { "" };
            while (reader.Read())
                output.Add(reader.GetString(0));
            Connection.Close();
            return output;
        }

        public String GetCountryId(string countryName)
        {
            var query = "SELECT Countries.Id " +
                        "FROM Countries " +
                        $"WHERE Countries.Name LIKE '%{countryName}%';";

            SqlCommand SelectCommand = new SqlCommand(query, Connection);
            SqlDataReader myreader;
            Connection.Open();

            myreader = SelectCommand.ExecuteReader();

            String Id = null;
            while (myreader.Read())
            {
                Id = myreader[0].ToString();
            }
            Connection.Close();
            return Id;

        }
    }
}
