using System;

class Program
{
    static void Main(string[] args)
    {
        bool c = true;
        goal g = new goal();

        while(c){
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2.List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select an option from the menu ");

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
                    g.setNew();
                    break;

                case "2":
                    
                    break;

                case "3":
                    g.save();
                    break;
                case "4":
                     g.load();
                    break;

                case "5":
                
                    break;
                
                case "6":
                Console.WriteLine("Goodbye");
                    c = false;
                    break;
                
                default:
                Console.WriteLine("Invalid Entry");
                break;
    }
}
}
}
        

        