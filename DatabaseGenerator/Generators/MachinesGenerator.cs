using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseGenerator.Generators
{
    internal class MachinesGenerator : GeneratorBase
    {
        private string[] _ids;
        private readonly string[] Models = 
        {
            "model"
        };

        public MachinesGenerator(int howMany) : base(howMany)
        {
            _ids = new string[howMany];
            for (int i = 0; i < howMany; i++)
            {
                _ids[i] = "id";
            }
        }

        public override string Generate()
        {
            string generated = string.Empty;
            var random = new Random();
            for (int i = 0; i < _howMany; i++)
            {
                generated += _ids[i] + "|" + Models[random.Next() % Models.Length] + "\n";
            }
            return generated;
        }
    }
}
