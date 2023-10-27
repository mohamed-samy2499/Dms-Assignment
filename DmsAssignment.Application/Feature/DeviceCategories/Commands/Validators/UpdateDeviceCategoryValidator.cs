using FluentValidation;
using DmsAssignment.Application.Feature.DeviceCategories.Commands.Models;

namespace DmsAssignment.Application.Feature.DeviceCategories.Commands.Validators
{
    public class UpdateDeviceCategoryValidator : AbstractValidator<UpdateDeviceCategoryCommand>
    {
        public UpdateDeviceCategoryValidator() { ApplyValidationsRules(); }
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Sorry, Like's id can't be Empty")
                .NotNull().WithMessage("Sorry, Like's id is Required");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Sorry, Name can't be Empty")
                .NotNull().WithMessage("Sorry, Name is Required");
        }
    }
}
