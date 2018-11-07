using DatabaseGenerator.Generators;
using System;
using System.Collections.Generic;

namespace DatabaseGenerator
{
    internal class GodClass
    {
        private int _mechanicsNumber;
        private int _machinesNumber;
        private int _modernizationsNumber;
        private int _repairsNumber;
        private int _informationsNumber;
        private int _machinesParametersNumber;
        private int _participationsNumber;

        private const string MechanicsQuestion = "How many mechanics do you want?";
        private const string MachinesQuestion = "How many machines do you want?";
        private const string InformationsQuestion = "How many informations do you want?";

        public void AskForAll()
        {
            _mechanicsNumber = AskForOne(MechanicsQuestion);
            _machinesNumber = AskForOne(MachinesQuestion);
            _informationsNumber = AskForOne(InformationsQuestion);
        }

        private int AskForOne(string question)
        {
            Console.WriteLine(question);
            var howMany = 0;
            while (!int.TryParse(Console.ReadLine(), out howMany))
            {
                Console.WriteLine("Wrong value");
            }
            return howMany;
        }

        public void Generate()
        {
            var machinesGenerator = new MachinesGenerator(_machinesNumber);
            var mechanicsGenerator = new MechanicsGenerator(_machinesNumber);
            var informationsGenerator = new InformationsGenerator(_informationsNumber, machinesGenerator.Ids);
            _repairsNumber = new Random().Next() % _informationsNumber;
            _modernizationsNumber = _informationsNumber - _repairsNumber;
            _machinesParametersNumber = _machinesNumber;
            _participationsNumber = _informationsNumber;
            var generators = new List<GeneratorBase>
            {
                machinesGenerator,
                mechanicsGenerator,
                informationsGenerator,
                new ModernizationsGenerator(_modernizationsNumber, _repairsNumber),
                new RepairsGenerator(_repairsNumber),
                new MachinesParametersGenerator(_machinesParametersNumber, machinesGenerator.Ids),
                new ParticipationsGenerator(_participationsNumber, _informationsNumber, mechanicsGenerator.Pesels)
            };

            var fileWriter = new FileWriter();

            foreach (var generator in generators)
            {
                var valueToWrite = generator.Generate();
                fileWriter.WriteToFile(generator.Path, valueToWrite);
            }
        }
    }
}
