using FluentValidation;
using DmsAssignment.Application.Feature.Properties.Commands.Models;

namespace DmsAssignment.Application.Feature.Properties.Commands.Validators
{
    public class DeletePropertyValidator : AbstractValidator<DeletePropertyCommand>
    {
        public DeletePropertyValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Sorry, Property's id can't be Empty")
                .NotNull().WithMessage("Sorry, Property's id is Required");
        }
    }
}
