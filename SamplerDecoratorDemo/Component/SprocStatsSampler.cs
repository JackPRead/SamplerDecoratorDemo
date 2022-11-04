using System;

namespace SamplerDecoratorDemo.Component
{
    public class SprocStatsSampler : ISampler
    {
        public void Sample()
        {
            Console.WriteLine("Sampling Sproc Stats");
        }
    }
}