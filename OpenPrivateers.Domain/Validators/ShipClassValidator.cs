using FluentValidation;
using OpenPrivateers.Domain.Models;

namespace OpenPrivateers.Domain.Validators;

public class ShipClassValidator :  AbstractValidator<ShipClass?> 
{
    public ShipClassValidator()
    {
        // rules for simple properties
        RuleFor(x => x!.Id).NotEmpty()
            .GreaterThanOrEqualTo(1);
        RuleFor(x => x!.Name).NotEmpty();
        RuleFor(x => x!.ImageUrl).NotEmpty();
    }
}