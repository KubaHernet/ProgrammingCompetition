using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PCBack.Domain.Entities;

namespace PCBack.Infrastructure.Persistance.Confuguration
{
    public class SubmissionEntityConfiguration : IEntityTypeConfiguration<SubmissionEntity>
    {
        public void Configure(EntityTypeBuilder<SubmissionEntity> builder)
        {
            builder.Property(x => x.UserName)
                .IsRequired();

            builder.Property(x => x.Task)
                .IsRequired();

            builder.HasIndex(x => x.UserName);
        }
    }
}
