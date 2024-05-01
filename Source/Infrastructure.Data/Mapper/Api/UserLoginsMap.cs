using Domain.Entities.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;

public class UserLoginsMap
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserLoginsMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">An EntityTypeBuilder object of type <see cref="UserLogins"/>.</param>
    public UserLoginsMap(EntityTypeBuilder<UserLogins> entityBuilder)
    {
        UserLoginMapping(entityBuilder);
    }

    /// <summary>
    /// Defines the table name, columns, required fields and max length for UserLogins mapping.
    /// </summary>
    /// <param name="entityBuilder">An EntityTypeBuilder object of type <see cref="UserLogins"/>.</param>
    private void UserLoginMapping(EntityTypeBuilder<UserLogins> entityBuilder)
    {
        if (entityBuilder != null)
        {
            // Primary Key
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.HasKey(l => new { l.LoginProvider, l.ProviderKey, l.UserId });

            // Properties
            entityBuilder.Property(t => t.LoginProvider).IsRequired().HasMaxLength(256);
            entityBuilder.Property(t => t.ProviderKey).IsRequired().HasMaxLength(256);

            // Table & Column Mappings
            entityBuilder.ToTable("SF_UserLogins");
            entityBuilder.Property(t => t.UserId).IsRequired().HasColumnName("UserId");
            entityBuilder.Property(t => t.ProviderDisplayName).HasColumnName("ProviderDisplayName");
            entityBuilder.Property(t => t.IsDeleted).IsRequired().HasColumnName("IsDeleted");
            entityBuilder.Property(t => t.CreatedOn).IsRequired().HasColumnName("CreatedOn");
            entityBuilder.Property(t => t.CreatedBy).IsRequired().HasMaxLength(255).HasColumnName("CreatedBy");
            entityBuilder.Property(t => t.ModifiedOn).HasColumnName("ModifiedOn");
            entityBuilder.Property(t => t.ModifiedBy).HasMaxLength(255).HasColumnName("ModifiedBy");
            entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);
        }
    }
}