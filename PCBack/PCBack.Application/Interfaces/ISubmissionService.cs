using System.Threading;
using System.Threading.Tasks;

namespace PCBack.Application.Interfaces
{
    public interface ISubmissionService
    {
        Task<string> Execute((string language, string code, string input) requestParams, CancellationToken cancellationToken);
    }
}
