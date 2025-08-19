namespace OneHelper.Api.Entities
{
    public class SleepLog
    {
        public required int ID { get; set; }
        public required TimeSpan Duration { get; set; }
        public required TimeSpan StartTime { get; set; }
        public required TimeSpan EndTime { get; set; }
        public string? Notes { get; set; } = string.Empty;
        public required DateOnly StartDate { get; set; }
        public required DateOnly EndDate { get; set; }



        public void AddToDo()
        {
            try
            {
                Console.WriteLine("Add to do");
            }
            catch (Exception ex)
            {
                throw new Exception("Error in ADd", ex);
            }
        }

        public void DeleteToDo()
        {
            try
            {
                Console.WriteLine("Deleted to do");
            }
            catch ( Exception ex )
            {
                throw new Exception("Error in deletion", ex);
            }
        }

        public void UpdateToDo()
        {
            try
            {
                Console.WriteLine("Updated to do");
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
                Console.WriteLine("Read to do");
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Read", ex);
            }
        }
    }
}
