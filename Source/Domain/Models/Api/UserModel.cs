namespace Domain.Models.Api;

/// <summary>
/// Model for storing user information.
/// </summary>
public class UserModel : BaseModel
{
    /// <summary>
    /// Gets or sets user name for login.
    /// </summary>
    public virtual string UserName { get; set; }

    /// <summary>
    /// Gets or sets password value.
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
    /// Gets or sets user date of birth.
    /// </summary>
    public virtual DateTime DateOfBirth { get; set; }

    /// <summary>
    /// Gets or sets user email.
    /// </summary>
    public virtual string Email { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether user email is verified or not.
    /// <para>Default value set as false.</para>
    /// </summary>
    public virtual bool EmailConfirmed { get; set; } = false;

    /// <summary>
    /// Gets or sets user phone number.
    /// </summary>
    public virtual string PhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether user phone number is verified or not.
    /// <para>Default value set as false.</para>
    /// </summary>
    public virtual bool PhoneNumberConfirmed { get; set; } = false;

    /// <summary>
    /// Gets or sets a value indicating whether 2FA is enabled or not.
    /// </summary>
    public virtual bool TwoFactorEnabled { get; set; }

    /// <summary>
    /// Gets or sets user chosen 2FA type.
    /// <para>Default set as TwoFactorType.None.</para>
    /// </summary>
    public virtual TwoFactorType TwoFactorType { get; set; } = TwoFactorType.None;

    /// <summary>
    /// Gets or sets user account lock end date and time - for auto unlock.
    /// </summary>
    public virtual DateTimeOffset LockoutEnd { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether user account is locked or not.
    /// </summary>
    public virtual bool LockoutEnabled { get; set; }

    /// <summary>
    /// Gets or sets consecutive user login failed count.
    /// </summary>
    public virtual int AccessFailedCount { get; set; }

    /// <summary>
    /// Gets or sets user last pwd changed date and time.
    /// </summary>
    public virtual DateTime LastPasswordChangedDate { get; set; }

    /// <summary>
    /// Gets or sets user account pwd needs to be changed during login.
    /// </summary>
    public virtual bool RequiresDefaultPasswordChange { get; set; }

    /// <summary>
    /// Gets or sets user last login date time.
    /// </summary>
    public virtual DateTime LastLoginDateTime { get; set; }

    /// <summary>
    /// Gets or sets user logout date and time.
    /// </summary>
    public virtual DateTime LastLogoutDateTime { get; set; }

    /// <summary>
    /// Gets or sets user account verification provider type - local or LDAP.
    /// <para>Default value set as IdentityProvider.Local.</para>
    /// </summary>
    public virtual IdentityProvider IdentityProviderType { get; set; } = IdentityProvider.Local;

    /// <summary>
    /// Gets or sets list of user security questions with answer.
    /// </summary>
    public virtual List<UserSecurityQuestionModel> UserSecurityQuestion { get; set; }

    /// <summary>
    /// Gets or sets list of user claims.
    /// </summary>
    public virtual List<UserClaimModel> UserClaims { get; set; }
}