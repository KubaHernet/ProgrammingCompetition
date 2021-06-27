using MediatR;
using System.Collections.Generic;

namespace PCBack.Application.Features.Tasks
{
    public class GetTasksQuery : IRequest<IEnumerable<CompetitionTask>>
    {

    }
}
