using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UltraGroup.Domain.Reservations.Entity;

namespace UltraGroup.Infrastructure.DataSource.ModelConfig
{
    internal class EmergencyContactConfig : IEntityTypeConfiguration<EmergencyContact>
    {
        const int MaximunLengthName = 100;
        const int MaximunLengthPhone = 20;

        public void Configure(EntityTypeBuilder<EmergencyContact> builder)
        {
            builder.Property(emergencyContact => emergencyContact.Id)
                .IsRequired();

            builder.Property(emergencyContact => emergencyContact.FullName)
                .HasMaxLength(MaximunLengthName)
                .IsRequired();

            builder.Property(emergencyContact => emergencyContact.Phone)
                .HasMaxLength(MaximunLengthPhone)
                .IsRequired();

        }
    }
}
