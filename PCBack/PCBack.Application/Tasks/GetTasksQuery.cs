using MediatR;
using System.Collections.Generic;

namespace PCBack.Application.Tasks
{
    public class GetTasksQuery : IRequest<IEnumerable<CompetitionTask>>
    {

    }
}
