using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UltraGroup.Domain.Agents.Entity;

namespace UltraGroup.Infrastructure.DataSource.ModelConfig
{
    internal class AgentConfig : IEntityTypeConfiguration<Agent>
    {
        const int MaximunLengthName = 100;
        const int MaximunLengthEmail = 100;
        const int MaximunLengthPhone = 20;

        public void Configure(EntityTypeBuilder<Agent> builder)
        {
            builder.Property(agent => agent.Id)
                .IsRequired();

            builder.Property(agent => agent.Name)
                .HasMaxLength(MaximunLengthName)
                .IsRequired();

            builder.Property(agent => agent.Email)
                .HasMaxLength(MaximunLengthEmail)
                .IsRequired();

            builder.Property(agent => agent.Phone)
                .HasMaxLength(MaximunLengthPhone)
                .IsRequired();

        }
    }
}
