public class Reference
{
    private readonly string _book = "";

    private readonly int _chapter;

    private readonly int _verse;

    private readonly int?_endVerse;


    private readonly Dictionary<string, Dictionary<int, string>> _scriptures = new()
    {
        ["proverbs"] = new Dictionary<int, string>
        {
            [1] = "My son, forget not my law; but let thine heart keep my commandments:",
            [2] = "For length of days, and long life, and peace, shall they add to thee.",
            [3] = "Let not mercy and truth forsake thee: bind them about thy neck; write them upon the table of thine heart:",
            [4] = "So shalt thou find favour and good understanding in the sight of God and man.",
            [5] = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.",
            [6] = "In all thy ways acknowledge him, and he shall direct thy paths."
        },
        ["genesis"] = new Dictionary<int, string>
        {

            [1] = "In the beginning God created the heaven and the earth.",
            [2] = "And the earth was without form, and void; and darkness was upon the face of the deep. And the Spirit of God moved upon the face of the waters.",
            [3] = "And God said, Let there be light: and there was light.",
            [4] = "And God saw the light, that it was good: and God divided the light from the darkness.",
            [5] = "And God called the light Day, and the darkness he called Night. And the evening and the morning were the first day.",
            [6] = "And God said, Let there be a firmament in the midst of the waters, and let it divide the waters from the waters."

        },
        ["psalms"] = new Dictionary<int, string>
        {
            [1] = "Blessed is the man that walketh not in the counsel of the ungodly, nor standeth in the way of sinners, nor sitteth in the seat of the scornful.",
            [2] = "But his delight is in the law of the Lord; and in his law doth he meditate day and night.",
            [3] = "And he shall be like a tree planted by the rivers of water, that bringeth forth his fruit in his season; his leaf also shall not wither; and whatsoever he doeth shall prosper.",
            [4] = "The ungodly are not so: but are like the chaff which the wind driveth away.",
            [5] = "Therefore the ungodly shall not stand in the judgment, nor sinners in the congregation of the righteous.",
            [6] = "For the Lord knoweth the way of the righteous: but the way of the ungodly shall perish."
        },
        ["revelation"] = new Dictionary<int, string>
        {
            [1] = "The Revelation of Jesus Christ, which God gave unto him, to shew unto his servants things which must shortly come to pass...",
            [2] = "Who bare record of the word of God, and of the testimony of Jesus Christ, and of all things that he saw.",
            [3] = "Blessed is he that readeth, and they that hear the words of this prophecy, and keep those things which are written therein: for the time is at hand.",
            [4] = "John to the seven churches which are in Asia: Grace be unto you, and peace, from him which is, and which was, and which is to come...",
            [5] = "And from Jesus Christ, who is the faithful witness, and the first begotten of the dead, and the prince of the kings of the earth.",
            [6] = "And hath made us kings and priests unto God and his Father; to him be glory and dominion for ever and ever. Amen."
        },
    };

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = null;
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

    public string GetScriptureText()
    {
        int end = _endVerse ?? _verse;
        List<string> verses = [];

        for (int i = _verse; i <= end; i++)
        {
            if (_scriptures[_book].TryGetValue(i, out string value))
            {
                verses.Add(value);
            }
        }
        return string.Join(" ", verses);
    }
}