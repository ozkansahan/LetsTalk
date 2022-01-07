namespace LetsTalk
{
    public interface ITalkCreatorService : ITalkCreator
    {
        SentenceType Type { get; }
    }
}
