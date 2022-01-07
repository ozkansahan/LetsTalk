namespace LetsTalk
{
    public class ThanksCreatorService : ITalkCreatorService
    {
        SentenceType ITalkCreatorService.Type => SentenceType.Thanks;

        string ITalkCreator.Say()
        {
            return "You are welcome.";
        }
    }
}
