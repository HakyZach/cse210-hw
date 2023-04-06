using System;

class wait{

    public void calc(){
        List<string> anim = new List<string>();
        anim.Add("|");
        anim.Add("/");
        anim.Add("-");
        anim.Add("\\");

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(5);

        int i = 0;

        Console.Clear();
        Console.WriteLine("Checking...");

        while (DateTime.Now < end){

            string s = anim[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= anim.Count){
                i = 0;
            }
        }
    }
}