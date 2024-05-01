using Domain.Entities.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;

/// <summary>
/// Configures the mapping between the UserClaims entity and its corresponding database table.
/// </summary>
public class UserClaimsMap
{
    private const string UserClaimsTableName = "UsersClaims";

    /// <summary>
    /// Initializes a new instance of the <see cref="UserClaimsMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">The entity builder for UserClaims.</param>
    public UserClaimsMap(EntityTypeBuilder<UserClaims> entityBuilder)
    {
        UserClaimMapping(entityBuilder);
    }

    // Method to define the mapping between UserClaims entity and database table
    private static void UserClaimMapping(EntityTypeBuilder<UserClaims> entityBuilder)
    {
        if (entityBuilder == null) return;

        // Table name
        entityBuilder.ToTable(UserClaimsTableName);

        // Primary Key
        entityBuilder.HasKey(t => t.Id);

        // Column mappings
        entityBuilder.Property(t => t.Id).HasColumnName("Id");
        entityBuilder.Property(t => t.UserId).IsRequired().HasColumnName("UserId");
        entityBuilder.Property(t => t.ClaimType).HasColumnName("ClaimType");
        entityBuilder.Property(t => t.ClaimValue).HasColumnName("ClaimValue");
        entityBuilder.Property(t => t.IsAdminClaim).HasColumnName("IsAdminClaim");
        entityBuilder.Property(t => t.IsDeleted).IsRequired().HasColumnName("IsDeleted");
        entityBuilder.Property(t => t.CreatedOn).IsRequired().HasColumnName("CreatedOn");
        entityBuilder.Property(t => t.CreatedBy).IsRequired().HasMaxLength(255).HasColumnName("CreatedBy");
        entityBuilder.Property(t => t.ModifiedOn).HasColumnName("ModifiedOn");
        entityBuilder.Property(t => t.ModifiedBy).HasMaxLength(255).HasColumnName("ModifiedBy");

        // Query filter for soft deletion
        entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);
    }
}
