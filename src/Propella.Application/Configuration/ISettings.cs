namespace Propella.Application.Configuration
{
    public interface ISettings<out T>
    {
        public T Value { get; }
    }
}