internal class Program
{
    private static void Main(string[] args)
    {
        Man man = new Man();
        Console.Write("Enter your name: ");
        var reverzeName = man.GetName(Console.ReadLine());
        Console.WriteLine(reverzeName);

        Console.WriteLine(man.SetName("s a r d o r"));

        man.Name = "Sardor";
    }
}

public abstract class User
{
    public string Name { get; set; }
    public abstract string GetName(string name);
    public virtual string SetName(string name)
    {
        return name;
    }
}

public class Man : User
{
    public override string GetName(string name)
    {
        if (name == null)
        {
            return string.Empty;
        }

        var reverseName = new string(name.Reverse().ToArray());

        return reverseName;
    }

    public override string SetName(string name)
    {
        return name.Replace(" ", ".");
    }
}
public class UserService : IUserService, IManService
{
    public void AddUser(CreateUser create)
    {
        var user = new CreateUser
        {
            Id = Guid.NewGuid(),
            Name = create.Name,
            Email = create.Email,
        };
    }
    public void AddMan(CreateMan create)
    {
        var man = new CreateMan
        {
            Id = Guid.NewGuid(),
            Name = create.Name,
            Address = create.Address
        };
    }
}
public interface IUserService
{
    public void AddUser(CreateUser user);
}

public interface IManService
{
    public void AddMan(CreateMan man);
}
public abstract class BaseEntity
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
}
public class CreateUser : BaseEntity
{
    public string? Email { get; set; }
}

public class CreateMan : BaseEntity
{
    public string? Address { get; set; }
}