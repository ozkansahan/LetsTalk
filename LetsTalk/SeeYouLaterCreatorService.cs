namespace LetsTalk
{
    public class SeeYouLaterCreatorService : ITalkCreatorService
    {
        SentenceType ITalkCreatorService.Type => SentenceType.SeeYouLater;

        string ITalkCreator.Say()
        {
            return "So long, see you later.";
        }
    }
}
