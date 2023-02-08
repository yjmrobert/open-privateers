using FluentValidation;
using OpenPrivateers.Domain.Models;

namespace OpenPrivateers.Domain.Validators;

public class ModuleInstallationValidator : AbstractValidator<ModuleInstallation>
{
    public ModuleInstallationValidator(bool navigationValidation = false)
    {
        // rules for simple properties
        RuleFor(x => x.ShipSystemId).NotEmpty();
        RuleFor(x => x.ShipModuleId).NotEmpty();
        RuleFor(x => x.Quantity).NotEmpty();
        
        if (!navigationValidation)
            return;
        
        // rules for navigation property
        RuleFor(x => x.ShipSystem).NotEmpty();
        RuleFor(x => x.ShipModule)
            .NotEmpty()
            .SetValidator(new ShipModuleValidator(navigationValidation));
    }
}