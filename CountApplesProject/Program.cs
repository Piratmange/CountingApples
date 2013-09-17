using System;
    
class Program
{
    static void Main()
    {
        Console.WriteLine("HOW MANY APPLES DO WE HAVE TOGETHER?\n");

        string personOne = "Martin";
        int martinApples = 7;

        // TODO: Classmate must add his / hers name and how many apples he / she have
        string personTwo = "Magnus"; 
        int MagnusApples = 2;

        // TODO: Classmate must add his / hers name and how many apples he / she have
        string personThree = "PersonThree";
        int personThreeApples = 0;

        // TODO: Classmate must add his / hers name and how many apples he / she have
        string personFour = "PersonFour";
        int personFourApples = 0;


        int totalApples = martinApples + MagnusApples +  personThreeApples;

        Console.WriteLine("My name is " + personOne + " and I have " + martinApples + " apples.");
        Console.WriteLine("My name is " + personTwo + " and I have " + MagnusApples + " apples.");
        Console.WriteLine("My name is " + personThree + " and I have " + personThreeApples + " apples.");
        Console.WriteLine("My name is " + personFour + " and I have " + personFourApples + " apples.");

        Console.WriteLine("\nTogether we have " + totalApples + " apples. That will be one hell of an apple pie!!!");
        

    }
}
