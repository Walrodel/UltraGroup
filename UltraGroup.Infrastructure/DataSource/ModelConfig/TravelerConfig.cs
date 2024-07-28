using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UltraGroup.Domain.Travelers.Entity;

namespace UltraGroup.Infrastructure.DataSource.ModelConfig
{
    internal class TravelerConfig : IEntityTypeConfiguration<Traveler>
    {
        const int MaximunLengthName = 100;
        const int MaximunLengthDocumentNumber = 20;
        const int MaximunLengthEmail = 100;
        const int MaximunLengthPhone = 20;

        public void Configure(EntityTypeBuilder<Traveler> builder)
        {
            builder.Property(traveler => traveler.Id)
                .IsRequired();

            builder.Property(traveler => traveler.DateOfBirth)
                .IsRequired();

            builder.Property(traveler => traveler.FirstName)
                .HasMaxLength(MaximunLengthName)
                .IsRequired();

            builder.Property(traveler => traveler.LastName)
               .HasMaxLength(MaximunLengthName)
               .IsRequired();

            builder.Property(traveler => traveler.Gender)
              .HasColumnType("tinyint")
              .IsRequired();

            builder.Property(traveler => traveler.DocumentType)
             .HasColumnType("tinyint")
             .IsRequired();

            builder.Property(traveler => traveler.DocumentNumber)
               .HasMaxLength(MaximunLengthDocumentNumber)
               .IsRequired();

            builder.Property(traveler => traveler.Email)
                .HasMaxLength(MaximunLengthEmail)
                .IsRequired();

            builder.Property(traveler => traveler.Phone)
                .HasMaxLength(MaximunLengthPhone)
                .IsRequired();

        }
    }
}
