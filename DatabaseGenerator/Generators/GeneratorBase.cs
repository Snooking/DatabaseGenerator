using System;

namespace DatabaseGenerator.Generators
{
    internal abstract class GeneratorBase
    {
        protected int _howMany;
        protected Random _random;
        public string Path;

        protected GeneratorBase(int howMany)
        {
            _howMany = howMany;
            _random = new Random();
        }
        protected string GetRandomDate() => string.Empty;
        protected string GetRandomEarlyDate() => string.Empty;
        protected string GetRandomLateDate() => string.Empty;

        protected string GetRandomDates(string signBetweenDates)
        {
            var year = _random.Next() % 17 + 2001;
            var month = _random.Next() % 12 + 1;
            var day = _random.Next() % 28 + 1;
            return (year + "-" + month + "-" + day).ToString() + signBetweenDates +
                (year + 1 + "-" + (month + _random.Next()) % 12 + 1 + "-" + (day + _random.Next()) % 28 + 1).ToString();
        }

        protected string GetRandomDatesFromTime(string signBetweenDates, bool early)
        {
            return early ? GetRandomEarlyDates(signBetweenDates) : GetRandomLateDates(signBetweenDates);
        }

        protected string GetRandomEarlyDates(string signBetweenDates)
        {
            var year = _random.Next() % 9 + 2001;
            var month = _random.Next() % 12 + 1;
            var day = (_random.Next() % 28 + 1);
            return (year + "-" + month + "-" + day).ToString() + signBetweenDates +
                (year + 1 + "-" + (month + _random.Next()) % 12 + 1 + "-" + (day + _random.Next()) % 28 + 1).ToString();
        }

        protected string GetRandomLateDates(string signBetweenDates)
        {
            var year = _random.Next() % 8 + 2012;
            var month = _random.Next() % 12 + 1;
            var day = (_random.Next() % 28 + 1);
            return (year + "-" + month + "-" + day).ToString() + signBetweenDates +
                (year + 1 + "-" + (month + _random.Next()) % 12 + 1 + "-" + (day + _random.Next()) % 28 + 1).ToString();
        }

        public abstract string Generate();
    }
}
