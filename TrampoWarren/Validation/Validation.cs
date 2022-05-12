using FluentValidation;
using TrampoWarren.Models;

namespace TrampoWarren.Validation
{
    public class Validation : AbstractValidator<Afiliados>
    {
        public Validation()
        {
            RuleFor(x => x.Nome).NotEmpty()
                .WithMessage("Name cannot be empty")
                .MinimumLength(10)
                .WithMessage("The name field is empty");

            RuleFor(x => x).NotEmpty()
                .Must(x => x.Email == x.EmailConfirmation)
                .WithMessage("Emails are different");

            RuleFor(x => x.Cpf).NotEmpty()
                .WithMessage("Cpf cannot be empty")
                .MinimumLength(11)
                .WithMessage("The cpf field is empty");

            RuleFor(x => x.CellPhone).NotEmpty()
                .WithMessage("Cellphone cannot be empty")
                .MinimumLength(11)
                .WithMessage("The cellphone field is empty");

            RuleFor(x => x.BirthDate).NotEmpty()
                .WithMessage("BirthDate cannot be empty")
                .LessThan(DateTime.Now.Date)
                .WithMessage("The birthdate field is empty");

            RuleFor(x => x.Country).NotEmpty()
                .WithMessage("Country cannot be empty")
                .MinimumLength(30)
                .WithMessage("The country field is empty");

            RuleFor(x => x.City).NotEmpty()
                .WithMessage("City cannot be empty")
                .MinimumLength(30)
                .WithMessage("The city field is empty");

            RuleFor(x => x.PostalCode).NotEmpty()
                .WithMessage("Postal Code cannot be empty")
                .MaximumLength(8)
                .WithMessage("In this field the maximum is 8");

            RuleFor(x => x.Address).NotEmpty()
                .WithMessage("The Address cannot be empty")
                .MaximumLength(50)
                .WithMessage("In this field the maximum is 50");

            RuleFor(x => x.Number).NotEmpty()
                .WithMessage("Address number cannot be empty")
                .MaximumLength(50)
                .WithMessage("In this field the maximum is 10");



        }

    }
}
