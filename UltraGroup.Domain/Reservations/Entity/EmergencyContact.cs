using UltraGroup.Domain.Common;

namespace UltraGroup.Domain.Reservations.Entity
{
    public class EmergencyContact : DomainEntity
    {
        const int MinimunLengthName = 3;
        const int MaximunLengthName = 100;

        const int MinimunLengthPhone = 5;
        const int MaximunLengthPhone = 20;

        private string fullName = default!;
        private string phone = default!;

        public required string FullName
        {
            get => fullName;
            set
            {
                value.ValidateRequired("The full name should not be null or empty.");
                value.ValidateLength(MinimunLengthName, MaximunLengthName, $"The name should be between {MinimunLengthName} and {MaximunLengthName} characters.");
                fullName = value;
            }
        }

        public required string Phone
        {
            get => phone;
            set
            {
                value.ValidateRequired("The phone should not be null or empty.");
                value.ValidateLength(MinimunLengthPhone, MaximunLengthPhone, $"The phone should be between {MinimunLengthPhone} and {MaximunLengthPhone} characters.");
                phone = value;
            }
        }
    }
}
