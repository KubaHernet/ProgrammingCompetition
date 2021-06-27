using System.Collections.Generic;

namespace PCBack.Domain.Entities
{
    public class TaskEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Input { get; set; }
        public string Result { get; set; }
        public ICollection<SubmissionEntity> Submissions { get; set; }
    }
}
