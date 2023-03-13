class ScriptureGenerator
{
    private readonly List<Scripture> _scriptures;

    public ScriptureGenerator(List<Scripture> scriptures)
    {
        _scriptures = scriptures;
    }

    public Scripture SelectRandomScripture()
    {
        var random = new Random();
        var index = random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}
