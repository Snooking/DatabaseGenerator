namespace DatabaseGenerator.Generators.DataWarehouse
{
    class MechanicsMoneyGenerator : GeneratorBase
    {
        private int _howManyEarlier;
        private bool _early;

        public MechanicsMoneyGenerator(int howMany, int howManyEarlier, bool early) : base(howMany)
        {
            Path = "C:\\Users\\Snooking\\Desktop\\Różne\\HD\\Data\\Warehouse\\MechanicsMoneys.csv";
            _howManyEarlier = howManyEarlier;
            _early = early;
        }

        public override string Generate()
        {
            var generated = string.Empty;

            for (int i = 0; i < _howMany; i++)
            {
                generated += (i + 1 + _howManyEarlier) + ";"
                    + (_random.Next() % (_early ? 3500 : 3000) + (_early ? 1 : 3500)).ToString() + ";"
                    + (_random.Next() % 15000 + 5000).ToString()
                    + "\n";
            }
            return generated;
        }
    }
}
