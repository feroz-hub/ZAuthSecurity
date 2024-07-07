using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;

/// <summary>
/// Configures the mapping between the AuditTrail entity and its corresponding database table.
/// </summary>
public class AuditTrailMap
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AuditTrailMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">The entity builder for AuditTrail.</param>
    public AuditTrailMap(EntityTypeBuilder<AuditTrail> entityBuilder)
    {
        AuditMapping(entityBuilder);
    }

    private const string AuditTrailTableName = "AuditTrail";

    // Method to define the mapping between AuditTrail entity and database table
    private static void AuditMapping(EntityTypeBuilder<AuditTrail> entityBuilder)
    {
        if (entityBuilder == null) return;

        // Table name
        entityBuilder.ToTable(AuditTrailTableName);

        // Primary Key
        entityBuilder.HasKey(t => t.Id);

        // Properties
        entityBuilder.Property(t => t.ActionType).IsRequired().HasMaxLength(50);
        entityBuilder.Property(t => t.TableName).HasMaxLength(255);
        entityBuilder.Property(t => t.AffectedColumn);
        entityBuilder.Property(t => t.OldValue);
        entityBuilder.Property(t => t.NewValue);
        entityBuilder.Property(t => t.CreatedOn).IsRequired();
        entityBuilder.Property(t => t.CreatedBy).IsRequired().HasMaxLength(255);

        // Index
        entityBuilder.HasIndex(t => new { t.CreatedOn, t.CreatedBy, t.ActionType })
            .HasDatabaseName("IX_AUD_CRON_CBBY_ACTY");

        // Ignored properties
        entityBuilder.Ignore(x => x.IsDeleted);
        entityBuilder.Ignore(x => x.ModifiedBy);
        entityBuilder.Ignore(x => x.ModifiedOn);
        entityBuilder.Ignore(x => x.RowVersion);
    }
}
