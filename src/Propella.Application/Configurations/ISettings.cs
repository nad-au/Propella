namespace Propella.Application.Configurations
{
    public interface ISettings<out T>
    {
        public T Value { get; }
    }
}