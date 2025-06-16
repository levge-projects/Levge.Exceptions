namespace Levge.Exceptions
{
    public class LevgeException : Exception
    {
        public LevgeException(string message) : base(message)
        {

        }

        public LevgeException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
