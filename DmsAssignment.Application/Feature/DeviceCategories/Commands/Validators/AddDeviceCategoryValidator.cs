using FluentValidation;
using DmsAssignment.Application.Feature.DeviceCategories.Commands.Models;

namespace DmsAssignment.Application.Feature.DeviceCategories.Commands.Validators
{
    public class AddDeviceCategoryValidator : AbstractValidator<AddDeviceCategoryCommand>
    {
        public AddDeviceCategoryValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Sorry, Name can't be Empty")
                .NotNull().WithMessage("Sorry, Name is Required");

        }
    }
}
