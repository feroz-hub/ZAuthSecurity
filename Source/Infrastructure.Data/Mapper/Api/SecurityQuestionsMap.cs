using Domain.Entities.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;

/// <summary>
/// Configures the mapping between the SecurityQuestions entity and its corresponding database table.
/// </summary>
public class SecurityQuestionsMap
{
    private const string SecurityQuestionsTableName = "SecurityQuestions";

    /// <summary>
    /// Initializes a new instance of the <see cref="SecurityQuestionsMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">The entity builder for SecurityQuestions.</param>
    public SecurityQuestionsMap(EntityTypeBuilder<SecurityQuestions> entityBuilder)
    {
        SecurityQuestionsMapping(entityBuilder);
    }

    // Method to define the mapping between SecurityQuestions entity and database table
    private static void SecurityQuestionsMapping(EntityTypeBuilder<SecurityQuestions> entityBuilder)
    {
        if (entityBuilder == null) return;

        // Table name
        entityBuilder.ToTable(SecurityQuestionsTableName);

        // Primary Key
        entityBuilder.HasKey(t => t.Id);

        // Properties
        entityBuilder.Property(t => t.Question).IsRequired().HasMaxLength(255);

        // Index
        entityBuilder.HasIndex(t => t.Question).HasDatabaseName("IX_SEC_QUESTION").IsUnique();

        // Column mappings
        entityBuilder.Property(t => t.Id).HasColumnName("Id");
        entityBuilder.Property(t => t.IsDeleted).IsRequired().HasColumnName("IsDeleted");
        entityBuilder.Property(t => t.CreatedOn).IsRequired().HasColumnName("CreatedOn");
        entityBuilder.Property(t => t.CreatedBy).IsRequired().HasMaxLength(255).HasColumnName("CreatedBy");
        entityBuilder.Property(t => t.ModifiedBy).HasMaxLength(255).HasColumnName("ModifiedBy");
        entityBuilder.Property(t => t.ModifiedOn).HasColumnName("ModifiedOn");

        // Query filter for soft deletion
        entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);
    }
}
