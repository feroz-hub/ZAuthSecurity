using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;

/// <summary>
/// Configures the mapping between the RoleClaims entity and its corresponding database table.
/// </summary>
public class RoleClaimsMap
{
    private const string RoleClaimsTableName = "RoleClaims";

    /// <summary>
    /// Initializes a new instance of the <see cref="RoleClaimsMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">The entity builder for RoleClaims.</param>
    public RoleClaimsMap(EntityTypeBuilder<RoleClaims> entityBuilder)
    {
        RoleClaimsMapping(entityBuilder);
    }

    // Method to define the mapping between RoleClaims entity and database table
    private static void RoleClaimsMapping(EntityTypeBuilder<RoleClaims> entityBuilder)
    {
        if (entityBuilder == null) return;

        // Table name
        entityBuilder.ToTable(RoleClaimsTableName);

        // Primary Key
        entityBuilder.HasKey(t => t.Id);

        // Column mappings
        entityBuilder.Property(t => t.Id).HasColumnName("Id");
        entityBuilder.Property(t => t.RoleId).IsRequired().HasColumnName("RoleId");
        entityBuilder.Property(t => t.IsDeleted).IsRequired().HasColumnName("IsDeleted");
        entityBuilder.Property(t => t.CreatedOn).IsRequired().HasColumnName("CreatedOn");
        entityBuilder.Property(t => t.CreatedBy).IsRequired().HasMaxLength(255).HasColumnName("CreatedBy");
        entityBuilder.Property(t => t.ModifiedOn).HasColumnName("ModifiedOn");
        entityBuilder.Property(t => t.ModifiedBy).HasMaxLength(255).HasColumnName("ModifiedBy");

        // Query filter for soft deletion
        entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);
    }
}
