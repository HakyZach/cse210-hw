using System;

class Program
{
    
    static void Main(string[] args){

        string display;
        scripture s = new scripture();
        words w = new words();
        display = s.get_script();

        bool c = true;

        while(c){
            Console.Clear();
            Console.WriteLine(display);
            Console.WriteLine("John 3:16");
            c = w.empty(display);
            Console.WriteLine("Press enter to hide words or type quit to exit ");

            string action = Console.ReadLine();
            if (action == "quit"){
                Console.WriteLine("thank you");
                c = false;
            }
            else{
                display = s.set_script(display);
                Console.WriteLine(display);
            }
        }
    }
}