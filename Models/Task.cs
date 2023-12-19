using MGT.Enums;

namespace MGT.Models
{
    public class Task
    {
        public int Id { get; set; }

        public TaskStateEnum TaskState { get; set; }

        public string Description { get; set; }

        public TaskTypeEnum TaskType { get; set; }
    }
}
