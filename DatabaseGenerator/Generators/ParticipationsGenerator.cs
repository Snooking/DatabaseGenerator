namespace DatabaseGenerator.Generators
{
    internal class ParticipationsGenerator : GeneratorBase
    {
        private string[] _pesels;
        private int _howManyRemonts;

        public ParticipationsGenerator(int howMany, int howManyRemonts, string[] pesels) : base(howMany)
        {
            Path = "C:\\Users\\Snooking\\Desktop\\Różne\\HD\\Data\\Participations.bulk";
            _howManyRemonts = howManyRemonts;
            _pesels = pesels;
        }

        public override string Generate()
        {
            string generated = string.Empty;
            for (int i = 0; i < _howMany; i++)
            {
                generated += (i + 1).ToString() + "|"
                    + _pesels[_random.Next() % _pesels.Length]
                    + "\n";
            }
            return generated;
        }
    }
}
