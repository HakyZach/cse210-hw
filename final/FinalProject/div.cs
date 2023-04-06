using System;

class div{

    public int Dquiz(){
        questL numA = new questL();
        questL numB = new questL();
        int con = 0;
        int correct = 0;

        while (con < 3){
            int one = numA.genNum();
            int two = numB.genNum();
            int a = one / two;
            string g = a.ToString();
            Console.WriteLine($"What is {one} / {two}?");
            string ans = Console.ReadLine();
            con++;
            if (g == ans){
                correct++;
            }
        }    
        return correct;
    }
}