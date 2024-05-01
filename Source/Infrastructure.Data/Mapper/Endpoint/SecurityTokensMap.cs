using Domain.Entities.Endpoint;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Endpoint;

/// <summary>
/// Configures the mapping for the SecurityTokens entity using Entity Framework Core's Fluent API.
/// </summary>
public class SecurityTokensMap
{
    private const string SecurityTokensTableName = "SecurityTokens";

    /// <summary>
    /// Initializes a new instance of the <see cref="SecurityTokensMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">The entity builder for SecurityTokens.</param>
    public SecurityTokensMap(EntityTypeBuilder<SecurityTokens> entityBuilder)
    {
        SecurityTokensMapping(entityBuilder);
    }

    /// <summary>
    /// Defines the mapping configuration for the SecurityTokens entity.
    /// </summary>
    /// <param name="entityBuilder">The entity builder for SecurityTokens.</param>
    private static void SecurityTokensMapping(EntityTypeBuilder<SecurityTokens> entityBuilder)
    {
        if (entityBuilder == null) return;

        // Table name
        entityBuilder.ToTable(SecurityTokensTableName);

        // Primary Key
        entityBuilder.HasKey(x => x.Id);

        // Table & Column Mappings
        entityBuilder.Property(x => x.ConsumedTime).HasColumnName("ConsumedTime");
        entityBuilder.Property(x => x.CreationTime).HasColumnName("CreationTime");
        entityBuilder.Property(x => x.ExpiresAt).HasColumnName("ExpiresAt");
        entityBuilder.Property(x => x.IsDeleted).IsRequired().HasColumnName("IsDeleted");
        entityBuilder.Property(x => x.CreatedOn).IsRequired().HasColumnName("CreatedOn");
        entityBuilder.Property(x => x.CreatedBy).IsRequired().HasMaxLength(255).HasColumnName("CreatedBy");
        entityBuilder.Property(x => x.ModifiedOn).HasColumnName("ModifiedOn");
        entityBuilder.Property(x => x.ModifiedBy).HasMaxLength(255).HasColumnName("ModifiedBy");

        // Query filter for soft deletion
        entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);

        // Ignore property
        entityBuilder.Ignore(x => x.RowVersion);
    }
}
