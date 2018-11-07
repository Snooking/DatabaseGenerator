namespace DatabaseGenerator.Generators
{
    internal class MachinesParametersGenerator : GeneratorBase
    {
        private string[] _machineIds;

        private readonly string[] Engines =
        {
            "JT9D turbofan",
            "General motors X10-35",
            "General Electric F138",
            "General Electric F110",
            "Wright R-2600"
        };

        public MachinesParametersGenerator(int howMany, string[] machineIds) : base(howMany)
        {
            Path = "C:\\Users\\Snooking\\Desktop\\Różne\\HD\\Data\\MachinesParameters.bulk";
            _machineIds = machineIds;
        }

        public override string Generate()
        {
            string generated = string.Empty;
            for (int i = 0; i < _howMany; i++)
            {
                generated += _machineIds[_random.Next() % _machineIds.Length] + "|"
                    + (_random.Next() % 58000 + 22000).ToString() + "|"
                    + Engines[_random.Next() % Engines.Length] + "|"
                    + (_random.Next() % 35000 + 5000).ToString() + "|"
                    + (_random.Next() % 2500 + 2500).ToString() + "|"
                    + (_random.Next() % 610000 + 140000).ToString() + "|"
                    + GetRandomEarlyDate() + "|"
                    + GetRandomLateDate()
                    + "\n";
            }
            return generated;
        }
    }
}
