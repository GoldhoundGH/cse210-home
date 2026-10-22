public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _verseEnd;
    private string _content;
    private string _refString;

    
    public Reference() // pass "this"
    {
        Console.Write("Enter the book where the scripture is found: ");
        string getBook = Console.ReadLine();
        Console.Write("Enter the scripture's chapter: ");
        string getChapter = Console.ReadLine();
        Console.Write("Enter the verse of the scripture (or starting verse): ");
        string getVerse = Console.ReadLine();
        Console.Write("Enter the last verse of the scripture (or leave blank if there is only one verse): ");
        string getVerseEnd = Console.ReadLine();
        Console.Write("Enter the text of the verses provided: ");
        string getContent = Console.ReadLine();
        
        _book = getBook;
        _chapter = getChapter;
        _verse = getVerse;
        _verseEnd = getVerseEnd;
        GenRefString();
        _content = getContent;
        // and...
    }

    public Reference(string refString, string content)
    {
        string[] splitRefString = DecodeRefString(refString);

        _book = splitRefString[0];
        _chapter = splitRefString[1];
        _verse = splitRefString[2];
        if (splitRefString.Count() == 4) {_verseEnd = splitRefString[3];}
        else {_verseEnd = "";}
        GenRefString();
        _content = content;
    }
    
    public Reference(string getBook, string getChapter, string getVerse, string getContent)
    {
        
        _book = getBook;
        _chapter = getChapter;
        _verse = getVerse;
        _verseEnd = "";
        GenRefString();
        _content = getContent;
        // and...
    }

    public Reference(string getBook, string getChapter, string getVerse, string getVerseEnd, string getContent)
    {
        
        _book = getBook;
        _chapter = getChapter;
        _verse = getVerse;
        _verseEnd = getVerseEnd;
        GenRefString();
        _content = getContent;
        // and...
    }

    private void GenRefString() // creativity compliance
    {   
        string verses;
        if (_verseEnd != "")
        {
            verses = $"{_verse}-{_verseEnd}";
        }
        else
        {
            verses = _verse;
        }
        _refString = $"{_book}^{_chapter}^{verses}";
    }

    private string[] DecodeRefString(string refString) // creativity compliance
    {
        string[] splitRefString = refString.Split(new Char [] {'^','-'});
        return splitRefString;
    }

    public string DisplayRefString(string refString)
    {
        string[] splitRefString = DecodeRefString(refString);
        string verses;
        
        if (splitRefString.Count() == 4) {verses = $"{splitRefString[2]}-{splitRefString[3]}";}
        else {verses = splitRefString[2];}

        string displayRef = $"{splitRefString[0]} {splitRefString[1]}:{verses}";
        return displayRef;
    }

    private void RunScripture()
    {
        Scripture(this);
    }
}