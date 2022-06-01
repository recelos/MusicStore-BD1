using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Controllers
{
    public class UserController : Controller
    {
        public DataTable GetInstruments(string name, string brandName, string typeName, string conditionName)
        {
            var query = "SELECT Instruments.Name, Brands.Name AS Brand, Types.Name AS Type, Price, Countries.Name AS Country, Conditions.Name AS Condition " +
                        "FROM Instruments " +
                        "JOIN Brands ON Instruments.BrandId = Brands.Id " +
                        "JOIN Types ON Instruments.TypeId = Types.Id " +
                        "JOIN Countries ON Instruments.CountryId = Countries.Id " +
                        "JOIN Conditions ON Instruments.ConditionId = Conditions.Id " + 
                        $"WHERE Instruments.Name LIKE '%{name}%' AND Brands.Name LIKE '%{brandName}%' AND Types.Name LIKE '%{typeName}%' AND Conditions.Name LIKE '%{conditionName}%' AND Instruments.IsReserved = 0;";
            var adapter = new SqlDataAdapter(query, Connection);
            var output = new DataTable();
            adapter.Fill(output);
            return output;
        }

        public bool CreateBucketForUser(int userId)
        {
            var query = $"IF NOT EXISTS(SELECT Buckets.Id FROM Buckets JOIN Users ON Buckets.UserId = Users.Id WHERE Users.Id = {userId} )" +
                "INSERT INTO Buckets(UserId) " +
                $"VALUES({userId});";

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

        public string GetInstrumentId(string name, string brandName, string typeName, string conditionName)
        {
            var query = "SELECT Instruments.Id " +
                        "FROM Instruments " +
                        "JOIN Brands ON Instruments.BrandId = Brands.Id " +
                        "JOIN Types ON Instruments.TypeId = Types.Id " +
                        "JOIN Countries ON Instruments.CountryId = Countries.Id " +
                        "JOIN Conditions ON Instruments.ConditionId = Conditions.Id " +
                        $"WHERE Instruments.Name LIKE '%{name}%' AND Brands.Name LIKE '%{brandName}%' AND Types.Name LIKE '%{typeName}%' AND Conditions.Name LIKE '%{conditionName}%';";
            
            SqlCommand SelectCommand = new SqlCommand(query, Connection);
            SqlDataReader myreader;
            Connection.Open();

            myreader = SelectCommand.ExecuteReader();

            string Id = null;
            while (myreader.Read())
            {
                Id = myreader[0].ToString();
            }
            Connection.Close();
            return Id;

        }

        public bool AddSelectedInstrumentToBucket(int userId, int instrumentId)
        {
            var query = $"IF (SELECT IsReserved FROM Instruments WHERE Id = {instrumentId}) = 0 " +
                        "INSERT INTO BucketItems(BucketId, InstrumentId) " +
                        $"VALUES((SELECT Id FROM Buckets WHERE UserId = {userId}), {instrumentId})";


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
