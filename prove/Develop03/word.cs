public class Word
{
    private string _wordText;
    private int _index;
    private int _setting;
    private Reference _reference;

    public Word(int index, string word, Reference reference)
    {
        _index = index;
        _wordText = word;
        _reference = reference;
        _setting = 1;
    }

    public void HideWord()
    {
        _setting = 0;
    }

    public void ShowWord()
    {
        _setting = 1;
    }

    public string DisplayWord()
    {
        if (_setting == 1)
        {
            return _wordText;
        }
        else
        {
            char blank;
            int wordLength = _wordText.Count();
            blank = '_';
            return new string(blank, wordLength);
        }
    }
}