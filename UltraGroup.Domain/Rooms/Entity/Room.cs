using UltraGroup.Domain.Common;
using UltraGroup.Domain.Hotels.Entity;

namespace UltraGroup.Domain.Rooms.Entity
{
    public class Room : DomainEntity
    {
        const int MinimunLengthLocation = 3;
        const int MaximunLengthLocation = 100;

        int numberOfPersons = default;
        decimal baseCost = default;
        decimal tax = default;
        string location = default!;
        Hotel hotel = default!;

        public required int NumberOfPersons
        {
            get => numberOfPersons;
            set
            {
                value.ValidateGreaterThanZero("The number of persons should be greater than zero.");
                numberOfPersons = value;
            }
        }

        public required decimal BaseCost
        {
            get => baseCost;
            set
            {
                value.ValidateGreaterThanZero("The base cost should be greater than zero.");
                baseCost = value;
            }
        }

        public required decimal Tax
        {
            get => tax;
            set
            {
                value.ValidateGreaterThanZero("The tax should be greater than zero.");
                tax = value;
            }
        }

        public required TypeRoom Type { get; set; }

        public required string Location
        {
            get => location;
            set
            {
                value.ValidateRequired("The location should not be null or empty.");
                value.ValidateLength(MinimunLengthLocation, MaximunLengthLocation, $"The location should be between {MinimunLengthLocation} and {MaximunLengthLocation} characters.");
                location = value;
            }
        }

        public required StateRoom State { get; set; }

        public Hotel Hotel
        {
            get => hotel;
            set
            {
                value.ValidateNull("The hotel does not exist.");
                hotel = value;
            }
        }

        public void Update(Room room)
        {
            Id = room.Id;
            NumberOfPersons = room.NumberOfPersons;
            BaseCost = room.BaseCost;
            Tax = room.Tax;
            State = room.State;
            Type = room.Type;
            Location = room.Location;
            Hotel = room.Hotel;
        }
    }
}
