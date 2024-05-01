namespace Domain
{
    /// <summary>
    /// Represents an error in the application framework.
    /// </summary>
    public class FrameworkError
    {
        /// <summary>
        /// Gets or sets the error code associated with the framework error.
        /// </summary>
        public string Code { get; set; } = string.Empty;
        
        /// <summary>
        /// Gets or sets the description of the framework error.
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}