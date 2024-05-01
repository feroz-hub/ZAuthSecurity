using Domain.Entities.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;

/// <summary>
/// Configures the mapping for the UserTokens entity using Entity Framework Core's Fluent API.
/// </summary>
public class UserTokensMap
{
    private const string UserTokenTableName = "UserTokens";

    /// <summary>
    /// Initializes a new instance of the <see cref="UserTokensMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">The EntityTypeBuilder instance for UserTokens.</param>
    public UserTokensMap(EntityTypeBuilder<UserTokens> entityBuilder)
    {
        UserTokenMapping(entityBuilder);
    }

    /// <summary>
    /// Configures the mapping for the UserTokens entity.
    /// </summary>
    /// <param name="entityBuilder">The EntityTypeBuilder instance for UserTokens.</param>
    private static void UserTokenMapping(EntityTypeBuilder<UserTokens> entityBuilder)
    {
        if (entityBuilder == null) return;

        // Primary Key
        entityBuilder.HasKey(t => new { t.UserId, t.LoginProvider, t.Name });

        // Properties
        entityBuilder.Property(t => t.LoginProvider).IsRequired().HasMaxLength(255);
        entityBuilder.Property(t => t.Name).IsRequired().HasMaxLength(255);

        // Table & Column Mappings
        entityBuilder.ToTable(UserTokenTableName);
        entityBuilder.Property(t => t.UserId).IsRequired().HasColumnName("UserId");
        entityBuilder.Property(t => t.Value).IsRequired().HasColumnName("Value");
    }
}

