using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UltraGroup.Domain.Reservations.Entity;

namespace UltraGroup.Infrastructure.DataSource.ModelConfig
{
    internal class ReservatioinTreavelersConfig : IEntityTypeConfiguration<ReservatioinTreavelers>
    {
        public void Configure(EntityTypeBuilder<ReservatioinTreavelers> builder)
        {
            builder.Property(reservatioinTreaveler => reservatioinTreaveler.Id)
                .IsRequired();

        }
    }
}
