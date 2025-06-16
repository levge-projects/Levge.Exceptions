namespace Levge.Exceptions
{
    public class LevgeNotFoundException : LevgeException
    {
        public LevgeNotFoundException(string resource, object? key = null) : base($"{resource} was not found{(key != null ? $" (Key: {key})" : "")}.")
        {

        }
    }
}
