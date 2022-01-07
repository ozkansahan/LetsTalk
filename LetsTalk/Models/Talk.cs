namespace LetsTalk.Models
{
    public class Talk
    {
        public string sentence { get; set; }

        public Talk() { }

        public Talk(string sentence)
        {
            this.sentence = sentence;
        }
    }
}
