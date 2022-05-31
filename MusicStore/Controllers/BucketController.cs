using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicStore.Controllers
{
    public class BucketController : Controller
    {
        public bool RemoveSelectedInstrumentFromBucket(int bucketId, int instrumentId)
        {
            var query = "DELETE FROM BucketItems " +
                        $"WHERE BucketId = {bucketId} AND InstrumentId = {instrumentId} " +
                        $"UPDATE Instruments SET IsReserved = 0, ReservationDate = NULL WHERE Id = {instrumentId}; ";

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

        public String GetInstrumentId(string name, string brandName, string typeName, string conditionName)
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

            String Id = null;
            while (myreader.Read())
            {
                Id = myreader[0].ToString();
            }
            Connection.Close();
            return Id;

        }

        public String GetBucketId(int userId)
        {
            var query = "SELECT Buckets.Id " +
                        "FROM Buckets " +
                        "JOIN Users ON Users.Id = Buckets.UserId " +
                        $"WHERE Users.Id = {userId};";

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

        public String GetAdressId(int countryId, string cityName, string streetName, string postalCode, string voivodeship)
        {
            var query = "SELECT Id " +
                        "FROM Addresses " +                 
                        $"WHERE CountryId = {countryId} AND CityName LIKE '%{cityName}%' AND StreetName LIKE '%{streetName}%' AND PostalCode LIKE '%{postalCode}%' AND Voivodeship LIKE '%{voivodeship}%';";

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

        public bool CreateAddress(int countryId, string cityName, string streetName, string postalCode, string voivodeship)
        {
            var query = $"IF NOT EXISTS(SELECT Id FROM Addresses WHERE CountryId = {countryId} AND CityName LIKE '%{cityName}%' AND StreetName LIKE '%{streetName}%' AND PostalCode LIKE '%{postalCode}%' AND Voivodeship LIKE '%{voivodeship}%') " +
                "INSERT INTO Addresses(CountryId, CityName, StreetName, PostalCode, Voivodeship) " +
                $"VALUES({countryId}, '{cityName}', '{streetName}', '{postalCode}', '{voivodeship}');";

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


        public DataTable GetAllBucketItems(int userId)
        {
            var query = "SELECT Instruments.Name, Brands.Name AS Brand, Types.Name AS Type, Price, Countries.Name AS Country, Conditions.Name AS Condition " +
                        "FROM Instruments " +
                        "JOIN Brands ON Instruments.BrandId = Brands.Id " +
                        "JOIN Types ON Instruments.TypeId = Types.Id " +
                        "JOIN Countries ON Instruments.CountryId = Countries.Id " +
                        "JOIN Conditions ON Instruments.ConditionId = Conditions.Id " +
                        "JOIN BucketItems ON Instruments.Id = BucketItems.InstrumentId " +
                        $"WHERE BucketItems.BucketId = (SELECT Buckets.Id FROM Buckets JOIN Users ON Buckets.UserId = Users.Id WHERE Users.Id = {userId});";
            var adapter = new SqlDataAdapter(query, Connection);
            var output = new DataTable();
            adapter.Fill(output);
            return output;
        }

        public bool CreateOrder(int userId, int addressId)
        {
            var query = $"IF NOT EXISTS(SELECT Orders.Id FROM Orders JOIN Users ON Users.Id = Orders.UserId WHERE Users.Id = {userId}) " +
                "INSERT INTO Orders(UserId, IsCompleted, AddressId, CreatedAt) " +
                $"VALUES({userId}, 0, {addressId}, GETDATE());";

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

        public bool AddProductsFromBucketToOrder(int userId)
        {
            /*var query = "USE MusicStore GO " +
                "DECLARE @i INTEGER; " +
                "SET @i = (SELECT COUNT(*) FROM BucketItems); " +
                "SET IDENTITY_INSERT OrderItems ON " +
                "DROP TABLE IF EXISTS temp " +
                "WHILE(@i > 0) BEGIN " +
                "SELECT InstrumentId, Id INTO temp FROM " +
                "(SELECT TOP 1 BucketItems.InstrumentId, Buckets.UserId FROM BucketItems " +
                "JOIN Instruments ON " +
                "BucketItems.InstrumentId = Instruments.Id " +
                "JOIN Buckets ON " +
                "Buckets.Id = BucketItems.BucketId " +
                $"WHERE Buckets.UserId = {userId}) AS from_bucket " +
                "JOIN " +
                "(SELECT Orders.Id, Orders.UserId FROM Orders " +
                $"WHERE Orders.UserId = {userId}) AS to_order " +
                "ON from_bucket.UserId = to_order.UserId; " +
                "INSERT INTO OrderItems(OrderId, InstrumentId) " +
                "VALUES((SELECT temp.Id FROM temp), (SELECT temp.InstrumentId FROM temp)); " +
                "DELETE FROM BucketItems " +
                "WHERE InstrumentId = (SELECT temp.InstrumentId FROM temp); " +
                "DROP TABLE temp; " +
                "SET @i = @i - 1 " +
                "END;";*/

            var query = "DROP TABLE IF EXISTS temp " +
                "SELECT InstrumentId, Id INTO temp FROM " +
                "(SELECT TOP 1 BucketItems.InstrumentId, Buckets.UserId FROM BucketItems " +
                "JOIN Instruments ON " +
                "BucketItems.InstrumentId = Instruments.Id " +
                "JOIN Buckets ON " +
                "Buckets.Id = BucketItems.BucketId " +
                $"WHERE Buckets.UserId = {userId}) AS from_bucket " +
                "JOIN " +
                "(SELECT Orders.Id, Orders.UserId FROM Orders " +
                $"WHERE Orders.UserId = {userId}) AS to_order " +
                "ON from_bucket.UserId = to_order.UserId; " +
                "INSERT INTO OrderItems(OrderId, InstrumentId) " +
                "VALUES((SELECT temp.Id FROM temp), (SELECT temp.InstrumentId FROM temp)); " +
                "DELETE FROM BucketItems " +
                "WHERE InstrumentId = (SELECT temp.InstrumentId FROM temp); " +
                "DROP TABLE temp;";

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
