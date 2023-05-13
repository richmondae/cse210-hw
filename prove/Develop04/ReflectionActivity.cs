using System;
using System.Diagnostics;

public class ReflectingActivity : Activity
{
    // Attributes 
    private List<string> _promptList = new List<string>
    {
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless.",
    "Think of a time when you failed at something."
    };
    private List<string> _questionList = new List<string>
    {
    "What significance did this experience hold for you?",
   "Have you engaged in similar activities in the past?",
   "What was your starting point for this experience?",
   "What were your emotions upon completion of this experience?",
   "What factors contributed to your success this time around compared to previous attempts?",
   "What aspect of this experience did you enjoy the most?",
   "What general lessons did you take away from this experience that can be applied to other situations?",
   "What did this experience teach you about yourself?",
   "How can you incorporate the lessons learned from this experience into your future endeavors?",
   "What motivated you to pursue this experience?"
    };
    private List<string> _useQuestionsList = new List<string>();

    private string _prompt;
    private string _question;
    private string _description = "Engaging in this activity will allow you to contemplate instances in your life when you displayed fortitude and perseverance. This process will enable you to acknowledge the inner strength you possess and how you can harness it to overcome challenges in other areas of your life.";


    // Constructors
    // Methods
    public ReflectingActivity(string activityName, int activityTime) : base(activityName, activityTime)
    {

    }
    public void GetActivityDescription()
    {
        Console.WriteLine(_description);
    }
    private string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_promptList.Count);
        return _promptList[index];
    }
    private string GetRandomQuestion()
    {
        var random = new Random();
        int index = random.Next(_useQuestionsList.Count);
        return _useQuestionsList[index];
    }
    public void ShowPrompt(int seconds)
    {
        Console.WriteLine();  //insert blank line to start
        var prompt = GetRandomPrompt();
        Console.WriteLine("\nTake into account the given statement:");
        Console.WriteLine($"\n--- {prompt} ---");
        Console.WriteLine($"\nPlease hit the Enter key to proceed once you have a clear idea or thought in mind.");

        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Enter)
        {
            ShowQuestion(seconds);
        }
    }
    public void ShowQuestion(int seconds)
    {
        _useQuestionsList.AddRange(_questionList); //creates a new list that can be destroyed each time.
        Spinner spinner = new Spinner();
        Console.WriteLine($"\nNow ponder on each of the following questions as they related to this experience.");
        CountDown(8);
        Console.Clear();
        Stopwatch timer = new Stopwatch();
        timer.Start();
        while (timer.Elapsed.TotalSeconds < seconds)
        {
            if (_useQuestionsList.Count != 0)
            {
                var question = GetRandomQuestion();
                Console.Write($"\n>> {question}  ");
                _useQuestionsList.Remove(question);  //removes question from list so it can not be used again
            }
            spinner.ShowSpinner();
        }
        timer.Stop();
    }

}