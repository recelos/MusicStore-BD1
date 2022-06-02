using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Controllers
{
    public class OrderItemsController : Controller
    {
        public DataTable GetOrderItems(int orderId)
        {
            var query = "SELECT Instruments.Name, Brands.Name AS Brand, Types.Name AS Type, Instruments.Price " +    
            "FROM OrderItems "+
            "JOIN Instruments ON OrderItems.InstrumentId = Instruments.Id " +
            "JOIN Brands ON Instruments.BrandId = Brands.Id " +
            "JOIN Types ON Instruments.TypeId = Types.Id " +
            $"WHERE OrderId = {orderId};";

            var adapter = new SqlDataAdapter(query, Connection);
            var output = new DataTable();
            adapter.Fill(output);
            return output;
        }

    }
}
