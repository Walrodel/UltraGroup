using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UltraGroup.Domain.Reservations.Entity;

namespace UltraGroup.Infrastructure.DataSource.ModelConfig
{
    internal class ReservationConfig : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.Property(reservation => reservation.Id)
                .IsRequired();

            builder.Property(reservation => reservation.Date)
                .IsRequired();

            builder.Property(reservation => reservation.CheckInDate)
                .IsRequired();

            builder.Property(reservation => reservation.CheckOutDate)
                .IsRequired();

            builder.Property(room => room.NumberOfPersons)
               .HasColumnType("int")
               .IsRequired();

            builder.Property(room => room.State)
               .HasColumnType("tinyint")
               .IsRequired();
        }
    }
}
