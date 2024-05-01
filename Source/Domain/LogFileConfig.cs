namespace Domain
{
    /// <summary>
    /// Represents configuration settings for log file generation.
    /// </summary>
    public class LogFileConfig
    {
        // The default format for log messages
        private const string Format =
            "[{Timestamp:yyyy-MM-dd HH:mm:ss}|UserId-{UserId}|MachineName-{MachineName}|{Level}|{Message}|" +
            "{MethodName}|{FileName}|{Exception}{NewLine}";

        /// <summary>
        /// Gets or sets the file path where log files will be stored.
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the rolling interval type for log file rotation.
        /// </summary>
        public RollingIntervalType RollingIntervalType { get; set; } = RollingIntervalType.Day;
        
        /// <summary>
        /// Gets or sets the minimum log level that messages must have to be logged.
        /// </summary>
        public Log RestrictedToMinimumLevel { get; set; }

        /// <summary>
        /// Gets or sets the minimum log level to configure.
        /// </summary>
        public Log MinimumConfiguration { get; set; } = Log.Error;

        /// <summary>
        /// Gets or sets whether to limit the size of log files.
        /// </summary>
        public bool SetLogFileSize { get; set; } = true;

        /// <summary>
        /// Gets or sets the maximum size of log files in bytes.
        /// </summary>
        public long FileSizeInBytes { get; set; } = 5242880; // Default size is 5 MB

        /// <summary>
        /// Gets or sets the output format for log messages.
        /// </summary>
        public string OutputFormat { get; set; } = Format;
    }
}