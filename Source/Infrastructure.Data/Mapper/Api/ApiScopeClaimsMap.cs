using Domain.Entities.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;

/// <summary>
/// Configures the mapping between the ApiScopeClaims entity and its corresponding database table.
/// </summary>
public class ApiScopeClaimsMap
{
    private const string ApiScopeClaimsTableName = "ApiScopeClaims";

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiScopeClaimsMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">The entity builder for ApiScopeClaims.</param>
    public ApiScopeClaimsMap(EntityTypeBuilder<ApiScopeClaims> entityBuilder)
    {
        ApiScopeClaimsMapping(entityBuilder);
    }

    // Method to define the mapping between ApiScopeClaims entity and database table
    private static void ApiScopeClaimsMapping(EntityTypeBuilder<ApiScopeClaims> entityBuilder)
    {
        if (entityBuilder == null) return;

        // Table name
        entityBuilder.ToTable(ApiScopeClaimsTableName);

        // Primary Key
        entityBuilder.HasKey(x => x.Id);

        // Index
        entityBuilder.HasIndex(t => new { t.ApiScopeId, t.Type }).HasDatabaseName("IX_APISCO_CLM_SCOID_TYPE")
            .IsUnique();

        // Properties
        entityBuilder.Property(x => x.ApiScopeId).IsRequired();
        entityBuilder.Property(x => x.Type).HasMaxLength(255).IsRequired();

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
