using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PCBack.Application.Tasks
{
    public class GetTasksQueryHandler : IRequestHandler<GetTasksQuery, IEnumerable<CompetitionTask>>
    {
        public Task<IEnumerable<CompetitionTask>> Handle(GetTasksQuery request, CancellationToken cancellationToken)
        {
            var list = new List<CompetitionTask>() 
            { 
                new CompetitionTask { 
                    Id = "id",
                    Name = "name",
                    Description = "description"
                } 
            };

            return Task.FromResult<IEnumerable<CompetitionTask>>(list);
        }
    }
}
