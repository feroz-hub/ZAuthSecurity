using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities.Api;

/// <summary>
/// DB Entity representing UserRoles table.
/// </summary>
public class UserRoles : IdentityUserRole<Guid>
{
    /// <summary>
    /// Gets or sets the Id.
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public virtual Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the Valid From Date.
    /// </summary>
    public virtual DateTime ValidFrom { get; set; }

    /// <summary>
    /// Gets or sets the Valid To Date.
    /// </summary>
    public virtual DateTime ValidTo { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether IsDeleted Flag is marked on deleted records.
    /// </summary>
    public virtual bool IsDeleted { get; set; }

    /// <summary>
    /// Gets or sets CreatedOn.
    /// </summary>
    public virtual DateTime CreatedOn { get; set; }

    /// <summary>
    /// Gets or sets CreatedOn.
    /// </summary>
    public virtual DateTime ModifiedOn { get; set; }

    /// <summary>
    /// Gets or sets CreatedBy.
    /// </summary>
    public virtual string CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets ModifiedBy.
    /// </summary>
    public virtual string ModifiedBy { get; set; }

    /// <summary>
    /// Gets or sets for handling concurrency.
    /// </summary>
    [Timestamp]
    public byte[] RowVersion { get; set; }
}