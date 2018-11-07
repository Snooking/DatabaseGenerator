using System;

namespace DatabaseGenerator.Generators
{
    internal class MachinesGenerator : GeneratorBase
    {
        public string[] Ids;
        private readonly string[] Models =
        {
            "Boeing 707",
            "Boeing 777",
            "Gulfstream G550",
            "Embraer E2",
            "C130",
            "C-17",
            "C-295"
        };
        private readonly string[] Kinds =
        {
            "pasazerskie",
            "cargo"
        };

        public MachinesGenerator(int howMany) : base(howMany)
        {
            Ids = new string[howMany];
            for (int i = 0; i < howMany; i++)
            {
                Ids[i] = "SP-";
                Ids[i] += Convert.ToChar(i / 25 + 'A');
                Ids[i] += Convert.ToChar((i / 25) % 25 + 'A');
                Ids[i] += Convert.ToChar(i % 25 + 'A');
            }
            Path = "C:\\Users\\Snooking\\Desktop\\Różne\\HD\\Data\\Machines.bulk";
        }

        public override string Generate()
        {
            string generated = string.Empty;
            for (int i = 0; i < _howMany; i++)
            {
                generated += Ids[i] + "|"
                    + Models[_random.Next() % Models.Length] + "|"
                    + Kinds[_random.Next() % Kinds.Length] + "|"
                    + (_random.Next() % 5000 + 2000).ToString() + "|"
                    + GetRandomDate()
                    + "\n";
            }
            return generated;
        }
    }
}
