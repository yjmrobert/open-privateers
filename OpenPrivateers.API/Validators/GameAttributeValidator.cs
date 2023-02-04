using FluentValidation;
using OpenPrivateers.API.Models;

namespace OpenPrivateers.API.Validators;

public class GameAttributeValidator : AbstractValidator<GameAttribute?>
{
    public GameAttributeValidator()
    {
        RuleFor(x => x!.Name).NotEmpty();
        RuleFor(x => x!.ImageUrl).NotEmpty();
    }
}