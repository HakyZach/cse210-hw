using System;

class EntryL {
    
    private List<Entry> Zlist;
    public EntryL(){
        Zlist = new List<Entry>();
    }
    public void NewEntry(){
        // List<string> prompt = new List<string>();

        // prompt.Add("What was the best part of today? ");
        // prompt.Add("What do you wish you could've done today? ");
        // prompt.Add("What didn't go as planned today? ");
        // prompt.Add("What did you do for someone else today? ");
        // prompt.Add("What was the strongest emotion you felt today? ");

        // DateTime current = DateTime.Now;
        // string current1 = current.ToString("MM/dd/yyyy");
        // var random = new Random();

        // int i = random.Next(prompt.Count);
        // string question = prompt[i];
        // Console.WriteLine(question);
        // string answer = Console.ReadLine();
        //Entry fullEntry =($"{current} | {question} | {answer}");
        //Zlist.Add(new Entry(current1, question, answer));
        //return fullEntry;
    }

    public void addEntry(string current, string question, string answer){
        //string fullEntry = ($"{current} | {question} | {answer}");
        Zlist.Add(new Entry(current, question, answer));
    }
    public List<Entry> CopyE(){
        List<Entry> Total = new List<Entry>();
        foreach(Entry t in Zlist){
            Total.Add(t);
        }
        return Total;
    }
}