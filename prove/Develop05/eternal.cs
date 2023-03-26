using System;

class eternal : goal{

    public void neweternal(){
        Console.WriteLine("What is the name of your goal? ");
        string gname = Console.ReadLine();
        Console.WriteLine("Give a short description. ");
        string gdes = Console.ReadLine();
        Console.WriteLine("How many points will this be worth? ");
        string gvalue = Console.ReadLine();
    }
    
}