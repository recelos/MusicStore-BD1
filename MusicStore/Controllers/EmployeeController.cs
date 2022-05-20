using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class EmployeeController : Controller
    {
        public bool AddProduct(InstrumentModel instrument)
        {
            var query = "INSERT INTO Instruments(Name, TypeId, BrandId, Price, IsReserved ,CountryId, ConditionId, CreateAt)" +
                        $"VALUES ({instrument.Name}, {instrument.TypeId}, {instrument.BrandId} ,{instrument.Price}, 0, {instrument.CountryId}, {instrument.ConditionId}), GETDATE();";

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

            return success;
        }


    }
}
