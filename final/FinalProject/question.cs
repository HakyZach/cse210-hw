using System;

class question{
    
    public void quiz(string type){

        add a = new add();
        sub s = new sub();
        mult m = new mult();
        div d = new div();
        wait w = new wait();


        Console.WriteLine("Please answer the following questions");
        int result = 0;
        switch (type){

            case "1":
            result = a.Aquiz();
            
            break;

            case "2":
            result = s.Squiz();
            break;

            case "3":
            result = m.Mquiz();
            break;

            case "4":
            result = d.Dquiz();
            break;

        }
        
        w.calc();
        Console.Clear();
        Console.WriteLine($"You got {result} out of 3 questions correct");
        Console.WriteLine("press enter to continue");
        Console.ReadLine();
    }

}
