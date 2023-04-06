using System;

class Program
{
    
    static void Main(string[] args)
    {
        bool c = true;
        question start = new question();

        while(c){
        Console.Clear();
        Console.WriteLine("Question Types:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Quit");
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
                Console.Clear();
                Console.WriteLine("Addition Problem");
                start.quiz(action);
                    
                    break;

                case "2":
                Console.Clear();
                Console.WriteLine("Subtraction Problem");
                start.quiz(action);
                    
                    break;

                case "3":
                Console.Clear();
                Console.WriteLine("Multiplication Problem");
                start.quiz(action);
                    
                    break;
                case "4":
                Console.Clear();
                Console.WriteLine("Division Problem");
                start.quiz(action);
                        
                    break;

                case "5":
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
    

    

