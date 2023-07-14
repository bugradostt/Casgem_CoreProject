using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPan.PresentationLayer.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Ad boş geçilemez!")]
        public string Name { get; set; }
        public string Surname { get; set; }

        [Required(ErrorMessage ="Mail boş geçilemez!")]
        public string Mail { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
