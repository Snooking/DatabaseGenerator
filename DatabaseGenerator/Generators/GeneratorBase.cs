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

        protected string GetRandomDate()
        {
            return (_random.Next() % 17 + 2001 + "-" + (_random.Next() % 12 + 1) + "-" + (_random.Next() % 28 + 1)).ToString();
        }

        protected string GetRandomEarlyDate()
        {
            return (_random.Next() % 9 + 2001 + "-" + (_random.Next() % 12 + 1) + "-" + (_random.Next() % 28 + 1)).ToString();
        }

        protected string GetRandomLateDate()
        {
            return (_random.Next() % 8 + 2010 + "-" + (_random.Next() % 12 + 1) + "-" + (_random.Next() % 28 + 1)).ToString();
        }

        public abstract string Generate();
    }
}
