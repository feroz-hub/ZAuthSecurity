using Domain.Entities.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;

/// <summary>
/// Configures the mapping between the PasswordHistory entity and its corresponding database table.
/// </summary>
public class PasswordHistoryMap
{
    private const string PasswordHistoryTableName = "PasswordHistory";

    /// <summary>
    /// Initializes a new instance of the <see cref="PasswordHistoryMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">The entity builder for PasswordHistory.</param>
    public PasswordHistoryMap(EntityTypeBuilder<PasswordHistory> entityBuilder)
    {
        PasswordHistoryMapping(entityBuilder);
    }

    // Method to define the mapping between PasswordHistory entity and database table
    private static void PasswordHistoryMapping(EntityTypeBuilder<PasswordHistory> entityBuilder)
    {
        if (entityBuilder == null) return;

        // Table name
        entityBuilder.ToTable(PasswordHistoryTableName);

        // Primary Key
        entityBuilder.HasKey(t => t.Id);

        // Properties
        entityBuilder.Property(t => t.Id).HasColumnName("Id");
        entityBuilder.Property(t => t.PasswordHash).IsRequired().HasMaxLength(255);
        entityBuilder.Property(t => t.UserId).IsRequired().HasColumnName("UserID");
        entityBuilder.Property(t => t.IsDeleted).IsRequired().HasColumnName("IsDeleted");
        entityBuilder.Property(t => t.ChangedOn).IsRequired().HasColumnName("ChangedOn");
        entityBuilder.Property(t => t.CreatedOn).IsRequired().HasColumnName("CreatedOn");
        entityBuilder.Property(t => t.CreatedBy).IsRequired().HasMaxLength(255).HasColumnName("CreatedBy");

        // Query filter for soft deletion
        entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);

        // Ignore properties
        entityBuilder.Ignore(x => x.ModifiedBy);
        entityBuilder.Ignore(x => x.ModifiedOn);
        entityBuilder.Ignore(x => x.RowVersion);
    }
}
