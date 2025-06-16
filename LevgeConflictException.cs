namespace Levge.Exceptions
{
    public class LevgeConflictException : LevgeException
    {
        public LevgeConflictException(string message = "Resource already exists.") : base(message)
        {

        }

        public static LevgeConflictException ForField(string field, object? value = null)
        {
            var detail = value != null
                ? $"{field} '{value}' is already in use."
                : $"{field} is already in use.";

            return new LevgeConflictException(detail);
        }
    }
}
