using Domain.Entities.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;
/// <summary>
/// Configures the mapping between the Roles entity and its corresponding database table.
/// </summary>
public class RolesMap
{
    private const string RolesTableName = "Roles";

    /// <summary>
    /// Initializes a new instance of the <see cref="RolesMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">The entity builder for Roles.</param>
    public RolesMap(EntityTypeBuilder<Roles> entityBuilder)
    {
        RolesMapping(entityBuilder);
    }

    // Method to define the mapping between Roles entity and database table
    private static void RolesMapping(EntityTypeBuilder<Roles> entityBuilder)
    {
        if (entityBuilder == null) return;

        // Table name
        entityBuilder.ToTable(RolesTableName);

        // Primary Key
        entityBuilder.HasKey(t => t.Id);

        // Properties
        entityBuilder.Property(t => t.Name).IsRequired().HasMaxLength(255);
        entityBuilder.Property(t => t.NormalizedName).IsRequired().HasMaxLength(255);
        entityBuilder.Property(t => t.ConcurrencyStamp).IsRequired().HasMaxLength(255);
        entityBuilder.Property(t => t.Description).HasColumnName("Description");

        // Column mappings
        entityBuilder.Property(t => t.Id).HasColumnName("Id");
        entityBuilder.Property(t => t.IsDeleted).IsRequired().HasColumnName("IsDeleted");
        entityBuilder.Property(t => t.CreatedOn).IsRequired().HasColumnName("CreatedOn");
        entityBuilder.Property(t => t.CreatedBy).IsRequired().HasMaxLength(255);
        entityBuilder.Property(t => t.ModifiedOn).HasColumnName("ModifiedOn");
        entityBuilder.Property(t => t.ModifiedBy).HasMaxLength(255).HasColumnName("ModifiedBy");

        // Query filter for soft deletion
        entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);
    }
}
