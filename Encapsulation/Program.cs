// See https://aka.ms/new-console-template for more information

using Encapsulation;
UserAccount user = new UserAccount("admin", "12345", 100);
if (user.Login("12345"))
{
    Console.WriteLine("Login successful");
}
user.Deposit(50);

Console.WriteLine("Current balance: " + user.GetBalance());
Console.WriteLine("Username: " + user.Username);