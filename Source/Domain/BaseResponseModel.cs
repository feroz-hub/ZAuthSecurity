namespace Domain
{
    /// <summary>
    /// Represents a base response model used for conveying response information.
    /// </summary>
    public abstract class BaseResponseModel:BaseModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether the response contains an error.
        /// </summary>
        public bool IsError { get; set; }

        /// <summary>
        /// Gets or sets the error code associated with the response.
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets the description of the error associated with the response.
        /// </summary>
        public string ErrorDescription { get; set; }
    }
}