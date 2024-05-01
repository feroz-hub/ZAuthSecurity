using Domain.Entities.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;

/// <summary>
/// Configures the mapping for the Users entity using Entity Framework Core's Fluent API.
/// </summary>
public class UsersMap
{
    private const string UsersTableName = "Users";

    /// <summary>
    /// Initializes a new instance of the <see cref="UsersMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">The EntityTypeBuilder instance for Users.</param>
    public UsersMap(EntityTypeBuilder<Users> entityBuilder)
    {
        UserMapping(entityBuilder);
    }

    /// <summary>
    /// Configures the mapping for the Users entity.
    /// </summary>
    /// <param name="entityBuilder">The EntityTypeBuilder instance for Users.</param>
    private static void UserMapping(EntityTypeBuilder<Users> entityBuilder)
    {
        if (entityBuilder == null) return;

        // Table name
        entityBuilder.ToTable(UsersTableName);

        // Primary Key
        entityBuilder.HasKey(t => t.Id);

        // Properties
        entityBuilder.Property(t => t.UserName).IsRequired().HasMaxLength(255);
        entityBuilder.Property(t => t.NormalizedUserName).IsRequired().HasMaxLength(255);
        entityBuilder.Property(t => t.FirstName).IsRequired().HasMaxLength(255);
        entityBuilder.Property(t => t.LastName).HasMaxLength(255);
        entityBuilder.Property(t => t.Email).IsRequired().HasMaxLength(255);
        entityBuilder.Property(t => t.NormalizedEmail).IsRequired().HasMaxLength(255);
        entityBuilder.Property(t => t.PhoneNumber).HasMaxLength(15);
        entityBuilder.Property(t => t.ConcurrencyStamp).HasMaxLength(255);
        entityBuilder.Property(t => t.SecurityStamp).HasMaxLength(255);

        // Column mappings
        entityBuilder.Property(t => t.Id).HasColumnName("Id");
        entityBuilder.Property(t => t.EmailConfirmed).IsRequired().HasColumnName("EmailConfirmed");
        entityBuilder.Property(t => t.PhoneNumberConfirmed).HasColumnName("PhoneNumberConfirmed");
        entityBuilder.Property(t => t.DateOfBirth).HasColumnName("DateOfBirth");
        entityBuilder.Property(t => t.PasswordHash).IsRequired().HasColumnName("PasswordHash");
        entityBuilder.Property(t => t.LastPasswordChangedDate).HasColumnName("LastPasswordChangedDate");
        entityBuilder.Property(t => t.RequiresDefaultPasswordChange).HasColumnName("RequiresDefaultPasswordChange");
        entityBuilder.Property(t => t.LastLoginDateTime).HasColumnName("LastLoginDateTime");
        entityBuilder.Property(t => t.LastLogoutDateTime).HasColumnName("LastLogoutDateTime");
        entityBuilder.Property(t => t.IdentityProviderType).HasColumnName("IdentityProviderType");
        entityBuilder.Property(t => t.IsDeleted).IsRequired().HasColumnName("IsDeleted");
        entityBuilder.Property(t => t.CreatedOn).IsRequired().HasColumnName("CreatedOn");
        entityBuilder.Property(t => t.CreatedBy).IsRequired().HasMaxLength(255).HasColumnName("CreatedBy");
        entityBuilder.Property(t => t.ModifiedOn).HasColumnName("ModifiedOn");
        entityBuilder.Property(t => t.ModifiedBy).HasMaxLength(255).HasColumnName("ModifiedBy");

        // Query filter for soft deletion
        entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);
    }
}
