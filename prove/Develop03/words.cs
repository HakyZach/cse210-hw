using System;

class words{

    public bool empty(string input){
        string remainder = input.Replace(" ", "");
        remainder = remainder.Replace("_", "");

        if (remainder.Length == 0){
            return false;
        }
        else{
            return true;
        }
    }
}