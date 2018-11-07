namespace DatabaseGenerator.Generators
{
    internal abstract class GeneratorBase
    {
        protected int _howMany;

        public GeneratorBase(int howMany)
        {
            _howMany = howMany;
        }

        public abstract string Generate();
    }
}
