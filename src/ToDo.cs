namespace OneHelper.Api.Entities
{
    public class ToDo
    {
        public required int ID { get; set; }
        public required string Title { get; set; } = string.Empty;
        public required ToDoItem ToDoType { get; set; }
        public string? Description { get; set; } = string.Empty;
        public required TimeSpan StartTime { get; set; }
        public required DateTime EndTime { get; set; }
        public required int PriorityLevel { get; set; }
        public bool? IsCompleted { get; set; }   

    }

    public enum ToDoItem
    {
        Work, Personal
    }
}
