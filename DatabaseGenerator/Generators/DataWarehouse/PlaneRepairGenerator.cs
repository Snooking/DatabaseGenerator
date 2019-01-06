namespace DatabaseGenerator.Generators.DataWarehouse
{
    class PlaneRepairGenerator : GeneratorBase
    {
        private int _howManyPlanes;
        private int _howManyDates;
        private int _howManyMechanics;
        private bool _early;

        public PlaneRepairGenerator(int howMany, int howManyPlanes, int howManyDates, int howManyMechanics, bool early) : base(howMany)
        {
            Path = "C:\\Users\\Snooking\\Desktop\\Różne\\HD\\Data\\Warehouse\\PlaneRepairs.csv";
            _howManyDates = howManyDates;
            _howManyPlanes = howManyPlanes;
            _howManyMechanics = howManyMechanics;
            _early = early;
        }

        public override string Generate()
        {
            var generated = string.Empty;

            for (int i = 0; i < _howMany; i++)
            {
                var earlierDate = _random.Next() % _howManyDates + 1 + (_early ? 0 : 3500);
                var laterDate = earlierDate + _random.Next() % 100;
                generated += (_random.Next() % _howManyPlanes + 1).ToString() + ";"
                    + (i + 1).ToString() + ";"
                    + earlierDate.ToString() + ";"
                    + laterDate.ToString() + ";"
                    + (_random.Next() % _howManyMechanics + 1).ToString() + ";"
                    + (_random.Next() % 200000 + 20000).ToString() + ";"
                    + (laterDate - earlierDate).ToString() + ";"
                    + (_random.Next() % 200 + 20).ToString()
                    + "\n";
            }
            return generated;
        }
    }
}
