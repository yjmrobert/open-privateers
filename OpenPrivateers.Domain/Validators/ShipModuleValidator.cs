using FluentValidation;
using OpenPrivateers.Domain.Models;

namespace OpenPrivateers.Domain.Validators;

public class ShipModuleValidator : AbstractValidator<ShipModule?>
{
    
    public ShipModuleValidator(bool navigationValidation = false)
    {
        // rules for simple properties
        RuleFor(x => x!.Name).NotEmpty();
        RuleFor(x => x!.SubName).NotEmpty();
        
        if (!navigationValidation)
            return;
        
        // rule for collection navigation property
        RuleFor(x => x!.ModuleProperties)
            .NotEmpty()
            .ForEach(x => x.SetValidator(new ModulePropertyValidator(navigationValidation)));
    }
}