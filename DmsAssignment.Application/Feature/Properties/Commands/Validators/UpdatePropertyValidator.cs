using FluentValidation;
using DmsAssignment.Application.Feature.Properties.Commands.Models;

namespace DmsAssignment.Application.Feature.Properties.Commands.Validators
{
    public class UpdatePropertyValidator : AbstractValidator<UpdatePropertyCommand>
    {
        public UpdatePropertyValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Sorry, Property's id can't be Empty")
                .NotNull().WithMessage("Sorry, Property's id is Required");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Sorry, Name can't be Empty")
                .NotNull().WithMessage("Sorry, Name is Required");
        }
    }
}
