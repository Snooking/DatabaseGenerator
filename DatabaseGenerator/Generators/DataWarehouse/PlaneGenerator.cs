using System;

namespace DatabaseGenerator.Generators.DataWarehouse
{
    class PlaneGenerator : GeneratorBase
    {
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

        private readonly string[] Engines =
        {
            "JT9D turbofan",
            "General motors X10-35",
            "General Electric F138",
            "General Electric F110",
            "Wright R-2600"
        };
        private string[] _ids;
        private bool _early;

        public PlaneGenerator(int howMany, bool early) : base(howMany)
        {
            Path = "C:\\Users\\Snooking\\Desktop\\Różne\\HD\\Data\\Warehouse\\Planes.csv";
            _ids = new string[howMany];
            for (int i = 0; i < howMany; i++)
            {
                _ids[i] = "SP-";
                _ids[i] += Convert.ToChar(i / 25 + 'A');
                _ids[i] += Convert.ToChar((i / 25) % 25 + 'A');
                _ids[i] += Convert.ToChar(i % 25 + 'A');
            }
            _early = early;
        }

        public override string Generate()
        {
            var generated = string.Empty;

            for (int i = 0; i < _howMany; i++)
            {
                generated += (i + 1).ToString() + ";"
                    + Models[_random.Next() % Models.Length] + ";"
                    + Kinds[_random.Next() % Kinds.Length] + ";"
                    + (_random.Next() % 5000 + 2000).ToString() + ";"
                    + (_random.Next() % 58000 + 22000).ToString() + ";"
                    + Engines[_random.Next() % Engines.Length] + ";"
                    + (_random.Next() % 35000 + 5000).ToString() + ";"
                    + (_random.Next() % 2500 + 2500).ToString() + ";"
                    + (_random.Next() % 610000 + 140000).ToString() + ";"
                    + _ids[i] + ";"
                    + GetRandomDatesFromTime(";", _early)
                    + "\n";
            }
            return generated;
        }
    }
}
