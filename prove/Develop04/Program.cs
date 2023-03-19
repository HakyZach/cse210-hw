using System;

class Program
{
    
    static void Main(string[] args)
    {
        breath b = new breath();
        reflect r = new reflect();
        list l = new list();
        bool c = true;

        while(c){
        Console.Clear();
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");

        string action = Console.ReadLine();
        if (action.Length > 0)
        {
            action = action.Substring(0, 1);
        }
        else
        {
            Console.WriteLine("Exiting due to no entry selected");
            break;
        }

        switch (action) 
            {
                case "1":
                    b.actB();
                    
                    break;

                case "2":
                    r.actR();
                    
                    break;

                case "3":
                    l.actL();
                    
                    break;

                case "4":
                Console.WriteLine("Thank you!");
                    c = false;
                    break;
                
                default:
                Console.WriteLine("Invalid Entry");
                break;
    }

        }
    }
}