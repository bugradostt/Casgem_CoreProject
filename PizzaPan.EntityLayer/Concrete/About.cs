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
        public string AboutImg1 { get; set; }
        public string AboutImg2 { get; set; }
        public string AboutTitle { get; set; }
        public string AboutDes { get; set; }
        public string AboutVideo { get; set; }
    }
}
