namespace LetsTalk
{
    public class HiCreatorService : ITalkCreatorService
    {
        SentenceType ITalkCreatorService.Type => SentenceType.Hi;

        string ITalkCreator.Say()
        {
            return "Hello!";
        }
    }
}
