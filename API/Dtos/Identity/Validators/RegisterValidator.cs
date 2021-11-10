using FluentValidation;

namespace API.Dtos.Identity.Validators
{
    public class RegisterValidator : AbstractValidator<RegisterDto>
    {
        public RegisterValidator()
        {
            RuleFor(x => x.Password).MinimumLength(6).WithMessage("Password has least 6 charater")
                .NotNull().WithMessage("This field is not null");  
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Password is not match")
                .NotNull().WithMessage("This field is not null");   
            RuleFor(x => x.Email).EmailAddress().WithMessage("Your email is not valid")
                .NotNull().WithMessage("This field is not null"); 
        }
    }
}