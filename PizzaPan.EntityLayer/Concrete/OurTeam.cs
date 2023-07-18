using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPan.EntityLayer.Concrete
{
    public class OurTeam
    {
        public int OurTeamId { get; set; }
        public string OurTeamName { get; set; }
        public string OurTeamSurname { get; set; }
        public string OurTeamTitle { get; set; }
        public string OurTeamFacebook { get; set; }
        public string OurTeamTwitter { get; set; }
        public string OurTeamImageUrl { get; set; }
        public bool OurTeamStatus { get; set; }
    }
}
