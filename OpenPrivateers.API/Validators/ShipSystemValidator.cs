using FluentValidation;
using OpenPrivateers.API.Models;

namespace OpenPrivateers.API.Validators;

public class ShipSystemValidator : AbstractValidator<ShipSystem>
{
    public ShipSystemValidator(bool navigationValidation = false)
    {
        // rules for simple properties
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.SystemHealth).NotEmpty();
        RuleFor(x => x.Ship).NotEmpty();
        
        if (!navigationValidation)
            return;
        
        // rule for collection navigation property
        RuleFor(x => x.ModuleInstallations)
            .NotEmpty()
            .ForEach(x => x.SetValidator(new ModuleInstallationValidator(navigationValidation)));
    }
}