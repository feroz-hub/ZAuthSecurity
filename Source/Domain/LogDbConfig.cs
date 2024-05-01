namespace Domain
{
    /// <summary>
    /// Represents configuration settings for logging to a database.
    /// </summary>
    public class LogDbConfig
    {
        /// <summary>
        /// Gets or sets the type of database to log to.
        /// </summary>
        public DbTypes Database { get; set; }

        /// <summary>
        /// Gets or sets the connection string for the database.
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the minimum log level that messages must have to be logged.
        /// </summary>
        public Log RestrictedToMinimumLevel { get; set; }

        /// <summary>
        /// Gets or sets the minimum log level to configure.
        /// </summary>
        public Log MinimumConfiguration { get; set; } = Log.Error;
    }
}