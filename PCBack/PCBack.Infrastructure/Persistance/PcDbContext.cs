using Microsoft.EntityFrameworkCore;
using PCBack.Application.Interfaces;
using PCBack.Domain.Entities;

namespace PCBack.Infrastructure.Persistance
{
    public class PcDbContext : DbContext, IPcDbContext
    {
        public PcDbContext(DbContextOptions<PcDbContext> options): base(options)
        {

        }

        public DbSet<TaskEntity> Tasks { get; set; }
    }
}
