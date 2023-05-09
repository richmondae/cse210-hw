using System;

public class MathAssignment : Assignment
{
    // Using Attributes 
    private string _textBookSection;
    private string _problems;

    // Using Constructors
    public MathAssignment()
    {
        
    }
    public MathAssignment(string studentName, string topic, string textBookSection, string problems)
        : base(studentName, topic)
    {
        //setting the MathAssignment to specific variables
        _textBookSection = textBookSection;
        _problems = problems;
    }
    public string GetTextBookSection()
    {
        return _textBookSection;
    }
    public void SetTextBookSection(string textBookSection)
    {
        _textBookSection = textBookSection;
    }
    public string GetProblems()
    {
        return _problems;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }

    // Methods
    public string GetHomeworkList()
    {
        return $"Section: {_textBookSection} Problems: {_problems}";
    }


}