using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    /// <summary>
    /// Represents a base entity with common properties like Id, creation/modification details, and soft delete flag.
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Gets or sets the unique identifier for the entity.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual Guid Id { get; set; }
        
        /// <summary>
        /// Gets or sets a value indicating whether the entity is logically deleted.
        /// </summary>
        public virtual bool IsDeleted { get; set; } = false;
        
        /// <summary>
        /// Gets or sets the date and time when the entity was created.
        /// </summary>
        public virtual DateTime CreatedOn { get; set; }
        
        /// <summary>
        /// Gets or sets the date and time when the entity was last modified.
        /// </summary>
        public virtual DateTime ModifiedOn { get; set; }
        
        /// <summary>
        /// Gets or sets the user who created the entity.
        /// </summary>
        public virtual string CreatedBy { get; set; }
        
        /// <summary>
        /// Gets or sets the user who last modified the entity.
        /// </summary>
        public virtual string ModifiedBy { get; set; }
        
        /// <summary>
        /// Gets or sets a byte array that acts as a concurrency token for optimistic concurrency control.
        /// </summary>
        [ConcurrencyCheck]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public byte[] RowVersion { get; set; }
    }
}