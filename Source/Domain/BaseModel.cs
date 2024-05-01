namespace Domain
{
    /// <summary>
    /// Represents a base model with an identifier and audit trail properties.
    /// </summary>
    public abstract class BaseModel : BaseTrailModel
    {
        /// <summary>
        /// Gets or sets the unique identifier for the entity.
        /// </summary>
        public virtual Guid Id { get; set; }
    }
}