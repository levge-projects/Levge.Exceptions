namespace Levge.Exceptions
{
    /// <summary>
    /// Base exception class for all custom Levge exceptions.
    /// </summary>
    public class LevgeException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LevgeException"/> class.
        /// </summary>
        public LevgeException() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LevgeException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public LevgeException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LevgeException"/> class with a specified error message
        /// and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        public LevgeException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
