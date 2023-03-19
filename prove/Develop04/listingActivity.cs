using System;

class list{
    public void actL(){
        act a = new act();

        Console.WriteLine("Welcome to this listing activity!");
        Console.WriteLine("This activity will help you recflect on the good things in your life by having you list as man things as you can in a certain area.");
    
        int dur = a.wait();

        List<string> good = new List<string>();
        good.Add("--What have you improved on this month?--");
        good.Add("--When have  you felt the Holy Ghost this month?--");
        good.Add("--Who can you turn to if you need help?--");
        good.Add("--What has made you smile recently?--");

        var rand = new Random();
        int sel = rand.Next(good.Count);

        Console.WriteLine("alist as many responces as you can from the following prompt");
        Console.WriteLine(good[sel]);
        Console.Write("You may begin in:");
        for(int w = 5; w>0;w--){
            Console.Write(w);
            Thread.Sleep(1000);
            Console.Write("\b");
        }

        DateTime begin = DateTime.Now;
        DateTime end = begin.AddSeconds(dur);

        int count = 0;

        while (DateTime.Now < end){
            
            Console.ReadLine();
            count++;
        }
        Console.WriteLine($"You listed {count} items");

        Console.WriteLine($"Well done! You've completed {dur} seconds of the listing activity");
        a.spin();

    }
}