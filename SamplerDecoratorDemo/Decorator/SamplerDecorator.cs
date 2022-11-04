using SamplerDecoratorDemo.Component;

namespace SamplerDecoratorDemo.Decorator
{
    public abstract class SamplerDecorator : ISampler
    {
        private readonly ISampler _sampler;

        protected SamplerDecorator(ISampler sampler)
        {
            _sampler = sampler;
        }
        
        public virtual void Sample()
        {
            _sampler.Sample();
        }
    }
}