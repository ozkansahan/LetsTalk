namespace LetsTalk
{
    public class HowAreYouCreatorService : ITalkCreatorService
    {
        SentenceType ITalkCreatorService.Type => SentenceType.HowAreYou;

        string ITalkCreator.Say()
        {
            return "Not bad and you?";
        }
    }
}
