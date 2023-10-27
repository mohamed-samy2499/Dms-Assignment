using FluentValidation;
using DmsAssignment.Application.Feature.DeviceCategories.Commands.Models;

namespace DmsAssignment.Application.Feature.DeviceCategories.Commands.Validators
{
    public class DeleteDeviceCategoryValidator : AbstractValidator<DeleteDeviceCategoryCommand>
    {
        public DeleteDeviceCategoryValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Sorry, Device's id can't be Empty")
                .NotNull().WithMessage("Sorry, Device's id is Required");
        }
    }
}
