using Cui;
using Domain;
using Domain.Contracts;
using Infrastructure;

namespace Main
{

    public class StartUp
	{
		public static void Main(string[] args)
		{
			Run();
		}

		private static void Run()
		{
			IAutoRepository autoRepo = new AutoRepository();
			IOnderhoudRepository onderhoudRepo = new OnderhoudRepository();
			GarageDBApp app = new(new DomeinController(autoRepo, onderhoudRepo));

			app.BewerkDB();
		}
	}

}