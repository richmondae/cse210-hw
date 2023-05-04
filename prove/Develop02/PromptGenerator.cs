using System; 
using System.Collections.Generic;

class PromptGenerator
{
    List<string> prompts;

    public PromptGenerator()
    {
        prompts = new List<string>();
    }

    public void AddPrompt(string prompt)
    {
        prompts.Add(prompt);
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}
