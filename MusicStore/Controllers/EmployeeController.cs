using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class EmployeeController : Controller
    {

        public DataTable GetInstruments()
        {
            var query =
                "SELECT Instruments.Id ,Instruments.Name, Brands.Name AS Brand, Types.Name AS Type, Price, Countries.CountryCode AS Country, Conditions.Name AS Condition " +
                "FROM Instruments " +
                "JOIN Brands ON Instruments.BrandId = Brands.Id " +
                "JOIN Types ON Instruments.TypeId = Types.Id " +
                "JOIN Countries ON Instruments.CountryId = Countries.Id " +
                "JOIN Conditions ON Instruments.ConditionId = Conditions.Id;"; 
            var adapter = new SqlDataAdapter(query, Connection);
            var output = new DataTable();
            adapter.Fill(output);
            return output;
        }

        public void DeleteProduct(int? productId)
        {
            if (productId == null)
                return;
            

            var query = "DELETE FROM Instruments " +
                        $"WHERE Id = {productId}";

            Connection.Open();

            var cmd = new SqlCommand(query, Connection);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }

    }
}
