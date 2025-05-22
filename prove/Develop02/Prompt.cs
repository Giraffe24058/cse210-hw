using System;


public class Prompt
{
    private List<string> _prompts = new List<string>()
    {
        "How do you feel about your efforts today?",
        "Who did you interact with today?",
        "What’s a memory that always makes you laugh?",
        "Did you learn anything new today?",
        "What books are you looking forward to reading?",
        "Where have you seen something good in your life?",
    };

      private List<string> _trivia = new List<string>()
    {
        "Would you rather explore space or the deep ocean?",
        "Would you rather have a pet dragon or a pet wyvern?",
        "What superpower would you want and why?",
        "If you could visit any country right now, where would you go?",
        "Would you rather time travel to the past or the future?",
        "What’s your zombie apocalypse survival plan?",
        "What’s a food you love but rarely eat?",
        "If animals could talk, which would be the rudest and which would you want to talk to?",
        "Would you rather fly or be invisible?",
        "What’s a weird skill you’d like to master?",
        "What’s a movie you could watch forever?",
        "What cartoon character did you relate to as a kid?",
        "Would you rather always have to sing or always dance?",
        "If you opened a restaurant, what would you serve?"
    };

    private Random _random = new Random();

    public string Get_Prompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetTriviaPrompt()
    {
        int index = _random.Next(_trivia.Count);
        return _trivia[index];
    }
}





