namespace Levge.Exceptions
{
    /// <summary>
    /// Exception thrown when a requested resource cannot be found.
    /// </summary>
    public class LevgeNotFoundException : LevgeException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LevgeNotFoundException"/> class with a specified resource name and optional key.
        /// </summary>
        /// <param name="resource">The name of the resource that could not be found.</param>
        /// <param name="key">The key or identifier of the resource that could not be found.</param>
        public LevgeNotFoundException(string resource, object? key = null) : base($"{resource} was not found{(key != null ? $" (Key: {key})" : "")}.")
        {
        }
    }
}
