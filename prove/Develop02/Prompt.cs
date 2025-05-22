using System;
using System.ComponentModel.DataAnnotations;


public class Prompt
{
    private List<string> _prompts = new List<string>()
    {
        "How do I feel about my efforts today?",
        "Who did I interact with today?",
        "Did I learn anything new today?",
        "What books am I looking forward to reading?",
        "Where have I seen something good in my life?",
    };

    private Random _random = new Random();

    public string Get_Prompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}




