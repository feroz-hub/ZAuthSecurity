using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;

/// <summary>
/// Configures the mapping between the UserLogins entity and its corresponding database table.
/// </summary>
public class UserLoginsMap
{
    private const string UserLoginsTableName = "UserLogins";

    /// <summary>
    /// Initializes a new instance of the <see cref="UserLoginsMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">The entity builder for UserLogins.</param>
    public UserLoginsMap(EntityTypeBuilder<UserLogins> entityBuilder)
    {
        UserLoginMapping(entityBuilder);
    }

    // Method to define the mapping between UserLogins entity and database table
    private static void UserLoginMapping(EntityTypeBuilder<UserLogins> entityBuilder)
    {
        if (entityBuilder == null) return;

        // Table name
        entityBuilder.ToTable(UserLoginsTableName);

        // Primary Key
        entityBuilder.HasKey(t => t.Id);
        entityBuilder.HasKey(l => new { l.LoginProvider, l.ProviderKey, l.UserId });

        // Properties
        entityBuilder.Property(t => t.LoginProvider).IsRequired().HasMaxLength(256);
        entityBuilder.Property(t => t.ProviderKey).IsRequired().HasMaxLength(256);

        // Column mappings
        entityBuilder.Property(t => t.UserId).IsRequired().HasColumnName("UserId");
        entityBuilder.Property(t => t.ProviderDisplayName).HasColumnName("ProviderDisplayName");
        entityBuilder.Property(t => t.IsDeleted).IsRequired().HasColumnName("IsDeleted");
        entityBuilder.Property(t => t.CreatedOn).IsRequired().HasColumnName("CreatedOn");
        entityBuilder.Property(t => t.CreatedBy).IsRequired().HasMaxLength(255).HasColumnName("CreatedBy");
        entityBuilder.Property(t => t.ModifiedOn).HasColumnName("ModifiedOn");
        entityBuilder.Property(t => t.ModifiedBy).HasMaxLength(255).HasColumnName("ModifiedBy");

        // Query filter for soft deletion
        entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);
    }
}
