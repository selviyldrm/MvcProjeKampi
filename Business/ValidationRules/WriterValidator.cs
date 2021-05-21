using Entity.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı boş Geçilemez");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar Soyadı boş olamaz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("HAkkımda kısmı boş geçilemez");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Ünvan kısmı boş geçilemez");
            RuleFor(x => x.WriterSurname).MinimumLength(3).WithMessage("Lütfen en az 2 karakter girişi yapınız");
            RuleFor(x => x.WriterSurname).MaximumLength(20).WithMessage("Lütfen 50 karakterden fazla değer girişi yapmayınız");
        }
    }
}
