using FluentValidation;
using DmsAssignment.Application.Feature.Devices.Commands.Models;

namespace DmsAssignment.Application.Feature.Devices.Commands.Validators
{
    public class UpdateDeviceValidator : AbstractValidator<UpdateDeviceCommand>
    {
        public UpdateDeviceValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Sorry, Device's id can't be Empty")
                .NotNull().WithMessage("Sorry, Device's id is Required");

            RuleFor(x => x.SerialNo)
                .NotEmpty().WithMessage("Sorry, Serial No's Value can't be Empty")
                .NotNull().WithMessage("Sorry, Serial No's Value is Required");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Sorry, Name can't be Empty")
                .NotNull().WithMessage("Sorry, Name is Required");
        }
    }
}
