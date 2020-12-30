using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Net_5_REST_API.DTO
{
    public record CreateItemDTO
    {
        [Required]
        public string Name { get; init; }
        [Range(1, 1000)]
        public decimal Price { get; init; }
    }
}
