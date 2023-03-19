using System;

class breath{
    act a = new act();
    public void actB(){ 
        Console.WriteLine("Welcome to the Breathing activity!");
        Console.WriteLine("");
        Console.WriteLine("This activity will help you relax by walking through your breathing. Clear your mind and focus on your breathing.");

        int dur = a.wait();

        DateTime begin = DateTime.Now;
        DateTime end = begin.AddSeconds(dur);

        while (DateTime.Now < end){
            Console.WriteLine("");
            Console.Write("Breathe in...");
            for (int i = 3; i > 0; i--){
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine("");
            Console.Write("Breath out...");
            for(int o = 5; o > 0; o--){
                Console.Write(o);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                
            }
        }
        Console.WriteLine("");
        Console.WriteLine($"Well done! You've completed {dur} seconds of the breathing activity");
        a.spin();
    }
}