using FluentValidation;
using OpenPrivateers.API.Models;

namespace OpenPrivateers.API.Validators;

public class ShipClassValidator :  AbstractValidator<ShipClass?> 
{
    public ShipClassValidator()
    {
        // rules for simple properties
        RuleFor(x => x!.Name).NotEmpty();
        RuleFor(x => x!.ImageUrl).NotEmpty();
    }
}