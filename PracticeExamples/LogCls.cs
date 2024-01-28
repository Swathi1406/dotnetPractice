using System;
using Microsoft.Extensions.DependencyInjection;

namespace PracticeExamples
{
	public class Product
	{
		public ILoggerService _logger;
		public Product(ILoggerService logger )
		{
			_logger = logger;
		}

		public void printProduct() {
			
            _logger.logError("Iam from Product");
		}
		
	}


	public class Furniture : Product{


        public Furniture(ILoggerService logger) : base( logger)
        {

		}

		public void print() {
			base.printProduct();
		}

	}

	public class newclass {
        internal ILoggerService log;
        public newclass() {
			Product p = new Product(log);
		}
	}





	public interface ILoggerService
	{
		public void logError(string message);
	}

    public class Logger : ILoggerService
    {
		// Using Log4J library
        public void logError(string message)
        {
			Console.WriteLine($"I am from log4j logger {message}");
        }
    }

    public class AbcLogger : ILoggerService
    {
        // Using Log4J library
        public void logError(string message)
        {
            Console.WriteLine($"I am from AbcLogger {message}");
        }
    }


	public static class DIContainer
	{
		public static IServiceProvider ServiceProvider { get; set; }
		public static void RegisterServices()
		{
			var services = new ServiceCollection();
			services.AddSingleton<ILoggerService, Logger>();
			ServiceProvider = services.BuildServiceProvider();
		}
	}
}



