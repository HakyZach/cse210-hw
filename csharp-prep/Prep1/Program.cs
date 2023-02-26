using System;
class Program{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string f = Console.ReadLine();

        Console.Write("What is your last name? ");
        string l = Console.ReadLine();

        Console.WriteLine($"Your name is {l}, {f} {l}.");
    }
}