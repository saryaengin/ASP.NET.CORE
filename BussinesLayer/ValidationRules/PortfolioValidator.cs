using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BussinesLayer.ValidationRules
{
	public class PortfolioValidator : AbstractValidator<Portfolio>
	{ 
		public PortfolioValidator()
		{
			RuleFor(x => x.Name).NotEmpty().WithMessage("İsim kısmı boş geçilemez");
			RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel alan kısmı boş geçilemez");
			RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Görsel alan 2 kısmı boş geçilemez");
			RuleFor(x => x.ProjectUrl).NotEmpty().WithMessage("Proje linki kısmı boş geçilemez");
			RuleFor(x => x.Name).MinimumLength(5).WithMessage("İsim kısmı en az 5 karakterden oluşmalıdır");
			RuleFor(x => x.Name).MaximumLength(20).WithMessage("İsim kısmı en fazla 20 karakterden oluşmalıdır");
		}
	}
}
