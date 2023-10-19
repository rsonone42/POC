using FluentValidation;
using RepositoryPatternSample.DTO;
using System.Text.RegularExpressions;

namespace RepositoryPatternSample.FluentValidator
{
    public class UserValidator : AbstractValidator<UserDTO>
    {
        public UserValidator()
        {
            RuleFor(user=>user.UserId).NotEmpty().MaximumLength(40).MinimumLength(6);
            RuleFor(user => user.Email).NotEmpty().EmailAddress();
            RuleFor(user => user.FirstName).NotEmpty().MinimumLength(2).MaximumLength(60);
            RuleFor(user =>user.LastName).NotEmpty().MinimumLength(1).MaximumLength(60);
            RuleFor(user =>user.MobileNumber).NotEmpty().MinimumLength(7).MaximumLength(13);
            RuleFor(user => user.Password).NotEmpty().MinimumLength(4).MaximumLength(16);
            RuleFor(user => user.MiddleName).Must(MustBeCharOnly).WithMessage("Middle name should only contain characters");
        }

        private bool MustBeCharOnly(string? name)
        {
            if (string.IsNullOrEmpty(name))
                return true;
            string pattern = @"^[a-zA-Z]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(name);
        }
    }
}
