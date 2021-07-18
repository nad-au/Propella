namespace Propella.Application.Results
{
    public class Err
    {
        public static Error NotFound(string? field = null) =>
            new Error { Code = "1001", Field = field, Message = field != null ? $"{field} not found" : null};
        
        public static Error NotNull(string? field = null) =>
            new Error { Code = "1002", Field = field, Message = field != null ? $"{field} not found" : null};
    }
}