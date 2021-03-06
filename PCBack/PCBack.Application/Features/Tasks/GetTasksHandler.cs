using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PCBack.Application.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PCBack.Application.Features.Tasks
{
    public class GetTasksHandler : IRequestHandler<GetTasksQuery, IEnumerable<CompetitionTask>>
    {
        private readonly IPcDbContext dbContext;
        private readonly IMapper mapper;

        public GetTasksHandler(IPcDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<CompetitionTask>> Handle(GetTasksQuery request, CancellationToken cancellationToken)
        {

            var tasks = await dbContext.Tasks.ToListAsync();
            return mapper.Map<IEnumerable<CompetitionTask>>(tasks);
        }
    }
}
