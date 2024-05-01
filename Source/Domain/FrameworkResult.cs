namespace Domain
{
    /// <summary>
    /// Represents the result of an operation in the application framework.
    /// </summary>
    public sealed class FrameworkResult
    {
        /// <summary>
        /// Gets or sets the status of the framework result.
        /// </summary>
        public ResultStatus Status { get; set; } = ResultStatus.Failed;

        /// <summary>
        /// Gets or sets the collection of errors associated with the framework result.
        /// </summary>
        public IEnumerable<FrameworkError> Errors { get; set; }
    }
}