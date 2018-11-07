namespace DatabaseGenerator.Generators
{
    internal class ModernizationsGenerator : GeneratorBase
    {
        private int _howManyRemonts;

        private readonly string[] HowOften =
        {
            "2 miesiace",
            "3.5 miesiaca",
            "pol roku lub co 300 godzin nalotu",
            "kwartalna lub co 225 godzin nalotu",
            "57 dni",
            "72 dni"
        };

        public ModernizationsGenerator(int howMany, int howManyRemonts) : base(howMany)
        {
            Path = "C:\\Users\\Snooking\\Desktop\\Różne\\HD\\Data\\Modernizations.bulk";
            _howManyRemonts = howManyRemonts;
        }

        public override string Generate()
        {
            string generated = string.Empty;
            for (int i = 0; i < _howMany; i++)
            {
                generated += (i + _howManyRemonts + 1).ToString() + "|"
                    + HowOften[_random.Next() % HowOften.Length] + "|"
                    + (_random.Next() % 2).ToString()
                    + "\n";
            }
            return generated;
        }
    }
}
