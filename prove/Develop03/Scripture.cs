using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private string _reference;
    private string _text;
    private List<string> _hiddenWords;

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _text = text;
        _hiddenWords = new List<string>();
    }

    public string GetReference()
    {
        return _reference;
    }

    public string GetVisibleText()
    {
        string visibleText = _text;
        foreach (string word in _hiddenWords)
        {
            visibleText = visibleText.Replace(word, new string('_', word.Length));
        }
        return visibleText;
    }

    public bool HideRandomWord()
    {
        List<string> wordsToHide = _text.Split(' ').ToList();
        wordsToHide.RemoveAll(word => _hiddenWords.Contains(word));
        if (wordsToHide.Count > 0)
        {
            Random random = new Random();
            string wordToHide = wordsToHide[random.Next(wordsToHide.Count)];
            _hiddenWords.Add(wordToHide);
            return true;
        }
        return false;
    }
}

public class ScriptureLibrary
{
    private List<Scripture> _scriptures;
    private Random _random;

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();
        _random = new Random();
        InitializeLibrary();
    }

    private void InitializeLibrary()
    {
        // Add scriptures to the library
        _scriptures.Add(new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));
        _scriptures.Add(new Scripture("Proverbs 3:5-6", "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."));
        // Add more scriptures as needed
    }

    public Scripture GetRandomScripture()
    {
        return _scriptures[_random.Next(_scriptures.Count)];
    }
}
