using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Boolean IsCompleted { get; set; }
        public int AddressId { get; set; }
        public DateTime CreatedAt { get; }


    }
}
