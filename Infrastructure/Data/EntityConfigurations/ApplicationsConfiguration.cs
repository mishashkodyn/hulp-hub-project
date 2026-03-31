using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.EntityConfigurations
{
    public class ApplicationsConfiguration : IEntityTypeConfiguration<PsychologistApplication>
    {
        public void Configure(EntityTypeBuilder<PsychologistApplication> builder)
        {
            builder.HasKey(m => m.Id);

            builder
                .HasOne(m => m.ReviewedBy)
                .WithMany()
                .HasForeignKey(m => m.ReviewedById);
        }
    }
}
