using System;

class check : goal{

    public void newcheck(){
        Console.WriteLine("What is the name of your goal? ");
        string gname = Console.ReadLine();
        Console.WriteLine("Give a short description. ");
        string gdes = Console.ReadLine();
        Console.WriteLine("How many points will this be worth? ");
        string gvalue = Console.ReadLine();
        Console.WriteLine("How many times are needed for a bonus? ");
        string bonus = Console.ReadLine();
        Console.WriteLine("How many points is the bonus worth? ");
        string bvalue = Console.ReadLine();
    }
    
}