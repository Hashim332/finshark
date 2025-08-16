using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Stock
{
    public class CreateStockRequestDto
    {
        [Required]
        [MinLength(2, ErrorMessage = "Symbol cannot be under 2 characters")]
        [MaxLength(6, ErrorMessage = "Symbol cannot be over 6 characters")]
        public string Symbol { get; set; } = string.Empty;

        [Required]
        [MinLength(1, ErrorMessage = "Company name cannot be under 1 character")]
        [MaxLength(16, ErrorMessage = "Company name cannot be over 16 characters")]
        public string CompanyName { get; set; } = string.Empty;

        [Required]
        [Range(1, 1000000000)]
        public decimal Purchase { get; set; }

        [Required]
        [Range(0.001, 100)]
        public decimal LastDiv { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Industry cannot be under 2 characters")]
        [MaxLength(10, ErrorMessage = "Industry cannot be under 10 characters")]
        public string Industry { get; set; } = string.Empty;

        [Required]
        [Range(1, 1000000000000)]
        public long MarketCap { get; set; }
    }
}
