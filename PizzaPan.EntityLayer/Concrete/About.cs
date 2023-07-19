using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPan.EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutId  { get; set; }
        public int AboutImg1 { get; set; }
        public int AboutImg2 { get; set; }
        public int AboutTitle { get; set; }
        public int AboutDes { get; set; }
        public int AboutVideo { get; set; }
    }
}
