using FluentValidation;
using OpenPrivateers.Domain.Models;

namespace OpenPrivateers.Domain.Validators;

public class ModulePropertyValidator : AbstractValidator<ModuleProperty>
{
    public ModulePropertyValidator(bool navigationValidation = false)
    {
        // rules for simple properties
        RuleFor(x => x.ShipModuleId).NotEmpty();
        RuleFor(x => x.GameAttributeId).NotEmpty();
        RuleFor(x => x.Value).NotEmpty();
        
        if (!navigationValidation)
            return;
        
        // rule for navigation property
        RuleFor(x => x.ShipModule).NotEmpty();
        RuleFor(x => x.GameAttribute)
            .NotEmpty()
            .SetValidator(new GameAttributeValidator());
    }
    
}