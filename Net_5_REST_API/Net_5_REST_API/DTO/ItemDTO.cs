using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net_5_REST_API.DTO
{
    public class ItemDTO
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTime CreationDate { get; init; }
    }
}
