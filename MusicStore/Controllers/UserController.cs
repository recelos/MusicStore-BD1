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
    class UserController : Controller
    {
        public DataTable GetInstruments(string name, string brandName, string typeName, string conditionName)
        {
            var query = "SELECT Instruments.Name, Brands.Name AS Brand, Types.Name AS Type, Price, Countries.CountryCode AS Country, Conditions.Name AS Condition " +
                        "FROM Instruments " +
                        "JOIN Brands ON Instruments.BrandId = Brands.Id " +
                        "JOIN Types ON Instruments.TypeId = Types.Id " +
                        "JOIN Countries ON Instruments.CountryId = Countries.Id " +
                        "JOIN Conditions ON Instruments.ConditionId = Conditions.Id " + 
                        $"WHERE Instruments.Name LIKE '%{name}%' AND Brands.Name LIKE '%{brandName}%' AND Types.Name LIKE '%{typeName}%' AND Conditions.Name LIKE '%{conditionName}%';";
            var adapter = new SqlDataAdapter(query, Connection);
            var dataTable = new DataTable();
             adapter.Fill(dataTable);
            return dataTable;
        }

        public IList<string> GetAllValuesFromColumn(string columnName)
        {
            var query = "SELECT Name " +
                        $"FROM {columnName};";
            Connection.Open();

            var cmd = new SqlCommand(query, Connection);
            var reader = cmd.ExecuteReader();

            IList<string> output = new List<string>();

            output.Add("");
            while (reader.Read())
                output.Add(reader.GetString(0));
            Connection.Close();
            return output;
        }
    }
}
