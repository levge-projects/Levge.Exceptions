namespace Levge.Exceptions
{
    /// <summary>
    /// Exception thrown when a user is not authorized to perform an action or access a resource.
    /// </summary>
    public class LevgeUnauthorizedException : LevgeException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LevgeUnauthorizedException"/> class with a default message.
        /// </summary>
        public LevgeUnauthorizedException() : base("You are not authorized to perform this action.")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LevgeUnauthorizedException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the authorization error.</param>
        public LevgeUnauthorizedException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LevgeUnauthorizedException"/> class with a specified error message 
        /// and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The message that describes the authorization error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        public LevgeUnauthorizedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}