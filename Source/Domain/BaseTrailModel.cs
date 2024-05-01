using System.ComponentModel.DataAnnotations;

namespace Domain
{
    /// <summary>
    /// Represents a base trail model with audit trail properties.
    /// </summary>
    public abstract class BaseTrailModel
    {
        /// <summary>
        /// Gets or sets the user who created the entity.
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the user who last modified the entity.
        /// </summary>
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the entity was created.
        /// </summary>
        public virtual DateTime CreatedOn { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the entity was last modified.
        /// </summary>
        public virtual DateTime ModifiedOn { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the entity is logically deleted.
        /// </summary>
        public virtual bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets a byte array that acts as a concurrency token for optimistic concurrency control.
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}