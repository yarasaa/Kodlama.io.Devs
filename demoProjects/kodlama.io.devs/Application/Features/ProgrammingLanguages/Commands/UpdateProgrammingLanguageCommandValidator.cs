using Domain.Entities;
using FluentValidation;

namespace Application.Features.ProgrammingLanguages.Commands
{
    public class UpdateProgrammingLanguageCommandValidator : AbstractValidator<ProgrammingLanguage>
    {
        public UpdateProgrammingLanguageCommandValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MinimumLength(1);

        }
    }
}
