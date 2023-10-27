using FluentValidation;
using DmsAssignment.Application.Feature.Properties.Commands.Models;

namespace DmsAssignment.Application.Feature.Properties.Commands.Validators
{
    public class AddPropertyValidator : AbstractValidator<AddPropertyCommand>
    {
        public AddPropertyValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Sorry, Name can't be Empty")
                .NotNull().WithMessage("Sorry, Name is Required");

        }
    }
}
