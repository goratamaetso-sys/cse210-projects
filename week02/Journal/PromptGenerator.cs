using System;
using System.Collections.Generic;

public class PromptGenerator 
{
    private List<string>_prompts = new List<string>

    {
        "What was the best part of your day?",
        "What are you grateful for today?",
        "What challenge did you overcome today?",
        "Who made a positive impact on your day?",
        "What did you learn today?",
        "What made you smile today?"
    };  

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
     
   

   