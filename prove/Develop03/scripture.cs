public class Scripture
{
    private Reference _reference;
    private List<Word> _contents;
    private List<Word> _visibleWords;

    public Scripture(Reference newScripture)
    {
        _reference = newScripture;
        List<Word> contents = new List<Word>{};
        List<Word> visibleWords = new List<Word>{};

        string[] words = _reference.Contents().Split(' ');

        int index = 0;
        foreach (string word in words)
        {
            Word currentWord = new Word(index, word, _reference);
            contents.Add(currentWord);
            visibleWords.Add(currentWord);
        }

        _contents = contents;
        _visibleWords = visibleWords;
    }
    public void DisplayReference()
    {
        Console.WriteLine(_reference.DisplayRefString());
    }
    public void DisplayScripture()
    {
        foreach (Word word in _contents)
        {
            Console.Write(word.DisplayWord() + " ");
        }
    }

    public void RunHideWord()
    {
        int length = _contents.Count() / 10;
        if (length > _visibleWords.Count())
        {
            length = _visibleWords.Count();
        }

        Random selectRandom = new Random();

        int count = 0;
        while (count < length)
        {
            int selectWord = selectRandom.Next(_visibleWords.Count());

            _visibleWords[selectWord].HideWord();

            _visibleWords.RemoveAt(selectWord);

            count += 1;
        }
    }

    public int RemainingWords()
    {
        return _visibleWords.Count();
    }

    public void ResetScripture()
    {
        foreach (Word word in _contents)
        {
            word.ShowWord();
        }
    }
}