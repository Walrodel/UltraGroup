using UltraGroup.Domain.Common;

namespace UltraGroup.Domain.Travelers.Entity
{
    public class Traveler : DomainEntity
    {
        const int MinimunLengthName = 2;
        const int MaximunLengthName = 50;
        const int MinimunLengthDocumentNumber = 5;
        const int MaximunLengthDocumentNumber = 20;
        const int MinimunLengthEmail = 5;
        const int MaximunLengthEmail = 100;
        const int MinimunLengthPhone = 5;
        const int MaximunLengthPhone = 20;

        string firstName = default!;
        string lastName = default!;
        private string email = default!;
        private string phone = default!;

        public required string FirstName
        {
            get => firstName;
            set
            {
                value.ValidateRequired("The first name should not be null or empty.");
                value.ValidateLength(MinimunLengthName, MaximunLengthName, $"The first name should be between {MinimunLengthName} and {MaximunLengthName} characters.");
                firstName = value;
            }
        }

        public required string LastName
        {
            get => lastName;
            set
            {
                value.ValidateRequired("The last name should not be null or empty.");
                value.ValidateLength(MinimunLengthName, MaximunLengthName, $"The last name should be between {MinimunLengthName} and {MaximunLengthName} characters.");
                lastName = value;
            }
        }

        public required DateOnly DateOfBirth { get; set; }

        public required Gender Gender { get; set; }

        public required DocumentType DocumentType { get; set; }

        public required string DocumentNumber
        {
            get => lastName;
            set
            {
                value.ValidateRequired("The document number should not be null or empty.");
                value.ValidateLength(MinimunLengthDocumentNumber, MaximunLengthDocumentNumber, $"The document number should be between {MinimunLengthDocumentNumber} and {MaximunLengthDocumentNumber} characters.");
                lastName = value;
            }
        }

        public required string Email
        {
            get => email;
            set
            {
                value.ValidateRequired("The email should not be null or empty.");
                value.ValidateLength(MinimunLengthEmail, MaximunLengthEmail, $"The email should be between {MinimunLengthEmail} and {MaximunLengthEmail} characters.");
                value.ValidateEmail("The email is not valid.");
                email = value;
            }
        }

        public required string Phone
        {
            get => phone;
            set
            {
                value.ValidateRequired("The phone should not be null or empty.");
                value.ValidateLength(MinimunLengthPhone, MaximunLengthPhone, $"the phone should be between {MinimunLengthPhone} and {MaximunLengthPhone} characters.");
                phone = value;
            }
        }

        public void Update(Traveler traveler)
        {
            Id = traveler.Id;
            FirstName = traveler.FirstName;
            LastName = traveler.LastName;
            DateOfBirth = traveler.DateOfBirth;
            Gender = traveler.Gender;
            DocumentType = traveler.DocumentType;
            DocumentNumber = traveler.DocumentNumber;
            Email = traveler.Email;
            Phone = traveler.Phone;
        }
    }
}
