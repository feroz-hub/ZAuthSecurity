using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;


/// <summary>
/// Configures the mapping between the IdentityResources entity and its corresponding database table.
/// </summary>
public class IdentityResourcesMap
{
    private const string IdentityResourcesTableName = "IdentityResources";

    /// <summary>
    /// Initializes a new instance of the <see cref="IdentityResourcesMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">The entity builder for IdentityResources.</param>
    public IdentityResourcesMap(EntityTypeBuilder<IdentityResources> entityBuilder)
    {
        IdentityResourcesMapping(entityBuilder);
    }

    // Method to define the mapping between IdentityResources entity and database table
    private static void IdentityResourcesMapping(EntityTypeBuilder<IdentityResources> entityBuilder)
    {
        if (entityBuilder == null) return;

        // Table name
        entityBuilder.ToTable(IdentityResourcesTableName);

        // Primary Key
        entityBuilder.HasKey(x => x.Id);

        // Index
        entityBuilder.HasIndex(t => t.Name).HasDatabaseName("IX_IDRES_NAME").IsUnique();

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
        entityBuilder.HasMany(x => x.IdentityClaims).WithOne(x => x.IdentityResource)
            .HasForeignKey(x => x.IdentityResourceId).IsRequired().OnDelete(DeleteBehavior.Cascade);

        // Query filter for soft deletion
        entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);
    }
}
