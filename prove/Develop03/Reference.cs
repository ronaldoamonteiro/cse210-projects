public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public string Book
    {
        get { return _book; }
    }

    public int Chapter
    {
        get { return _chapter; }
    }

    public int Verse
    {
        get { return _verse; }
    }

    public override string ToString()
    {
        return $"{_book} {_chapter}:{_verse}";
    }
}