namespace Domain.Models.Api;

/// <summary>
/// Model for mapping security questions to user along with answer.
/// </summary>
public class UserSecurityQuestionModel : BaseModel
{
    /// <summary>
    /// Gets or sets user unique identifier.
    /// </summary>
    public virtual Guid UserId { get; set; }

    /// <summary>
    /// Gets or sets master question reference identifier.
    /// </summary>
    public virtual Guid SecurityQuestionId { get; set; }

    /// <summary>
    /// Gets or sets security answer.
    /// </summary>
    public virtual string Answer { get; set; }
}