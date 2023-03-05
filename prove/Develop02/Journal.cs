using System.IO;

class Journal{
    private EntryL listOfEntries;
    public int numEntries;
    public Journal(){
        listOfEntries = new EntryL();
        numEntries = 0;
    }
    public void AddNewEntry(){
        List<string> prompt = new List<string>();

        prompt.Add("What was the best part of today? ");
        prompt.Add("What do you wish you could've done today? ");
        prompt.Add("What didn't go as planned today? ");
        prompt.Add("What did you do for someone else today? ");
        prompt.Add("What was the strongest emotion you felt today? ");

        DateTime current = DateTime.Now;
        string current1 = current.ToString("MM/dd/yyyy");
        var random = new Random();

        int i = random.Next(prompt.Count);
        string question = prompt[i];
        Console.WriteLine(question);
        string answer = Console.ReadLine();
        listOfEntries.addEntry(current1, question, answer);
        numEntries = numEntries + 1;

    }
    public void JournalShow(){
        List<Entry> Shown = listOfEntries.CopyE();
        if (Shown.Count == 0){
            Console.WriteLine("No entries to display");
        }
        foreach (Entry item in Shown)
        {
            Console.WriteLine(item);
            Console.WriteLine(" ");
        }
    }

    public void JournalSave(){
        string filename = "Journal.txt";
        int i;
        // string saved;
        List<Entry> SaveList = listOfEntries.CopyE();
        // using (StreamWriter outputFile = new StreamWriter(filename)){
        //     for(i = 0; i<SaveList.Count; i++){
        //         saved = SaveList[i].Ecurrent + '|' + SaveList[i].Equestion + '|' + SaveList[i].Eanswer; 
        //         outputFile.WriteLine(saved);
        //     }
            //couldn' get streamwriter to work
        
        int count = SaveList.Count();
        string[] strings = new string[count];
        i = 0;
        foreach(Entry entry in SaveList){
            strings[i++] = entry.Ecurrent + '|' + entry.Equestion + '|' + entry.Eanswer; 
        }
        File.WriteAllLines(filename, strings);
    }
    

    public void JournalLoad(){
        string filename = "Journal.txt";
        listOfEntries = new EntryL(); //Re-initialize list of entries
        string[] lines = System.IO.File.ReadAllLines(filename);

        for(int i = 0; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            
            //need to save parts to current journal in memory
            listOfEntries.addEntry(parts[0], parts[1], parts[2]);

        }
    numEntries = lines.Length;
    }

}