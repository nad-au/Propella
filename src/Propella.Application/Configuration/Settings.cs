namespace Propella.Application.Configuration
{
    public class Settings<T> : ISettings<T> where T : class
    {
        public Settings(T value)
        {
            Value = value;
        }
        
        public T Value { get; }
    }
}