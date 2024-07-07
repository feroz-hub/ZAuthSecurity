using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;

/// <summary>
/// Configures the mapping between the UserRoles entity and its corresponding database table.
/// </summary>
public class UserRolesMap
{
    private const string UserRolesTableName = "UserRoles";

    /// <summary>
    /// Initializes a new instance of the <see cref="UserRolesMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">The entity builder for UserRoles.</param>
    public UserRolesMap(EntityTypeBuilder<UserRoles> entityBuilder)
    {
        UserRoleMapping(entityBuilder);
    }

    // Method to define the mapping between UserRoles entity and database table
    private static void UserRoleMapping(EntityTypeBuilder<UserRoles> entityBuilder)
    {
        if (entityBuilder == null) return;

        // Table name
        entityBuilder.ToTable(UserRolesTableName);

        // Primary Key
        entityBuilder.HasKey(r => new { r.Id, r.UserId, r.RoleId });

        // Properties

        // Column mappings
        entityBuilder.Property(t => t.Id).HasColumnName("Id");
        entityBuilder.Property(t => t.IsDeleted).IsRequired().HasColumnName("IsDeleted");
        entityBuilder.Property(t => t.CreatedOn).IsRequired().HasColumnName("CreatedOn");
        entityBuilder.Property(t => t.CreatedBy).IsRequired().HasMaxLength(255).HasColumnName("CreatedBy");
        entityBuilder.Property(t => t.ModifiedOn).HasColumnName("ModifiedOn");
        entityBuilder.Property(t => t.ModifiedBy).HasMaxLength(255).HasColumnName("ModifiedBy");

        // Query filter for soft deletion
        entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);
    }
}
