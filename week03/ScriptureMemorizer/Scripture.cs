using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;


    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        _random = new Random();
        _words = scriptureText.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = new();
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                visibleWords.Add(w);
            }
        }

        if (visibleWords.Count == 0)
        {
            return;
        }

        for (int idx = 0; idx < numberToHide; idx++)
        {
            if (visibleWords.Count == 0)
                break;

            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }


    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
                return false;
        }
        return true;
    }


    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + "\n";

        for (int i = 0; i < _words.Count; i++)
        {
            result += _words[i].GetDisplayText();
            if (i < _words.Count - 1)
                result += " ";
        }

        return result;
    }
}