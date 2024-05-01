using Domain.Entities.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;


/// <summary>
/// Configures the mapping between the ApiResources entity and its corresponding database table.
/// </summary>
public class ApiResourcesMap
{
    private const string ApiResourcesTableName = "ApiResources";

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiResourcesMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">The entity builder for ApiResources.</param>
    public ApiResourcesMap(EntityTypeBuilder<ApiResources> entityBuilder)
    {
        ApiResourcesMapping(entityBuilder);
    }

    // Method to define the mapping between ApiResources entity and database table
    private static void ApiResourcesMapping(EntityTypeBuilder<ApiResources> entityBuilder)
    {
        if (entityBuilder == null) return;

        // Table name
        entityBuilder.ToTable(ApiResourcesTableName);

        // Primary Key
        entityBuilder.HasKey(x => x.Id);

        // Index
        entityBuilder.HasIndex(t => t.Name).HasDatabaseName("IX_APIRES_NAME").IsUnique();

        // Properties
        entityBuilder.Property(x => x.Name).HasMaxLength(255).IsRequired();
        entityBuilder.Property(x => x.DisplayName).HasMaxLength(255);

        // Column mappings
        entityBuilder.Property(x => x.IsDeleted).IsRequired().HasColumnName("IsDeleted");
        entityBuilder.Property(x => x.CreatedOn).IsRequired().HasColumnName("CreatedOn");
        entityBuilder.Property(x => x.CreatedBy).IsRequired().HasMaxLength(255).HasColumnName("CreatedBy");
        entityBuilder.Property(x => x.ModifiedOn).HasColumnName("ModifiedOn");
        entityBuilder.Property(x => x.ModifiedBy).HasMaxLength(255).HasColumnName("ModifiedBy");

        // Relationships
        entityBuilder.HasMany(x => x.ApiResourceClaims).WithOne(x => x.ApiResources)
            .HasForeignKey(x => x.ApiResourceId).IsRequired().OnDelete(DeleteBehavior.Cascade);
        entityBuilder.HasMany(x => x.ApiScopes).WithOne(x => x.ApiResource)
            .HasForeignKey(x => x.ApiResourceId).IsRequired().OnDelete(DeleteBehavior.Cascade);

        // Query filter for soft deletion
        entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);
    }
}
