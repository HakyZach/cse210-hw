using System;

class reflect{

    public void actR(){
            act a = new act();
            List<string> prompt = new List<string>();
            prompt.Add("--Think of a time you did something very difficult--");
            prompt.Add("--Think of a time you failed--");
            prompt.Add("--Think of a time you tried something new--");
            prompt.Add("--Think of a time you needed help--");

            List<string> question = new List<string>();
            question.Add("How did you feel when it was over?");
            question.Add("What did you learn from that experience?");
            question.Add("How do you think it would go if you did it again?");
            question.Add("What was your favorite thing about this experience?");
            question.Add("Why did you do it in the first place?");

        Console.WriteLine("Welcome to the reflection activity!");
        Console.WriteLine("");
        Console.WriteLine("This activity will help you reflect on times in your life where you have shown strength and resilience.");
        
        int dur = a.wait();

        var random = new Random();
        int give = random.Next(prompt.Count);
        string scene = prompt[give];
        Console.WriteLine(scene);
        Console.WriteLine("When you have something in mind press enter");
        var ready = Console.ReadLine();

        Console.WriteLine("Now ponder on the following questions as they relate to this experience.");
        Console.Write("You may begin in:");
        for(int w = 5; w>0;w--){
            Console.Write(w);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        Console.Clear();
        DateTime begin = DateTime.Now;
        DateTime end = begin.AddSeconds(dur);

        while (DateTime.Now < end){
            var ask = new Random();
            int x = ask.Next(question.Count);
            Console.WriteLine(question[x]);
            a.spin();
        }
        Console.WriteLine($"Well done! You've completed {dur} seconds of the reflection activity");
        a.spin();
    }
}