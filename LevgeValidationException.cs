namespace Levge.Exceptions
{
    public class LevgeValidationException : LevgeException
    {
        public IReadOnlyDictionary<string, string[]> Errors { get; }

        public LevgeValidationException(Dictionary<string, string[]> errors) : base("One or more validation errors occurred.")
        {
            Errors = errors;
        }

        public LevgeValidationException(string field, string message) : this(new Dictionary<string, string[]> { { field, new[] { message } } })
        {

        }
    }
}
