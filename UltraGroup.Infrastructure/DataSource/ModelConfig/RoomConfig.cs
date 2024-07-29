using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UltraGroup.Domain.Rooms.Entity;

namespace UltraGroup.Infrastructure.DataSource.ModelConfig
{
    internal class RoomConfig : IEntityTypeConfiguration<Room>
    {
        const int MaximunLengthLocation = 100;

        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.Property(room => room.Id)
                .IsRequired();

            builder.Property(room => room.Location)
                .HasMaxLength(MaximunLengthLocation)
                .IsRequired();

            builder.Property(room => room.NumberOfPersons)
               .HasColumnType("int")
               .IsRequired();

            builder.Property(room => room.Type)
                .HasColumnType("tinyint")
                .IsRequired();

            builder.Property(room => room.State)
               .HasColumnType("tinyint")
               .IsRequired();

            builder.Property(room => room.BaseCost)
                .HasColumnType("decimal(18,2)");

            builder.Property(room => room.Tax)
                .HasColumnType("decimal(18,2)");
        }
    }
}
