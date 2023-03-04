using System;

class Program
{
static void Main(string[] args)
    {
        bool c = true;
        Journal myJournal = new Journal();
        Entry userEntry = new Entry();  
        string fileName = "Journal.txt";

        while (c){

            Console.WriteLine("You can do any of the following options:");
            Console.WriteLine("1. Add New Entry");
            Console.WriteLine("2. Display Jounal");
            Console.WriteLine("3. Save To File");
            Console.WriteLine("4. Load From File");
            Console.WriteLine("5. Exit");
            Console.Write("Your selection here: ");

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
                    Console.WriteLine("New Entry");
                    userEntry.NewEntry();
                    break;

                case "2":
                    Console.WriteLine("Open Journal");
                    FileInfo fInfo = new FileInfo(fileName);
                    if(fInfo.Exists){
                        myJournal.JournalRead();
                    }
                    break;

                case "3":
                    Console.WriteLine("Save entry to file");
                    myJournal.JournalSave();
                    break;
                case "4":
                    Console.WriteLine("Load from a text file");
                    myJournal.JournalLoad();
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