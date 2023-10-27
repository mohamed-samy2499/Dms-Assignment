using FluentValidation;
using DmsAssignment.Application.Feature.Devices.Commands.Models;

namespace DmsAssignment.Application.Feature.Devices.Commands.Validators
{
    public class DeleteDeviceValidator : AbstractValidator<DeleteDeviceCommand>
    {
        public DeleteDeviceValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Sorry, Device's id can't be Empty")
                .NotNull().WithMessage("Sorry, Device's id is Required");
        }
    }
}
