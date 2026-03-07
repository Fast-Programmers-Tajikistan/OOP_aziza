internal class Program
{
    private static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        Console.Write("Enter x number: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y number: ");
        double y = double.Parse(Console.ReadLine());
        var sub = calculator.Subtract(x, y);

        Console.WriteLine($"{x} - {y} = {sub}");


        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        int c = int.Parse(Console.ReadLine());

        var disc = calculator.Disciminant(a, b, c);
        Console.WriteLine($"D = {disc}");
        Console.WriteLine(calculator.Message());
    }
}

public class Calculator
{
    public double Sum(double x, double y)
    {
        return x + y;
    }
    public double Subtract(double x, double y)
    {
        return x - y;
    }
    public double Disciminant(double a, double b, double c)
    {
        double d = Math.Pow(b, 2) - 4 * a * c;
        return d;
    }

    public string Message()
    {
        return "Hello";
    }
}