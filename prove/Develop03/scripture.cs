using System;

class scripture{

    public string script = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
    public int select;

    public string set_script(string newString){

        Random rnd = new Random();
        int select;
        
        string[] words = newString.Split(" ");

        for(int i=0; i<3; i++){

        select = rnd.Next(words.Length);
        words[select] = "____";
        }

        return string.Join(" ", words);
    }

    public string get_script(){
        return script;
    }
}