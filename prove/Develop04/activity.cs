using System;

class act{

    public int wait(){

        Console.Write("How long, in seconds would you like for this session? ");
        string ans = Console.ReadLine();
        int t = Convert.ToInt32(ans);
        Console.Clear();
        Console.WriteLine("Get Ready...");
        
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(10);

        int i = 0;

        while (DateTime.Now < end){

            string s = animation[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animation.Count){
                i = 0;
            }
        }
        return t;
    }

    public void spin(){
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(10);

        int i = 0;

        while (DateTime.Now < end){

            string s = animation[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animation.Count){
                i = 0;
            }
        }
    }
}