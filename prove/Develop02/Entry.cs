using System;

class Entry {
    public string Ecurrent;
    public string Equestion;
    public string Eanswer;
    
    
    public Entry(string current, string question, string answer){
        Ecurrent = current;
        Equestion = question;
        Eanswer = answer;
    }
    public override string ToString()
    {
        return Ecurrent + "|" + Equestion + "|" + Eanswer;
    }
}