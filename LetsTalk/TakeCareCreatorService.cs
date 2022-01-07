namespace LetsTalk
{
    public class TakeCareCreatorService : ITalkCreatorService
    {
        SentenceType ITalkCreatorService.Type => SentenceType.TakeCare;

        string ITalkCreator.Say()
        {
            return "Take care of yourself, and have a good time!";
        }
    }
}
