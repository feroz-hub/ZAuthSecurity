namespace Domain
{
    /// <summary>
    /// Represents configuration settings for logging.
    /// </summary>
    public class LogConfig
    {
        /// <summary>
        /// Gets or sets the name of the logging instance.
        /// </summary>
        public string InstanceName { get; set; }

        /// <summary>
        /// Gets or sets the destination for writing logs.
        /// </summary>
        public WriteLogTo WriteLogTo { get; set; } = WriteLogTo.File;

        /// <summary>
        /// Gets or sets the configuration for logging to a file.
        /// </summary>
        public LogFileConfig LogFileConfig { get; set; } = new LogFileConfig();

        /// <summary>
        /// Gets or sets the configuration for logging to a database.
        /// </summary>
        public LogDbConfig LogDbConfig { get; set; } = new LogDbConfig();
    }
}