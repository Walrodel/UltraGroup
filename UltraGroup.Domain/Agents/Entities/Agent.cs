using UltraGroup.Domain.Common;

namespace UltraGroup.Domain.Agents.Entities
{
    public class Agent : DomainEntity
    {
        const int MinimunLengthName = 3;
        const int MaximunLengthName = 100;

        const int MinimunLengthEmail = 5;
        const int MaximunLengthEmail = 100;

        const int MinimunLengthPhone = 5;
        const int MaximunLengthPhone = 20;

        private string name = default!;
        private string email = default!;
        private string phone = default!;

        public required string Name
        {
            get => name;
            set
            {
                value.ValidateRequired("The name should not be null or empty.");
                value.ValidateLength(MinimunLengthName, MaximunLengthName, $"The name should be between {MinimunLengthName} and {MaximunLengthName} characters.");
                name = value;
            }
        }

        public string Email
        {
            get => email;
            set
            {
                value.ValidateRequired("the name should not be null or empty.");
                value.ValidateLength(MinimunLengthEmail, MaximunLengthEmail, $"the name should be between {MinimunLengthEmail} and {MaximunLengthEmail} characters.");
                email = value;
            }
        }

        public string Phone
        {
            get => phone;
            set
            {
                value.ValidateRequired("the name should not be null or empty.");
                value.ValidateLength(MinimunLengthPhone, MaximunLengthPhone, $"the name should be between {MinimunLengthPhone} and {MaximunLengthPhone} characters.");
                phone = value;
            }
        }
    }
}
