using Domain.Entities.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;

/// <summary>
/// Configures the mapping between the ApiScopes entity and its corresponding database table.
/// </summary>
public class ApiScopesMap
{
    private const string ApiScopesTableName = "ApiScopes";

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiScopesMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">The entity builder for ApiScopes.</param>
    public ApiScopesMap(EntityTypeBuilder<ApiScopes> entityBuilder)
    {
        ApiScopesMapping(entityBuilder);
    }

    // Method to define the mapping between ApiScopes entity and database table
    private static void ApiScopesMapping(EntityTypeBuilder<ApiScopes> entityBuilder)
    {
        if (entityBuilder == null) return;

        // Table name
        entityBuilder.ToTable(ApiScopesTableName);

        // Primary Key
        entityBuilder.HasKey(x => x.Id);

        // Index
        entityBuilder.HasIndex(t => new { t.ApiResourceId, t.Name }).HasDatabaseName("IX_APISCO_SCOID_NAME")
            .IsUnique();

        // Properties
        entityBuilder.Property(x => x.ApiResourceId).IsRequired().HasColumnOrder(2);
        entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(255).HasColumnName("Name");
        entityBuilder.Property(x => x.DisplayName).HasMaxLength(255).HasColumnName("DisplayName");
        entityBuilder.Property(x => x.IsDeleted).IsRequired().HasColumnName("IsDeleted");
        entityBuilder.Property(x => x.CreatedOn).IsRequired().HasColumnName("CreatedOn");
        entityBuilder.Property(x => x.CreatedBy).IsRequired().HasMaxLength(255).HasColumnName("CreatedBy");
        entityBuilder.Property(x => x.ModifiedOn).HasColumnName("ModifiedOn");
        entityBuilder.Property(x => x.ModifiedBy).HasMaxLength(255).HasColumnName("ModifiedBy");

        // Relationships
        entityBuilder.HasMany(x => x.ApiScopeClaims).WithOne(x => x.ApiScope)
            .HasForeignKey(x => x.ApiScopeId).IsRequired().OnDelete(DeleteBehavior.Cascade);

        // Query filter for soft deletion
        entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);
    }
}
