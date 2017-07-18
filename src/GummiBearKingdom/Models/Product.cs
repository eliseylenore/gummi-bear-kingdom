using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GummiBearKingdom.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public decimal Cost { get; set; }
        public string CountryOfOrigin { get; set; }
        public string ImageUrl { get; set; }

    }
}
