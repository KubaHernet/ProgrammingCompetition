using Microsoft.EntityFrameworkCore;
using PCBack.Application.Interfaces;
using PCBack.Domain.Entities;
using System.Reflection;

namespace PCBack.Infrastructure.Persistance
{
    public class PcDbContext : DbContext, IPcDbContext
    {
        public PcDbContext(DbContextOptions<PcDbContext> options): base(options)
        {

        }

        public DbSet<TaskEntity> Tasks { get; set; }
        public DbSet<SubmissionEntity> Submissions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
}
