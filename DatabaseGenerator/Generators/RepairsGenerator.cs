namespace DatabaseGenerator.Generators
{
    internal class RepairsGenerator : GeneratorBase
    {
        private readonly string[] WayOfDamage =
        {
            "awaria podczas lotu",
            "kolizja w powietrzu",
            "kolizja na ziemi",
            "male uszkodzenie mechaniczne",
            "zuzycie czesci",
            "zarysowanie",
            "uszkodzone przez warunki pogodowe",
            "niezidentyfikowana przyczyna"
        };

        public RepairsGenerator(int howMany) : base(howMany)
        {
            Path = "C:\\Users\\Snooking\\Desktop\\Różne\\HD\\Data\\Repairs.bulk";
        }

        public override string Generate()
        {
            string generated = string.Empty;
            for (int i = 0; i < _howMany; i++)
            {
                generated += (i + 1).ToString() + "|"
                    + WayOfDamage[_random.Next() % WayOfDamage.Length] + "|"
                    + (_random.Next() % 101).ToString()
                    + "\n";
            }
            return generated;
        }
    }
}
