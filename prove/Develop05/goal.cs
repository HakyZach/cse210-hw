using System;

class goal{
    simple s = new simple();
    eternal e = new eternal();
    check ch = new check();
    public void setNew(){
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal do you want to create? ");
        string type = Console.ReadLine();

        switch(type){
            case "1":
            s.newsimple();
            break;
            
            case "2":
            e.neweternal();
            break;

            case "3":
            ch.newcheck();
            break;

            default:
            Console.WriteLine("invalid entry");
            break;
        }

        
    }
    public void save(){

    }
    public void load(){

    }
}