namespace Domain.Models.Api;

/// <summary>
/// Model for storing master security questions.
/// </summary>
public class SecurityQuestionModel : BaseModel
{
    /// <summary>
    /// Gets or sets security question detail.
    /// </summary>
    public virtual string Question { get; set; }
}