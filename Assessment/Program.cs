using System;
using Assessment.Contract;
using Assessment.Library;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Assessment
{
    public class Program
    {
        private static ServiceProvider serviceProvider;
        public static void setup()
        {
         serviceProvider = new ServiceCollection()
         .AddLogging()
         .AddTransient<ICalculator, Calculator>()
         .BuildServiceProvider();
        }
        static void Main(string[] args)
        {
            setup();
            var calc = serviceProvider.GetService<ICalculator>();
            Console.WriteLine(calc.Add(2, 2));
            Console.WriteLine(calc.Sub(23, 2));
            Console.Read();

        }
    }
}
