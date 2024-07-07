using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;

/// <summary>
/// Configures the mapping between the IdentityClaims entity and its corresponding database table.
/// </summary>
public class IdentityClaimsMap
{
    private const string IdentityClaimsTableName = "IdentityClaims";

    /// <summary>
    /// Initializes a new instance of the <see cref="IdentityClaimsMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">The entity builder for IdentityClaims.</param>
    public IdentityClaimsMap(EntityTypeBuilder<IdentityClaims> entityBuilder)
    {
        IdentityClaimsMapping(entityBuilder);
    }

    // Method to define the mapping between IdentityClaims entity and database table
    private static void IdentityClaimsMapping(EntityTypeBuilder<IdentityClaims> entityBuilder)
    {
        if (entityBuilder == null) return;

        // Table name
        entityBuilder.ToTable(IdentityClaimsTableName);

        // Primary Key
        entityBuilder.HasKey(x => x.Id);

        // Index
        entityBuilder.HasIndex(t => new { t.IdentityResourceId, t.Type })
            .HasDatabaseName("IX_IDRESCLM_IDRESID_TYPE").IsUnique();

        // Properties
        entityBuilder.Property(x => x.IdentityResourceId).IsRequired();
        entityBuilder.Property(x => x.Type).HasMaxLength(255).IsRequired();
        entityBuilder.Property(x => x.AliasType).HasMaxLength(255);

        // Column mappings
        entityBuilder.Property(x => x.IsDeleted).IsRequired().HasColumnName("IsDeleted");
        entityBuilder.Property(x => x.CreatedOn).IsRequired().HasColumnName("CreatedOn");
        entityBuilder.Property(x => x.CreatedBy).IsRequired().HasMaxLength(255).HasColumnName("CreatedBy");
        entityBuilder.Property(x => x.ModifiedOn).HasColumnName("ModifiedOn");
        entityBuilder.Property(x => x.ModifiedBy).HasMaxLength(255).HasColumnName("ModifiedBy");

        // Query filter for soft deletion
        entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);
    }
}
