using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPan.EntityLayer.Concrete
{
    public class Discount
    {
        public int DiscountId { get; set; }
        public string DiscountCode { get; set; }
        public DateTime DiscountCreateDate { get; set; }
        public DateTime DiscountEndDate { get; set; }
        public int DiscountCount { get; set; }

    }
}
