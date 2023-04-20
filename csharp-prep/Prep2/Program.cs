using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Please Enter Your grade? ");
        string response =  Console.ReadLine();
        int percentage =int.Parse(response);

        String letter ="";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter ="C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else if (percentage >= 50)
        {
            letter = "E";
        }
        else
        {
            letter = "F";
        }
       int lastDigit = percentage % 10;
        string sign = "";

        if (letter == "A" && percentage != 100)
        {
            if (lastDigit >= 7)
            {
                sign = "-";
                letter += sign;
            }
            else if (lastDigit < 3)
            {
                sign = "+";
                letter += sign;
            }
        }
        else if (letter == "F")
        {
            if (percentage == 50)
            {
                letter = "E";
            }
        }
        else
        {
            if (lastDigit >= 3 && lastDigit <= 6)
            {
                sign = " ";
                letter += sign;
            }
            else if (lastDigit >= 7)
            {
                sign = "+";
                letter += sign;
            }
            else if (lastDigit < 3)
            {
                sign = "-";
                letter += sign;
            }
        }

       Console.WriteLine($"Your grade is: {letter}");

       if (percentage >= 70)
       {
            Console.WriteLine("Congratulations, you passed!");
       }
       else
       {
            Console.WriteLine("Try again and don't give up.");
       }
    }   
}