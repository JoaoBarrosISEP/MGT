using MGT.Enums;

namespace MGT.DTOs
{
    public class TaskDto
    {
        public TaskStateEnum TaskState { get; set; }
        public string Description { get; set; }
        public TaskTypeEnum TaskType { get; set; }
    }
}
