namespace DatabaseGenerator.Generators
{
    internal class MechanicsGenerator : GeneratorBase
    {
        public string[] Pesels;
        private readonly string[] Names =
        {
            "Adrian",
            "James",
            "Michael",
            "John",
            "Anna",
            "Matheo",
            "Sebastian",
            "Adam",
            "Rafael",
            "Szymon",
            "Maciej",
            "Jacek",
            "Alex",
            "Grzegorz",
            "Krzysztof",
            "Norbert",
            "Bartosz",
            "Tomasz",
            "Jarek"
        };
        private readonly string[] Surnames =
        {
            "Smith",
            "Johnson",
            "Williams",
            "Jones",
            "Brown",
            "Davis",
            "Miller",
            "Wilson",
            "Moore",
            "Taylor",
            "Anderson",
            "Thomas",
            "Jackson",
            "White"
        };

        public MechanicsGenerator(int howMany) : base(howMany)
        {
            Path = "C:\\Users\\Snooking\\Desktop\\Różne\\HD\\Data\\Mechanics.bulk";
            Pesels = new string[howMany];
            for (int i=0; i<howMany; i++)
            {
                Pesels[i] = GetRandomPesel();
            }
        }

        private string GetRandomPesel()
        {
            var peselFirstTime = true;
            string pesel;
            do
            {
                peselFirstTime = true;
                pesel = (_random.Next() % 50 + 50).ToString();
                pesel += (_random.Next() % 12 + 1).ToString();
                pesel = pesel.Length == 4 ? pesel : pesel.Insert(2, "0");
                pesel += (_random.Next() % 28 + 1).ToString();
                pesel = pesel.Length == 6 ? pesel : pesel.Insert(4, "0");
                pesel += (_random.Next() % 50000 + 1).ToString();
                while (pesel.Length < 11)
                {
                    pesel += (_random.Next() % 10).ToString();
                }
                for (int i = 0; i < Pesels.Length; i++)
                {
                    if (Pesels[i] == pesel)
                    {
                        peselFirstTime = false;
                        break;
                    }
                }
            } while (!peselFirstTime);
            return pesel;
        }

        public override string Generate()
        {
            string generated = string.Empty;
            for (int i = 0; i < _howMany; i++)
            {
                generated += Pesels[i] + "|"
                    + Names[_random.Next() % Names.Length] + "|"
                    + Surnames[_random.Next() % Surnames.Length] + "|"
                    + ((_random.Next() % 10 * 500) + 7000).ToString()
                    + "\n";
            }
            return generated;
        }
    }
}
