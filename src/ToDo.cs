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

        public void AddSleep()
        {
            try
            {
                Console.WriteLine("Add Sleep");
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Add", ex);
            }
        }

        public void DeleteToDo()
        {
            try
            {
                Console.WriteLine("Deleted Sleep");
            }
            catch (Exception ex)
            {
                throw new Exception("Error in deletion", ex);
            }
        }

        public void UpdateToDo()
        {
            try
            {
                Console.WriteLine("Updated Sleep");
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Updated", ex);
            }
        }

        public void ReadToDo()
        {
            try
            {
                Console.WriteLine("Read Sleep");
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Read", ex);
            }
        }
    }

    public enum ToDoItem
    {
        Work, Personal
    }
}
