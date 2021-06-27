namespace PCBack.Domain.Entities
{
    public class SubmissionEntity
    {
        public string UserName { get; set; }
        public TaskEntity Task { get; set; }
        public string TaskId { get; set; }
    }
}
