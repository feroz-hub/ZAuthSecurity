namespace Domain.Entities.Api;

/// <summary>
/// DB Entity representing UserSecurityQuestions table.
/// </summary>
public class UserSecurityQuestions : BaseEntity
{
    /// <summary>
    /// Gets or sets the User Id.
    /// </summary>
    public virtual Guid UserId { get; set; }

    /// <summary>
    /// Gets or sets the SecurityQuestion Id.
    /// </summary>
    public virtual Guid SecurityQuestionId { get; set; }

    /// <summary>
    /// Gets or sets the Answer for Security Question.
    /// </summary>
    public virtual string Answer { get; set; }

    /// <summary>
    /// Gets or sets the User.
    /// </summary>
    public virtual Users User { get; set; }

    /// <summary>
    /// Gets or sets the SecurityQuestion.
    /// </summary>
    public virtual SecurityQuestions SecurityQuestion { get; set; }
}