using Domain.Entities.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;

public class SecurityQuestionsMap
{
    
    /// <summary>
    /// Initializes a new instance of the <see cref="SecurityQuestionsMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">An EntityTypeBuilder object of type <see cref="SecurityQuestions"/>.</param>
    public SecurityQuestionsMap(EntityTypeBuilder<SecurityQuestions> entityBuilder)
    {
        SecurityQuestionsMapping(entityBuilder);
    }

    /// <summary>
    /// Defines the table name, columns, required fields and max length for SecurityQuestions mapping.
    /// </summary>
    /// <param name="entityBuilder">An EntityTypeBuilder object of type <see cref="SecurityQuestions"/>.</param>
    private void SecurityQuestionsMapping(EntityTypeBuilder<SecurityQuestions> entityBuilder)
    {
        if (entityBuilder != null)
        {
            // Primary Key
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.HasIndex(t => t.Question).HasDatabaseName("IX_SEC_QUESTION").IsUnique();

            // Properties
            entityBuilder.Property(t => t.Question).IsRequired().HasMaxLength(255);

            // Table & Column Mappings
            entityBuilder.ToTable("SF_SecurityQuestions");
            entityBuilder.Property(t => t.Id).HasColumnName("Id");
            entityBuilder.Property(t => t.IsDeleted).IsRequired().HasColumnName("IsDeleted");
            entityBuilder.Property(t => t.CreatedOn).IsRequired().HasColumnName("CreatedOn");
            entityBuilder.Property(t => t.CreatedBy).IsRequired().HasMaxLength(255).HasColumnName("CreatedBy");
            entityBuilder.Property(t => t.ModifiedBy).HasMaxLength(255).HasColumnName("ModifiedBy");
            entityBuilder.Property(t => t.ModifiedOn).HasColumnName("ModifiedOn");
            entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);
        }
    }
}