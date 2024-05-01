using Domain.Entities.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;

public class UserTokensMap
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserTokensMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">An EntityTypeBuilder object of type <see cref="UserTokens"/>.</param>
    public UserTokensMap(EntityTypeBuilder<UserTokens> entityBuilder)
    {
        UserTokenMapping(entityBuilder);
    }

    /// <summary>
    /// Defines the table name, columns, required fields and max length for UserTokens mapping.
    /// </summary>
    /// <param name="entityBuilder">An EntityTypeBuilder object of type <see cref="UserTokens"/>.</param>
    private void UserTokenMapping(EntityTypeBuilder<UserTokens> entityBuilder)
    {
        if (entityBuilder == null) return;
        // Primary Key
        entityBuilder.HasKey(t => new {t.UserId, t.LoginProvider, t.Name});

        // Properties
        entityBuilder.Property(t => t.LoginProvider).IsRequired().HasMaxLength(255);
        entityBuilder.Property(t => t.Name).IsRequired().HasMaxLength(255);

        // Table & Column Mappings
        entityBuilder.ToTable("SF_UserTokens");
        entityBuilder.Property(t => t.UserId).IsRequired().HasColumnName("UserId");
        entityBuilder.Property(t => t.Value).IsRequired().HasColumnName("Value");
    }
}