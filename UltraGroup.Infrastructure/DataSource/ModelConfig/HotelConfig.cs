using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UltraGroup.Domain.Hotels.Entity;

namespace UltraGroup.Infrastructure.DataSource.ModelConfig
{
    internal class HotelConfig : IEntityTypeConfiguration<Hotel>
    {
        const int MaximunLengthName = 100;
        const int MaximunLengthCity = 100;
        const int MaximunLengthAddress = 100;

        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.Property(hotel => hotel.Id)
                .IsRequired();

            builder.Property(hotel => hotel.Name)
                .HasMaxLength(MaximunLengthName)
                .IsRequired();

            builder.Property(hotel => hotel.City)
                .HasMaxLength(MaximunLengthCity)
                .IsRequired();

            builder.Property(hotel => hotel.Address)
                .HasMaxLength(MaximunLengthAddress)
                .IsRequired();

            builder.Property(hotel => hotel.State)
                .HasColumnType("tinyint")
                .IsRequired();
        }
    }
}
