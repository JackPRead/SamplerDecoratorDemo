using System;
using SamplerDecoratorDemo.Component;
using SamplerDecoratorDemo.Decorator;

namespace SamplerDecoratorDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var topQuerySampler = new TopQuerySampler();
            topQuerySampler.Sample();
            Break();

            var cumulative = new CumulativeSqlResultsSampler(topQuerySampler);
            cumulative.Sample();
            Break();

            var tempTable = new TempTableCumulativeSqlResultsSampler(topQuerySampler);
            tempTable.Sample();
            Break();

            Console.ReadLine();
        }

        private static void Break()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine();
        }
    }
}