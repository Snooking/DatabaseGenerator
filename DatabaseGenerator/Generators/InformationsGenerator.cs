namespace DatabaseGenerator.Generators
{
    internal class InformationsGenerator : GeneratorBase
    {
        private string[] _machineIds;
        private readonly string[] Localization =
        {
            "WZL 01",
            "WZL 02",
            "PAZP oddzial Warszawa",
            "PAZP oddzial Deblin",
            "Luftwaffehauptflughafen Berlin",
            "Nellis Air Force Technical Facility Nevada"
        };

        public InformationsGenerator(int howMany, string[] machineIds) : base(howMany)
        {
            Path = "C:\\Users\\Snooking\\Desktop\\Różne\\HD\\Data\\Informations.bulk";
            _machineIds = machineIds;
        }

        public override string Generate()
        {
            string generated = string.Empty;
            for (int i = 0; i < _howMany; i++)
            {
                generated += (i + 1).ToString() + "|"
                    + _machineIds[_random.Next() % _machineIds.Length] + "|"
                    + (_random.Next() % 175000000 + 1000000).ToString() + "|"
                    + Localization[_random.Next() % Localization.Length] + "|"
                    + GetRandomEarlyDate() + "|"
                    + GetRandomLateDate()
                    + "\n";
            }
            return generated;
        }
    }
}
