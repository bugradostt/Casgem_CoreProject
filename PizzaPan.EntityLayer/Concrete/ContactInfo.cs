using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPan.EntityLayer.Concrete
{
    public class ContactInfo
    {
        public int ContactInfoId { get; set; }
        public string ContactInfoAdress { get; set; }
        public string ContactInfoPhone { get; set; }
        public string ContactInfoMail { get; set; }
        public string ContactInfoMaps { get; set; }
    }
}
