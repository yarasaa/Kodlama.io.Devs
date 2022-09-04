using Domain.Entities;
using FluentValidation;

namespace Application.Features.ProgrammingLanguages.Commands
{
    public class CreateProgrammingLanguageCommandValidator : AbstractValidator<ProgrammingLanguage>
    {
        public CreateProgrammingLanguageCommandValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MinimumLength(1);
        }
    }
}
