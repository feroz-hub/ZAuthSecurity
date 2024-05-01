using Domain.Entities.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;

/// <summary>
/// Configures the mapping between the ApiResourceClaims entity and its corresponding database table.
/// </summary>
public class ApiResourceClaimsMap
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ApiResourceClaimsMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">The entity builder for ApiResourceClaims.</param>
    public ApiResourceClaimsMap(EntityTypeBuilder<ApiResourceClaims> entityBuilder)
    {
        ApiClaimsMapping(entityBuilder);
    }

    private const string ApiResourceClaimsTableName = "ApiResourceClaims";

    // Method to define the mapping between ApiResourceClaims entity and database table
    private static void ApiClaimsMapping(EntityTypeBuilder<ApiResourceClaims> entityBuilder)
    {
        if (entityBuilder == null) return;

        // Table name
        entityBuilder.ToTable(ApiResourceClaimsTableName);

        // Primary Key
        entityBuilder.HasKey(x => x.Id);

        // Unique index
        entityBuilder.HasIndex(t => new { t.ApiResourceId, t.Type }).HasDatabaseName("IX_APIRES_CLM_RESID_TYPE").IsUnique();

        // Properties
        entityBuilder.Property(x => x.Type).HasMaxLength(255).IsRequired();
        entityBuilder.Property(x => x.ApiResourceId).IsRequired().HasColumnOrder(2);

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
