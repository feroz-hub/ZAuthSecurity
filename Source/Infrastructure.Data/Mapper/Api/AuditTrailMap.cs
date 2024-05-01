using Domain.Entities.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;

public class AuditTrailMap
{
    public AuditTrailMap(EntityTypeBuilder<AuditTrail> entityBuilder)
    {
        AuditMapping(entityBuilder);
    }

    private const string AuditTrailTableName = "AuditTrail";
    private static void AuditMapping(EntityTypeBuilder<AuditTrail> entityBuilder)
    {
        if (entityBuilder == null) return;

        entityBuilder.ToTable(AuditTrailTableName);
        entityBuilder.HasKey(t => t.Id);
        entityBuilder.Property(t => t.ActionType).IsRequired().HasMaxLength(50);
        entityBuilder.Property(t => t.TableName).HasMaxLength(255);
        entityBuilder.Property(t => t.AffectedColumn);
        entityBuilder.Property(t => t.OldValue);
        entityBuilder.Property(t => t.NewValue);
        entityBuilder.Property(t => t.CreatedOn).IsRequired();
        entityBuilder.Property(t => t.CreatedBy).IsRequired().HasMaxLength(255);

        entityBuilder.HasIndex(t => new { t.CreatedOn, t.CreatedBy, t.ActionType })
            .HasDatabaseName("IX_AUD_CRON_CBBY_ACTY");
        
        entityBuilder.Ignore(x => x.IsDeleted);
        entityBuilder.Ignore(x => x.ModifiedBy);
        entityBuilder.Ignore(x => x.ModifiedOn);
        entityBuilder.Ignore(x => x.RowVersion);
    }

}
