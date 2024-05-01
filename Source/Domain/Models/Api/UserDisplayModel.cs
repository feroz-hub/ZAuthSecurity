namespace Domain.Models.Api;
/// <summary>
/// Model for storing user information.
/// </summary>
public class UserDisplayModel : BaseModel
{
    /// <summary>
    /// Gets or sets user name for login.
    /// </summary>
    public virtual string UserName { get; set; }

    /// <summary>
    /// Gets or sets password hash value.
    /// </summary>
    public virtual string Password { get; set; }

    /// <summary>
    /// Gets or sets user first name.
    /// </summary>
    public virtual string FirstName { get; set; }

    /// <summary>
    /// Gets or sets user last name.
    /// </summary>
    public virtual string LastName { get; set; }

    /// <summary>
    /// Gets or sets user email.
    /// </summary>
    public virtual string Email { get; set; }

    /// <summary>
    /// Gets or sets user phone number.
    /// </summary>
    public virtual string PhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets user account lock end date and time - for auto unlock.
    /// </summary>
    public virtual DateTimeOffset LockoutEnd { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether user account is locked or not.
    /// </summary>
    public virtual bool LockoutEnabled { get; set; }
}