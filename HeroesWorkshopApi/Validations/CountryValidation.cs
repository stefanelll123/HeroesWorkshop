using FluentValidation;
using HeroesWorkshop.Domain;

namespace HeroesWorkshopApi.Validations
{
    public sealed class CountryValidation : AbstractValidator<Country>
    {
        public CountryValidation()
        {
            RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(128);
            RuleFor(x => x.NameEng).NotEmpty().MinimumLength(3).MaximumLength(128);
            RuleFor(x => x.Code).NotEmpty().MinimumLength(1).MaximumLength(128);
        }
    }
}