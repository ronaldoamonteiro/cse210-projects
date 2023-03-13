class Scripture
{
    private readonly Reference _reference;
    private readonly List<Word> _wordList;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _wordList = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideWords()
    {
        var random = new Random();
        var hiddenCount = Math.Max(1, _wordList.Count / 4);
        var hiddenWords = new List<Word>();

        while (hiddenWords.Count < hiddenCount)
        {
            var index = random.Next(_wordList.Count);
            var word = _wordList[index];

            if (!word.IsHidden())
            {
                word.Hide();
                hiddenWords.Add(word);
            }
        }
    }

    public string GetRenderedText()
    {
        var renderedText = "";

        foreach (var word in _wordList)
        {
            renderedText += word.GetRenderedText() + " ";
        }

        return $"{_reference.Book} {_reference.Chapter}:{_reference.Verse}\n\n{renderedText.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        return _wordList.All(word => word.IsHidden());
    }
}