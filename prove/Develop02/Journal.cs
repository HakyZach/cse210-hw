using System.IO;

class Journal{

    public void JournalRead(){

        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("||");

        }
    }

    public void JournalSave(){
        string filename = "myFile.txt";
        using (StreamWriter outputFile = new StreamWriter(filename)){
            outputFile.WriteLine($"");

        }
    }

    public void JournalLoad(){

    }

}