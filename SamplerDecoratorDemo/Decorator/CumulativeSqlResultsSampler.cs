using System;
using SamplerDecoratorDemo.Component;

namespace SamplerDecoratorDemo.Decorator
{
    public class CumulativeSqlResultsSampler : SqlResultsSampler
    {
        public CumulativeSqlResultsSampler(ISampler sampler) : base(sampler)
        {
        }

        private string PrimaryTable = Toggle ? TableA : TableB;
        private string RefTable = Toggle ? TableB : TableA;
        
        private static bool Toggle;
        private const string TableA = "Table A";
        private const string TableB = "Table B";

        protected override void CreateQuery()
        {
            base.CreateQuery();
            Console.WriteLine($"Running cumulative from Primary:{PrimaryTable}, Ref:{RefTable}");
            Invert();
        }

        private void Invert()
        {
            Toggle = !Toggle;
        }
    }
}