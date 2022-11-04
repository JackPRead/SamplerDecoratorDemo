using System;
using SamplerDecoratorDemo.Component;

namespace SamplerDecoratorDemo.Decorator
{
    public class SqlResultsSampler : SamplerDecorator
    {
        public SqlResultsSampler(ISampler sampler) : base(sampler)
        {
        }
        
        public override void Sample()
        {
            CreateQuery();
            base.Sample();
        }

        protected virtual void CreateQuery()
        {
            Console.WriteLine("Creating SQL Query");
        }
    }
}