namespace OneHelper.Api.Entities
{
    public class User
    {
        public required int ID { get; set; }
        public required string Username { get; set; } = string.Empty;
        public required string Password { get; set; } = string.Empty;
        public required string Gender { get; set; } = string.Empty;
        public required DateOnly DateOfBirth { get;set; }
        public required string Email { get; set; } = string.Empty;
        public required string FirstName { get; set; } = string.Empty;
        public required string LastName { get; set; } = string.Empty;
        public required decimal Height { get; set; }
        public required decimal Weight { get; set; }
        public string? PhoneNumber { get; set; } = string.Empty;
    }
}
