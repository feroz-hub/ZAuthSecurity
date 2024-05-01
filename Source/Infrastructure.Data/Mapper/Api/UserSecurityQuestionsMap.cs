using Domain.Entities.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;

/// <summary>
/// Configures the mapping between the UserSecurityQuestions entity and its corresponding database table.
/// </summary>
/// <summary>
/// Configures the mapping for the UserSecurityQuestions entity using Entity Framework Core's Fluent API.
/// </summary>
public class UserSecurityQuestionsMap
{
    private const string UserSecurityQuestionsTableName = "UserSecurityQuestions";

    /// <summary>
    /// Initializes a new instance of the <see cref="UserSecurityQuestionsMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">The entity builder for UserSecurityQuestions.</param>
    public UserSecurityQuestionsMap(EntityTypeBuilder<UserSecurityQuestions> entityBuilder)
    {
        UserSecurityQuestionsMapping(entityBuilder);
    }

    /// <summary>
    /// Defines the mapping configuration for the UserSecurityQuestions entity.
    /// </summary>
    /// <param name="entityBuilder">The entity builder for UserSecurityQuestions.</param>
    private static void UserSecurityQuestionsMapping(EntityTypeBuilder<UserSecurityQuestions> entityBuilder)
    {
        if (entityBuilder == null) return;

        // Table name
        entityBuilder.ToTable(UserSecurityQuestionsTableName);

        // Primary Key
        entityBuilder.HasKey(t => t.Id);

        // Indexes
        entityBuilder.HasIndex(t => new { t.UserId, t.SecurityQuestionId }).HasDatabaseName("IX_USRSEC_UID_QUEID").IsUnique();
        entityBuilder.HasIndex(t => t.SecurityQuestionId).HasDatabaseName("IX_USRSEC_QUEID");

        // Properties
        entityBuilder.Property(t => t.Answer).IsRequired().HasMaxLength(255);

        // Column mappings
        entityBuilder.Property(t => t.UserId).IsRequired().HasColumnName("UserId");
        entityBuilder.Property(t => t.SecurityQuestionId).IsRequired().HasColumnName("SecurityQuestionId");
        entityBuilder.Property(t => t.CreatedOn).IsRequired().HasColumnName("CreatedOn");
        entityBuilder.Property(t => t.CreatedBy).IsRequired().HasMaxLength(255).HasColumnName("CreatedBy");
        entityBuilder.Property(t => t.ModifiedOn).HasColumnName("ModifiedOn");
        entityBuilder.Property(t => t.ModifiedBy).HasMaxLength(255).HasColumnName("ModifiedBy");

        // Query filter for soft deletion
        entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);
    }
}
