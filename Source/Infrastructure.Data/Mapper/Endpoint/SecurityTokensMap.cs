using Domain.Entities.Endpoint;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Endpoint;

public class SecurityTokensMap
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SecurityTokensMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">An EntityTypeBuilder object of type <see cref="SecurityTokens"/>.</param>
    public SecurityTokensMap(EntityTypeBuilder<SecurityTokens> entityBuilder)
    {
        SecurityTokensMapping(entityBuilder);
    }

    /// <summary>
    /// Defines the table name, columns, required fields and max length for SecurityTokens mapping.
    /// </summary>
    /// <param name="entityBuilder">An EntityTypeBuilder object of type <see cref="SecurityTokens"/>.</param>
    private void SecurityTokensMapping(EntityTypeBuilder<SecurityTokens> entityBuilder)
    {
        if (entityBuilder != null)
        {
            entityBuilder.ToTable("SF_SecurityTokens");

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
            entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);

            entityBuilder.Ignore(x => x.RowVersion);
        }
    }
}