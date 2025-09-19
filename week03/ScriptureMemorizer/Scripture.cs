using System.Linq;

public class Scripture
{
    private readonly Reference _reference;

    private readonly List<Word> _words;

    public Scripture(Reference reference, string text, string book, int chapter, int verse, int endVerse)
    {
        _reference = reference;
        string scriptureText = text;
        _words = scriptureText.Split(' ').Select(word => new Word(word)).ToList();
        
        // _reference = new Reference(book, chapter, verse, endVerse);
        // string scriptureText = _reference.GetScriptureText();
        // _words = scriptureText.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random randomGenerator = new();
        int wordsHidden = 0;

        while (wordsHidden < numberToHide)
        {
            int index = randomGenerator.Next(0, _words.Count);
            Word word = _words[index];

            if (!word.IsHidden())
            {
                word.Hide();
                wordsHidden++;
            }
       }
    }
}