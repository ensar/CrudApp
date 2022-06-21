using FluentValidation;

namespace CrudApp.Models.Validators
{
    public class CustomerValidator : AbstractValidator<Customer> 
    {
        public CustomerValidator()
        {
            RuleFor(x=>x.CustomerName).NotNull().WithMessage("Please enter a valid name");
            RuleFor(x=>x.CustomerName).MinimumLength(3).WithMessage("3 or more characters required.");
            RuleFor(x => x.CustomerJob).NotNull().WithMessage("Please enter a valid job");
            RuleFor(x => x.CustomerJob).MinimumLength(3).WithMessage("3 or more characters required.");
        }
    }
}
