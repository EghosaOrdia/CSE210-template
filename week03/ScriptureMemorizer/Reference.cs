public class Reference
{
    private readonly string _book;
    private readonly int _chapter;
    private readonly int _verse;
    private readonly int?_endVerse;
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_endVerse.HasValue && _endVerse != _verse) {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }  
        return $"{_book} {_chapter}:{_verse}";
    }
}