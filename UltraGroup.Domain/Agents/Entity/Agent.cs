using UltraGroup.Domain.Agents.Entity.Dto;
using UltraGroup.Domain.Common;

namespace UltraGroup.Domain.Agents.Entity
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

        public void Update(AgentDto agent)
        {
            Id = agent.Id;
            Name = agent.Name;
            Email = agent.Email;
            Phone = agent.Phone;
        }
    }
}
