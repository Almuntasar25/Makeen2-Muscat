
Console.WriteLine("Please enter your name:");
string userValue = Console.ReadLine();
Console.WriteLine($"Hello ya {userValue}");

Console.WriteLine("Are you the admin? (y/n)");
string response = Console.ReadLine();
bool isAdmin = response.ToLower() == "y";

Console.WriteLine($"Hello, your admin state is {isAdmin}");
