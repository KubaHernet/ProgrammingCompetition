using AutoMapper;
using MediatR;
using PCBack.Application.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PCBack.Application.Features.Submissions
{
    public class CreateSubmissionHandler : IRequestHandler<CreateSubmissionCommand, SubmissionResult>
    {
        private readonly IPcDbContext dbContext;
        private readonly ISubmissionService submissionService;

        public CreateSubmissionHandler(ISubmissionService submissionService, IPcDbContext dbContext)
        {
            this.submissionService = submissionService;
            this.dbContext = dbContext;
        }

        public async Task<SubmissionResult> Handle(CreateSubmissionCommand request, CancellationToken cancellationToken)
        {
            var task = await dbContext.Tasks.FindAsync( new[] { request.TaskId }, cancellationToken);

            var requestParams = (request.Language, request.Solution, task.Input);
            var result = await submissionService.Execute(requestParams, cancellationToken);

            var success = result != null
                    && task.Result.Equals(result, StringComparison.InvariantCultureIgnoreCase);

            return new SubmissionResult {
                Success = success
            };
        }
    }
}
