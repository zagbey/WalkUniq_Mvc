using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkUniq.Models.ViewModels
{
    public class ProductsByCategoryVM
    {
        public Category Category { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public int CategoryId { get; set; } // Yeni eklendi

    }
}
