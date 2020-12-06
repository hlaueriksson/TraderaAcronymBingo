namespace TraderaAcronymBingo.Models
{
    public class Acronym
    {
        public string Value { get; }
        public string Description { get; }

        public Acronym(string value, string description)
        {
            Value = value;
            Description = description;
        }
    }
}