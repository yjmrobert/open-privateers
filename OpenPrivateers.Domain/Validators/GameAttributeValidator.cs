using FluentValidation;
using OpenPrivateers.Domain.Models;

namespace OpenPrivateers.Domain.Validators;

public class GameAttributeValidator : AbstractValidator<GameAttribute?>
{
    public GameAttributeValidator()
    {
        RuleFor(x => x!.Name).NotEmpty();
        RuleFor(x => x!.ImageUrl).NotEmpty();
    }
}