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
        "Would you rather explore space or the deep ocean? \n",
        "Would you rather have a pet dragon or a pet wyvern? \n",
        "What superpower would you want and why? \n",
        "If you could visit any country right now, where would you go? \n",
        "Would you rather time travel to the past or the future? \n",
        "What’s your zombie apocalypse survival plan? \n",
        "What’s a food you love but rarely eat? \n",
        "If animals could talk, which would you want to talk to? \n",
        "Would you rather fly or be invisible? \n",
        "What’s a weird skill you’d like to master? \n",
        "What’s a movie you could watch forever? \n",
        "What cartoon character did you relate to as a kid? \n",
        "Would you rather always have to sing or always dance? \n",
        "If you opened a restaurant, what would you serve? \n"
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





