namespace Propella.Domain.Configuration
{
    public interface ISettings<out T> where T : class
    {
        public T Value { get; }
    }
}