using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Data;
using UltraGroup.Domain.Hotels.Entity;
using UltraGroup.Domain.Rooms.Entity;
using UltraGroup.Domain.Rooms.Entity.Dto;
using UltraGroup.Domain.Rooms.Port;
using UltraGroup.Infrastructure.DataSource;

namespace UltraGroup.Infrastructure.Adapters
{
    [Repository]
    public class RoomSimpleSqlQueryRepository(DataContext dataContext) : IRoomSimpleQueryRepository
    {
        private IDbConnection DbConnection => dataContext.Database.GetDbConnection();

        public async Task<IEnumerable<RoomAviableDto>> GetAviavlesAsync(RoomQueryDto roomQuery)
        {
            SqlMapper.AddTypeHandler(new SqlDateOnlyTypeHandler());

            var rooms = await DbConnection
                .QueryAsync<RoomAviableDto>(
                @"SELECT  h.id, ha.Number, ha.BaseCost, ha.Tax, ha.Location, ha.State, h.Name as NameHotel, h.City, h.Address
                FROM Room ha 
                left join Hotel as h on h.Id = ha.HotelId 
                WHERE h.State = @StateHotel and ha.State = @StateRoom and h.City = @City and ha.Number >= @Number and NOT EXISTS(
	                SELECT RoomId 
                    FROM Reservation as r
                    WHERE RoomId = ha.Id  AND r.CheckInDate <= @CheckOutDate AND r.CheckOutDate >= @CheckInDate)",
                    new
                    {
                        StateHotel = StateHotel.Enabled,
                        StateRoom = StateRoom.Enabled,
                        roomQuery.City,
                        Number = roomQuery.NumberOfPersons,
                        roomQuery.CheckOutDate,
                        roomQuery.CheckInDate
                    });
            return rooms;
        }
    }

    public class SqlDateOnlyTypeHandler : SqlMapper.TypeHandler<DateOnly>
    {
        public override void SetValue(IDbDataParameter parameter, DateOnly date)
            => parameter.Value = date.ToDateTime(new TimeOnly(0, 0));
        public override DateOnly Parse(object value) => DateOnly.FromDateTime((DateTime)value);
    }
}
