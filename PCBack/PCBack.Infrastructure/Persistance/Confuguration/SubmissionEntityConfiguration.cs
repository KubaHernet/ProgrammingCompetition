using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PCBack.Domain.Entities;

namespace PCBack.Infrastructure.Persistance.Confuguration
{
    public class SubmissionEntityConfiguration : IEntityTypeConfiguration<SubmissionEntity>
    {
        public void Configure(EntityTypeBuilder<SubmissionEntity> builder)
        {
            builder.HasKey(x => new { x.UserName, x.TaskId });

            builder.Property(x => x.UserName)
                .IsRequired();

            builder.HasOne(x => x.Task)
                .WithMany(y => y.Submissions)
                .HasForeignKey(x => x.TaskId)
                .IsRequired();
        }
    }
}
