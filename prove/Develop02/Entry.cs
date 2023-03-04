using System;

class Entry {

    public string NewEntry(){
        List<string> prompt = new List<string>();

        prompt.Add("What was the best part of today? ");
        prompt.Add("What do you wish you could've done today? ");
        prompt.Add("What didn't go as planned today? ");
        prompt.Add("What did you do for someone else today? ");
        prompt.Add("What was the strongest emotion you felt today? ");

        DateTime current = DateTime.Now;
        var random = new Random();

        int question = random.Next(prompt.Count);
    Console.WriteLine(prompt[question] );
    string answer = Console.ReadLine();
    string fullEntry =($"{current}, {question} {answer}");

    return fullEntry;
    }
}