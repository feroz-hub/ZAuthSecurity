namespace Domain
{
    /// <summary>
    /// Enum representing different types of database systems.
    /// </summary>
    public enum DbTypes
    {
        /// <summary>
        /// Microsoft SQL Server database.
        /// </summary>
        SqlServer = 1,
        
        /// <summary>
        /// MySQL database.
        /// </summary>
        MySql = 2,
        
        /// <summary>
        /// PostgresSql database.
        /// </summary>
        PostgresSql = 3,
        
        /// <summary>
        /// SQLite database.
        /// </summary>
        Sqlite = 4
    }

    /// <summary>
    /// Enum representing different destinations for writing logs.
    /// </summary>
    public enum WriteLogTo
    {
        /// <summary>
        /// Write logs to a file.
        /// </summary>
        File,

        /// <summary>
        /// Write logs to a database.
        /// </summary>
        Database
    }
    /// <summary>
    /// Enum representing different types of rolling intervals for log files.
    /// </summary>
    public enum RollingIntervalType
    {
        /// <summary>
        /// Roll log files at the start of each month.
        /// </summary>
        Month,

        /// <summary>
        /// Roll log files at the start of each day.
        /// </summary>
        Day,

        /// <summary>
        /// Roll log files at the start of each hour.
        /// </summary>
        Hour,

        /// <summary>
        /// Roll log files at the start of each minute.
        /// </summary>
        Minute
    }
    /// <summary>
    /// Enum representing different levels of logging.
    /// </summary>
    public enum Log
    {
        /// <summary>
        /// Debug-level logging.
        /// </summary>
        Debug,

        /// <summary>
        /// Error-level logging.
        /// </summary>
        Error,

        /// <summary>
        /// Fatal-level logging.
        /// </summary>
        Fatal,

        /// <summary>
        /// Information-level logging.
        /// </summary>
        Information,

        /// <summary>
        /// Verbose-level logging.
        /// </summary>
        Verbose,

        /// <summary>
        /// Warning-level logging.
        /// </summary>
        Warning
    }
    /// <summary>
    /// Enum representing the status of a result.
    /// </summary>
    public enum ResultStatus
    {
        /// <summary>
        /// Indicates that the operation succeeded.
        /// </summary>
        Succeeded,

        /// <summary>
        /// Indicates that the operation failed.
        /// </summary>
        Failed
    }
    /// <summary>
    /// Enum representing different CRUD (Create, Read, Update, Delete) operations.
    /// </summary>
    public enum CrudMode
    {
        /// <summary>
        /// Represents the "Add" operation.
        /// </summary>
        Add,

        /// <summary>
        /// Represents the "Update" operation.
        /// </summary>
        Update,

        /// <summary>
        /// Represents the "Delete" operation.
        /// </summary>
        Delete
    }



}