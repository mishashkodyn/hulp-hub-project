using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.EntityConfigurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder
              .Property(u => u.PreferredAiProvider)
              .HasDefaultValue("Groq");

            builder
                .HasOne(u => u.Psychologist)
                .WithOne(u => u.User)
                .HasForeignKey<Psychologist>(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
