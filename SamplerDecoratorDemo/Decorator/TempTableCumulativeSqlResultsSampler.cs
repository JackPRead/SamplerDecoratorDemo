using System;
using SamplerDecoratorDemo.Component;

namespace SamplerDecoratorDemo.Decorator
{
    public class TempTableCumulativeSqlResultsSampler : CumulativeSqlResultsSampler
    {
        public TempTableCumulativeSqlResultsSampler(ISampler sampler) : base(sampler)
        {
        }

        protected override void CreateQuery()
        {
            Console.WriteLine("Creating TempTable permissions for reduced user");
            base.CreateQuery();
        }
    }
}