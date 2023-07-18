using FluentValidation;
using PizzaPan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPan.BusinessLayer.ValidationRules.OurTeamValidator
{
   public class CreateOurTeamValidator : AbstractValidator<OurTeam>
    {
        public CreateOurTeamValidator()
        {
            RuleFor(x => x.OurTeamName).NotEmpty().WithMessage("İsim alanı boş geçilemez!");
            RuleFor(x => x.OurTeamSurname).NotEmpty().WithMessage("Soyisim alanı boş geçilemez!");
            RuleFor(x => x.OurTeamTitle).MinimumLength(3).WithMessage("LÜtfen en az 3 karakter giriniz!");
            RuleFor(x => x.OurTeamTitle).MaximumLength(30).WithMessage("LÜtfen en fazla 30 karakter giriniz!");

        }
    }
}
