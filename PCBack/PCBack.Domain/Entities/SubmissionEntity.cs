namespace PCBack.Domain.Entities
{
    public class SubmissionEntity
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public TaskEntity Task { get; set; }
    }
}
