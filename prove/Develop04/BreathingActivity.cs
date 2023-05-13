using System;

public class BreathingActivity : Activity
{
    // Attributes 
    private string _breatheIn = "Breathe in...";
    private string _breatheOut = "Breathe out...";
    private string _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    // Constructors
    // Methods
    public BreathingActivity(string activityName, int activityTime) : base(activityName, activityTime)
    {

    }
    public void GetActivityDescription()
    {
        Console.WriteLine(_description);
    }

    public void Breathing(int seconds)
    {
        Console.WriteLine();  //insert blank line to start
        int secondsTimer = 0;
        while (secondsTimer < seconds)
        {
            Console.WriteLine();  //insert blank line to start
            for (int i = 4; i > 0; i--)
            {
                Console.Write($"{_breatheIn}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_breatheOut.Length + 2));  // Overwrite line
                Console.Write(blank);
                secondsTimer += 1;
            }
            Console.WriteLine($"{_breatheIn}  ");  // last prompt
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{_breatheOut}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_breatheOut.Length + 2));  // Overwrite line
                Console.Write(blank);
                secondsTimer += 1;
            }
            Console.WriteLine($"{_breatheOut}  ");  // last prompt
        }
    }
}











