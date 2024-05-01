using Domain.Entities.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;

public class UserRolesMap
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserRolesMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">An EntityTypeBuilder object of type <see cref="UserRoles"/>.</param>
    public UserRolesMap(EntityTypeBuilder<UserRoles> entityBuilder)
    {
        UserRoleMapping(entityBuilder);
    }

    /// <summary>
    /// Defines the table name, columns, required fields and max length for UserRoles mapping.
    /// </summary>
    /// <param name="entityBuilder">An EntityTypeBuilder object of type <see cref="UserRoles"/>.</param>
    private void UserRoleMapping(EntityTypeBuilder<UserRoles> entityBuilder)
    {
        if (entityBuilder != null)
        {
            // Primary Key
            entityBuilder.HasKey(r => new { r.Id, r.UserId, r.RoleId });

            // Properties
            // Table & Column Mappings
            entityBuilder.ToTable("SF_UserRoles");
            entityBuilder.Property(t => t.Id).HasColumnName("Id");
            entityBuilder.Property(t => t.IsDeleted).IsRequired().HasColumnName("IsDeleted");
            entityBuilder.Property(t => t.CreatedOn).IsRequired().HasColumnName("CreatedOn");
            entityBuilder.Property(t => t.CreatedBy).IsRequired().HasMaxLength(255).HasColumnName("CreatedBy");
            entityBuilder.Property(t => t.ModifiedOn).HasColumnName("ModifiedOn");
            entityBuilder.Property(t => t.ModifiedBy).HasMaxLength(255).HasColumnName("ModifiedBy");
            entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);
        }
    }
}