

namespace OneHelper.Api.Entities
{
    public class User
    {
        public int ID { get; set; }
        public  string Username { get; set; } = string.Empty;
        public  string Password { get; set; } = string.Empty;
        public  string Gender { get; set; } = string.Empty;
        public  DateOnly DateOfBirth { get; set; }
        public  string Email { get; set; } = string.Empty;
        public  string FirstName { get; set; } = string.Empty;
        public  string LastName { get; set; } = string.Empty;
        public  decimal Height { get; set; }
        public  decimal Weight { get; set; }
        public string? PhoneNumber { get; set; } = string.Empty;

        public void Signup()
        {
            try
            {
                Console.WriteLine("REGISTER ACCOUNT");
                Console.Write("Enter username here: ");
                Username = Console.ReadLine()!;
                Console.Write("Enter password here: ");
                Password = Console.ReadLine()!;
                Console.Write("Enter gender here: ");
                Gender = Console.ReadLine()!;
                Console.Write("Enter email here: ");
                Email = Console.ReadLine()!;
                Console.Write("Enter first name here: ");
                FirstName = Console.ReadLine()!;
                Console.Write("Enter last name here: ");
                LastName = Console.ReadLine()!;
                Console.Write("Enter height here: ");
                Height = Convert.ToDecimal(Console.ReadLine()!);
                Console.Write("Enter weight here: ");
                Weight = Convert.ToDecimal(Console.ReadLine()!);
                Console.Write("Enter phone number here(optional): ");
                PhoneNumber = Console.ReadLine();

            }
            catch (Exception ex)
            {
                throw new Exception("Login Failure", ex);
            }
        }

        public bool Login(string username, string password)
        {
            try
            {
                if (Username.Equals(username) && Password.Equals(password))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Login error, try again", ex);
            }
        }

        public User()
        {
            Signup();
        }
    }
}
