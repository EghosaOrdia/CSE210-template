public class Word
{
    private string _text = "";
    private string _cleanedWord = "";
    private string _trailingPunctuations = "";

    private bool _isHidden;

    public Word(string word)
    {
        _text = word;
        _cleanedWord = CleanWord(_text);
        _trailingPunctuations = GetTrailingPunctuations(_text);
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _cleanedWord.Length) + _trailingPunctuations : _cleanedWord + _trailingPunctuations;
    }

    private string CleanWord(string word)
    {
        return word.TrimEnd('.', ',', '!', '?', ':', ';');
    }

    private string GetTrailingPunctuations(string word)
    {
        int punctuationStart = CleanWord(word).Length;
        return word.Substring(punctuationStart);
    }
}