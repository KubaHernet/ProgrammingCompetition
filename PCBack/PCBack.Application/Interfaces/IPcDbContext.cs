using Microsoft.EntityFrameworkCore;
using PCBack.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PCBack.Application.Interfaces
{
    public interface IPcDbContext
    {
        DbSet<TaskEntity> Tasks { get; set; }
        DbSet<SubmissionEntity> Submissions { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
