using FluentValidation;
using FluentValidation.Validators;
using OpenPrivateers.API.Models;

namespace OpenPrivateers.API.Validators;

public class ShipValidator : AbstractValidator<Ship>
{
    public ShipValidator(bool navigationValidation = false)
    {
        // rules for simple properties
        RuleFor(x => x.Name)
            .NotEmpty();
        RuleFor(x => x.VariantName)
            .NotEmpty();
        RuleFor(x => x.VariantLetter)
            .NotEmpty()
            .Length(1);
        RuleFor(x => x.Description)
            .NotEmpty();
        RuleFor(x => x.ImageUrl)
            .NotEmpty();

        if (!navigationValidation)
            return;

        // rule for navigation property
        RuleFor(x => x.ShipClass)
            .NotEmpty()
            .SetValidator(new ShipClassValidator());

        // rule for collection navigation property
        RuleFor(x => x.ShipSystems)
            .NotEmpty()
            .ForEach(x => x.SetValidator(new ShipSystemValidator(navigationValidation)));
        RuleFor(x => x.WeaponSystems)
            .NotEmpty();
    }
}