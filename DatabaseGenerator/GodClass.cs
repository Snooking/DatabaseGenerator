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
        private const string ModernizationsQuestion = "How many modernizations do you want?";
        private const string RepairsQuestion = "How many repairs do you want?";
        private const string InformationsQuestion = "How many informations do you want?";
        private const string MachinesParametersQuestion = "How many machines parameters do you want?";
        private const string ParticipationsQuestion = "How many participations do you want?";

        private string _inserts;

        public void AskForAll()
        {
            _mechanicsNumber = AskForOne(MechanicsQuestion);
            _machinesNumber = AskForOne(MachinesQuestion);
            _modernizationsNumber = AskForOne(ModernizationsQuestion);
            _repairsNumber = AskForOne(RepairsQuestion);
            _informationsNumber = AskForOne(InformationsQuestion);
            _machinesParametersNumber = AskForOne(MachinesParametersQuestion);
            _participationsNumber = AskForOne(ParticipationsQuestion);
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
            var generators = new List<GeneratorBase>
            {
                new MachinesGenerator(_machinesNumber)
            };
            foreach (var generator in generators)
            {
                _inserts += generator.Generate();
            }
            var fileWriter = new FileWriter(_inserts);
        }
    }
}
