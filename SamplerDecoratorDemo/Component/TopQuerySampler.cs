using System;

namespace SamplerDecoratorDemo.Component
{
    public class TopQuerySampler : ISampler
    {
        public void Sample()
        {
            Console.WriteLine("Sampling Top Queries");
        }
    }
}