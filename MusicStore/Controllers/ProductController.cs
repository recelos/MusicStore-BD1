using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class ProductController : Controller
    {
        public IList<string> GetAllValuesFromTable(string tableName)
        {
            var query = "SELECT Name " +
                        $"FROM {tableName};";
            Connection.Open();

            var cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();

            IList<string> output = new List<string>();
            while (reader.Read())
                output.Add(reader.GetString(0));
            Connection.Close();
            return output;
        }

        public bool AddProduct(InstrumentModel instrument)
        {
            if (instrument==null)
            {
                return false;
            }

            var query =
                "INSERT INTO Instruments(Name, TypeId, BrandId, Price, IsReserved ,CountryId, ConditionId, CreatedAt)" +
                $"VALUES ('{instrument.Name}', {instrument.TypeId}, {instrument.BrandId}, {instrument.Price}, 0, {instrument.CountryId}, {instrument.ConditionId}, GETDATE());";

            Connection.Open();

            var cmd = new SqlCommand(query, Connection);

            var output = true;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                output = false;
            }
            Connection.Close();
            return output;
        }

        public int GetValueId(string value, string table)
        {
            var query = @$"SELECT Id FROM {table} WHERE Name = '{value}';";

            Connection.Open();

            var cmd = new SqlCommand(query, Connection);

            var output = int.Parse(cmd.ExecuteScalar().ToString());

            Connection.Close();

            return output;
        }
    }
}
