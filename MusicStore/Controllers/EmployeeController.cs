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
            var query = "SELECT * FROM EmployeeInstrumentView;";
            var adapter = new SqlDataAdapter(query, Connection);
            var output = new DataTable();
            adapter.Fill(output);
            return output;
        }

        public void DeleteProduct(int? productId)
        {
            if (productId == null)
                return;
            
            var query =
                "DELETE FROM OrderItems " +
                $"WHERE InstrumentId = {productId} " +
                "DELETE FROM BucketItems " +
                $"WHERE InstrumentId = {productId} " +
                "DELETE FROM Instruments " +
                $"WHERE Id = {productId}";

            Connection.Open();

            var cmd = new SqlCommand(query, Connection);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }

    }
}
