using System;

class questL{

    public int genNum(){
        Random rand = new Random();
        int num = rand.Next(1, 12);

        return num;
    }
}