namespace Levge.Exceptions
{
    /// <summary>
    /// Exception thrown when a resource conflict occurs, typically when trying to create a resource that already exists.
    /// </summary>
    public class LevgeConflictException : LevgeException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LevgeConflictException"/> class with an optional custom message.
        /// </summary>
        /// <param name="message">The message that describes the conflict error.</param>
        public LevgeConflictException(string message = "Resource already exists.") : base(message)
        {
        }

        /// <summary>
        /// Creates a new <see cref="LevgeConflictException"/> for a specific field that is already in use.
        /// </summary>
        /// <param name="field">The name of the field that has a conflict.</param>
        /// <param name="value">The value of the field that is already in use.</param>
        /// <returns>A new instance of <see cref="LevgeConflictException"/> with a detailed message.</returns>
        public static LevgeConflictException ForField(string field, object? value = null)
        {
            var detail = value != null
                ? $"{field} '{value}' is already in use."
                : $"{field} is already in use.";

            return new LevgeConflictException(detail);
        }
    }
}
