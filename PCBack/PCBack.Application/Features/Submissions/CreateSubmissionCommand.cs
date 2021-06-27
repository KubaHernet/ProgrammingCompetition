using MediatR;

namespace PCBack.Application.Features.Submissions
{
    public class CreateSubmissionCommand : IRequest<SubmissionResult>
    {
        public string TaskId { get; set; }
        public string UserName { get; set; }
        public string Language { get; set; }
        public string Solution { get; set; }
    }
}
