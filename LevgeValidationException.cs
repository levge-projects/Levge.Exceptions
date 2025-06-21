namespace Levge.Exceptions
{
    /// <summary>
    /// Exception thrown when validation errors occur.
    /// </summary>
    public class LevgeValidationException : LevgeException
    {
        /// <summary>
        /// Gets a dictionary of field names and their associated validation error messages.
        /// </summary>
        public IReadOnlyDictionary<string, string[]> Errors { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LevgeValidationException"/> class with multiple validation errors.
        /// </summary>
        /// <param name="errors">A dictionary of field names and their associated validation error messages.</param>
        public LevgeValidationException(Dictionary<string, string[]> errors) : base("One or more validation errors occurred.")
        {
            Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LevgeValidationException"/> class with a single validation error.
        /// </summary>
        /// <param name="field">The name of the field that failed validation.</param>
        /// <param name="message">The validation error message.</param>
        public LevgeValidationException(string field, string message) : this(new Dictionary<string, string[]> { { field, new[] { message } } })
        {
        }
    }
}
