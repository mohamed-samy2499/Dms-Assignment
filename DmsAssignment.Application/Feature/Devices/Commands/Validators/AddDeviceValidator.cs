using FluentValidation;
using DmsAssignment.Application.Feature.Devices.Commands.Models;

namespace DmsAssignment.Application.Feature.Devices.Commands.Validators
{
    public class AddDeviceValidator : AbstractValidator<AddDeviceCommand>
    {
        public AddDeviceValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.SerialNo)
                .NotEmpty().WithMessage("Sorry, Serial No's Value can't be Empty")
                .NotNull().WithMessage("Sorry, Serial No's Value is Required");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Sorry, Name can't be Empty")
                .NotNull().WithMessage("Sorry, Name is Required");

        }
    }
}
