using System;

namespace DatabaseGenerator.Generators.DataWarehouse
{
    class DateGenerator : GeneratorBase
    {
        private DateTime _startDate;

        public DateGenerator(int howMany, DateTime startDate) : base(howMany)
        {
            Path = "C:\\Users\\Snooking\\Desktop\\Różne\\HD\\Data\\Warehouse\\Dates.csv";
            _startDate = startDate;
        }

        public override string Generate()
        {
            var generated = string.Empty;

            var date = _startDate;
            for (int i = 0; i < _howMany; i++)
            {
                generated += (i + 1).ToString() + ";"
                    + date.Year + ";"
                    + date.Month + ";"
                    + date.Day
                    + "\n";
                date = date.AddDays(1);
            }
            return generated;
        }
    }
}
