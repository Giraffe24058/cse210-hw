using System;
using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
{
    Random rand = new Random();
    int hiddenCount = 0;
    int attempts = 0;

    while (hiddenCount < numberToHide && attempts < 100)
    {
        int index = rand.Next(_words.Count);

        if (!_words[index].IsHidden())
        {
            _words[index].Hide();
            hiddenCount++;
        }

        attempts++;
    }
}


    public string GetRenderedText()
    {
        string renderedWords = string.Join(" ", _words.ConvertAll(w => w.GetRenderedText()));
        return $"{_reference.GetDisplayText()} \n   {renderedWords}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }

};