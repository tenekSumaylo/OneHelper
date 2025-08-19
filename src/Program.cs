using OneHelper.Api.Entities;

class Program
{
    static void Main()
    {
        User user = new();

        Console.WriteLine("\n\nLogin");
        Console.Write("Username: ");
        var username = Console.ReadLine()!;
        Console.Write("Password: ");
        var password = Console.ReadLine()!;

        if (user.Login(username, password))
        {
            Console.WriteLine("Successful Login!!!");
        }
        else
        {
            Console.WriteLine("Unsuccessful Login!!!");
        }
    }
}