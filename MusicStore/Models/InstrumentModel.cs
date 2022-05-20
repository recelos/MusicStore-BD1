using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class InstrumentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public int BrandId { get;set; }
        public decimal Price { get; set; }
        public bool IsReserved { get; set; }
        public DateTime? ReservedAt { get; set; }
        public int CountryId { get; set; }
        public int ConditionId { get; set; }
        public DateTime CreatedAt { get; set; }

        public InstrumentModel(int id, string name, int type, int brand, decimal price, bool isReserved, DateTime? reservedAt, int country, int condition, DateTime createdAt)
        {
            Id = id;
            Name = name;
            TypeId = type;
            BrandId = brand;
            Price = price;
            IsReserved = isReserved;
            ReservedAt = reservedAt;
            CountryId = country;
            ConditionId = condition;
            CreatedAt = createdAt;
        }
    }
}
