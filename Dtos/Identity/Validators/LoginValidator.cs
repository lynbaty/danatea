using Dtos.Identity;
using FluentValidation;

namespace Dtos.Identity.Validators
{
    public class LoginValidator : AbstractValidator<LoginDto>
    {
        public LoginValidator()
        {
            RuleFor(x => x.Password).MinimumLength(6).WithMessage("Password has least 6 charater")
                .NotNull().WithMessage("This field is not null");    
            RuleFor(x => x.Email).EmailAddress().WithMessage("Your email is not valid")
                .NotNull().WithMessage("This field is not null"); 
        }
    }
}