namespace DatabaseGenerator.Generators.DataWarehouse
{
    class AirBaseGenerator : GeneratorBase
    {


        public AirBaseGenerator(int howMany) : base(howMany)
        {
            Path = "C:\\Users\\Snooking\\Desktop\\Różne\\HD\\Data\\Warehouse\\AirBases.csv";
        }

        public override string Generate()
        {
            var generated = string.Empty;

            generated +=
                "1;Gdynia;Polska;Pomorskie\n"
                + "2;Warszawa;Polska;Mazowskie\n"
                + "3;Berlin;Niemcy;-\n"
                + "4;Hamburg;Niemcy;-\n"
                + "5;Drezno;Niemcy;Saksonia\n"
                + "6;Londyn;Anglia;Wielki Londyn\n"
                + "7;Birmingham;Anglia;West Midlands\n"
                + "8;Liverpool;Anglia;North West England\n"
                + "9;Bristol;Anglia;South West\n"
                + "10;Paryż;Francja;Ile-de-France\n";
            return generated;
        }
    }
}
