using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar soyadını boş geçemezsiniz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Yazar hakkında alanını boş geçemezsiniz");
            RuleFor(x => x.WriterAbout).Must(HasAInIt).WithMessage("Yazar hakkında alanını a harfi içermeli");
            RuleFor(x => x.WriterName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girin.");
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("Lütfen 50 karakterden fazla değer girmeyin.");

        }

        private bool HasAInIt(string arg)
        {
            return arg.Contains("a");
        }
    }
}
