using Microsoft.AspNetCore.Identity;

namespace Domain.Entities.Api;

/// <summary>
/// DB Entity representing UserTokens table.
/// </summary>
public class UserTokens : IdentityUserToken<Guid>
{
    /// <summary>
    /// Gets or sets a value indicating whether IsDeleted Flag is marked on deleted records.
    /// </summary>
    public virtual bool IsDeleted { get; set; } = false;
}