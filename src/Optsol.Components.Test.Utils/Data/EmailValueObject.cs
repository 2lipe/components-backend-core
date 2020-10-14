using Flunt.Validations;
using Optsol.Components.Domain;

namespace Optsol.Components.Test.Shared.Data
{
    public class EmailValueObject : ValueObject
    {
        public string Email { get; private set; }

        public EmailValueObject(string email)
        {
            Email = email;

            AddNotifications(new Contract()
                .Requires()
                .IsEmail(Email, "EmailValueObject.Email", "E-mail inválido")
            );
        }

        public override string ToString()
        {
            return Email;
        }
    }
}
