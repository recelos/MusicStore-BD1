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
    class OrdersController : Controller
    {
        /// <summary>
        /// Gets all orders to fill by them DataGrid for employee orders panel.
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllOrders()
        {
            var query = "SELECT Orders.Id, Users.FirstName AS 'First name', Users.LastName AS 'Last name', Orders.IsCompleted AS 'Is completed', Countries.Name AS 'Country', Addresses.CityName AS 'City', Addresses.StreetName AS 'Street', Addresses.PostalCode AS 'Postal code', Addresses.Voivodeship, Orders.CreatedAt AS 'Created at' " +
                        "FROM Orders " +
                        "JOIN Users ON Orders.UserId = Users.Id " +
                        "JOIN Addresses ON Orders.AddressId = Addresses.Id " +
                        "JOIN Countries ON Addresses.CountryId = Countries.Id;";
            var adapter = new SqlDataAdapter(query, Connection);
            var output = new DataTable();
            adapter.Fill(output);
            return output;
        }
        /// <summary>
        /// Used with finalize button to change IsCompleted status of each order.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool toggleIsCompleted(int id)
        {
            var query = "UPDATE Orders " +
                        "SET IsCompleted = ~IsCompleted " +
                        $"WHERE Orders.Id = {id};";
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
