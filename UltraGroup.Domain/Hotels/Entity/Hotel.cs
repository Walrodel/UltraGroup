using UltraGroup.Domain.Agents.Entity;
using UltraGroup.Domain.Common;

namespace UltraGroup.Domain.Hotels.Entity
{
    public class Hotel : DomainEntity
    {
        const int MinimunLengthName = 3;
        const int MaximunLengthName = 100;
        const int MinimunLengthCity = 1;
        const int MaximunLengthCity = 100;
        const int MinimunLengthAddress = 5;
        const int MaximunLengthAddress = 100;

        private string name = default!;
        private string city = default!;
        private string address = default!;
        private Agent agent = default!;
        StateHotel state;

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

        public required string City
        {
            get => city;
            set
            {
                value.ValidateRequired("The city should not be null or empty.");
                value.ValidateLength(MinimunLengthCity, MaximunLengthCity, $"The city should be between {MinimunLengthCity} and {MaximunLengthCity} characters.");
                city = value;
            }
        }

        public required string Address
        {
            get => address;
            set
            {
                value.ValidateRequired("The address should not be null or empty.");
                value.ValidateLength(MinimunLengthAddress, MaximunLengthAddress, $"The address should be between {MinimunLengthAddress} and {MaximunLengthAddress} characters.");
                address = value;
            }
        }

        public string Description { get; set; } = string.Empty;

        public required StateHotel State
        {
            get => state;
            set
            {
                value.ValidateEnum("The state is not valid.");
                state = value;
            }
        }

        public Agent Agent
        {
            get => agent;
            set
            {
                value.ValidateNull("The agent does not exist.");
                agent = value;
            }
        }

        public void Update(Hotel hotel)
        {
            Id = hotel.Id;
            Name = hotel.Name;
            City = hotel.City;
            Address = hotel.Address;
            Description = hotel.Description;
            State = hotel.State;
            Agent = hotel.Agent;
        }
    }
}
