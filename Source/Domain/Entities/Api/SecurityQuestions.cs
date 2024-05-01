namespace Domain.Entities.Api;

/// <summary>
/// DB Entity representing SecurityQuestions table.
/// </summary>
public class SecurityQuestions : BaseEntity
{
    /// <summary>
    /// Gets or sets the Question.
    /// </summary>
    public virtual string Question { get; set; }
}