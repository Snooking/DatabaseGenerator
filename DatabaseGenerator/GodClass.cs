using DatabaseGenerator.Generators;
using DatabaseGenerator.Generators.DataWarehouse;
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
        private int _datesNumber;

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
            var early = false;
            _datesNumber = early ? 3500 : 3000;
            var machinesGenerator = new PlaneGenerator(_machinesNumber, early);
            var mechanicsGenerator = new MechanicGenerator(_mechanicsNumber, early ? 0 : 150);
            var informationsGenerator = new PlaneRepairGenerator(_informationsNumber, _machinesNumber, _datesNumber, _mechanicsNumber, early);
            _repairsNumber = new Random().Next() % _informationsNumber;
            _modernizationsNumber = _informationsNumber - _repairsNumber;
            _machinesParametersNumber = _machinesNumber;
            _participationsNumber = _informationsNumber;
            var generators = new List<GeneratorBase>
            {
                machinesGenerator,
                mechanicsGenerator,
                informationsGenerator,
                new DateGenerator(_datesNumber, new DateTime(2010, 8, 2)),
                new MechanicsMoneyGenerator(_mechanicsNumber + 225, early ? 0 : 150, early),
                new AirBaseGenerator(10)
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
