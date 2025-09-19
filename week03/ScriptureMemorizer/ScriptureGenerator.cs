public class ScriptureGenerator
{
    private Random _randomGenerator;
    private int _randomIndex;
    private List<Reference> _scriptureReference;
    private List<string> _scriptureText;

    public ScriptureGenerator(){
        _randomGenerator = new Random();
        _scriptureReference = [];
        _scriptureText = [];
        // Add creative, meaningful references
        AddScripture("John", 3, 16, "For God so loved the world, that he gave his only begotten Son...");
        AddScripture("Proverbs", 3, 5, "Trust in the Lord with all thine heart; and lean not unto thine own understanding.");
        AddScripture("Mosiah", 2, 17, "When ye are in the service of your fellow beings ye are only in the service of your God.");
        AddScripture("2 Nephi", 2, 25, "Adam fell that men might be; and men are, that they might have joy.");
        AddScripture("Romans", 8, 28, "And we know that all things work together for good to them that love God...");
        AddScripture("Ether", 12, 27, "And if men come unto me I will show unto them their weakness.");
        AddScripture("Psalms", 23, 1, "The Lord is my shepherd; I shall not want.");
        AddScripture("Alma", 37, 6, "By small and simple things are great things brought to pass.");
    }

    private void AddScripture(string book, int chapter, int verse, string text)
    {
        _scriptureReference.Add(new Reference(book, chapter, verse));
        _scriptureText.Add(text);
    }

    public Reference GetScriptureReference()
    {
        _randomIndex = _randomGenerator.Next(0, _scriptureReference.Count);
        return _scriptureReference[_randomIndex];
    }

    public string GetScriptureText()
    {
        return _scriptureText[_randomIndex];
    }
}