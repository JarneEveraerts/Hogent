using Cui;
using Domein;
using Persistentie;
using System;

namespace Main
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Services.Configurator = new Configurator(args);
            Console.WriteLine(Services.Configurator.DbConnection);
            (new StartUp()).Run();
        }

        private void Run()
        {
            IAutoRepository autoRepo = new AutoRepository();
            IOnderhoudRepository onderhoudRepo = new OnderhoudRepository();
            GarageDBApp app = new GarageDBApp(new DomeinController(autoRepo, onderhoudRepo));

            app.BewerkDB();
        }
    }
}