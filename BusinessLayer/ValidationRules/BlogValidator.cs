using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığı  boş geçilemez.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriği boş geçilemez.");
            RuleFor(x => x.BlogThumbnailImage).NotEmpty().WithMessage("Blog görseli boş geçilemez.");
            RuleFor(x => x.BlogTitle).MinimumLength(2).WithMessage("En az 2 karakter girişi yapın.");
            RuleFor(x => x.BlogTitle).MaximumLength(30).WithMessage("En fazla 30 karakter girişi yapın.");
            RuleFor(x => x.BlogContent).MinimumLength(10).WithMessage("En az 10 karakter girişi yapın.");
            RuleFor(x => x.BlogContent).MaximumLength(500).WithMessage("En fazla 500 karakter girişi yapılabilir..");

        }
    }
}
