// See https://aka.ms/new-console-template for more information
﻿using Polimarphizm;

internal class Program
{
    private static void Main(string[] args)
    {
        Man man = new Man();
        Console.Write("Enter your name: ");
        var reverzeName = man.GetName(Console.ReadLine());
        Console.WriteLine($"Reverze: {reverzeName}");

        User user = new User();
        Console.Write("Enter name: ");
        var userName = user.GetName(Console.ReadLine());
        Console.WriteLine($"userName: {userName}");
    }
}