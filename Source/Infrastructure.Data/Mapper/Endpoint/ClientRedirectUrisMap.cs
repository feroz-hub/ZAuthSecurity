using Domain.Entities.Endpoint;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Endpoint;

/// <summary>
/// Configures the mapping for the ClientRedirectUris entity using Entity Framework Core's Fluent API.
/// </summary>
public class ClientRedirectUrisMap
{
    private const string ClientRedirectUrisTableName = "ClientRedirectUris";

    /// <summary>
    /// Initializes a new instance of the <see cref="ClientRedirectUrisMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">The EntityTypeBuilder instance for ClientRedirectUris.</param>
    public ClientRedirectUrisMap(EntityTypeBuilder<ClientRedirectUris> entityBuilder)
    {
        ClientRedirectUrisMapping(entityBuilder);
    }

    /// <summary>
    /// Configures the mapping for the ClientRedirectUris entity.
    /// </summary>
    /// <param name="entityBuilder">The EntityTypeBuilder instance for ClientRedirectUris.</param>
    private static void ClientRedirectUrisMapping(EntityTypeBuilder<ClientRedirectUris> entityBuilder)
    {
        if (entityBuilder == null) return;

        // Table name
        entityBuilder.ToTable(ClientRedirectUrisTableName);

        // Primary Key
        entityBuilder.HasKey(x => x.Id);
        entityBuilder.HasIndex(x => new { x.ClientId, x.RedirectUri }).IsUnique();

        // Properties
        entityBuilder.Property(x => x.RedirectUri).IsRequired().HasMaxLength(510).HasColumnName("RedirectUri");

        // Table & Column Mappings
        entityBuilder.Property(x => x.IsDeleted).IsRequired().HasColumnName("IsDeleted");
        entityBuilder.Property(x => x.CreatedOn).IsRequired().HasColumnName("CreatedOn");
        entityBuilder.Property(x => x.CreatedBy).IsRequired().HasMaxLength(255).HasColumnName("CreatedBy");
        entityBuilder.Property(x => x.ModifiedOn).HasColumnName("ModifiedOn");
        entityBuilder.Property(x => x.ModifiedBy).HasMaxLength(255).HasColumnName("ModifiedBy");

        // Query filter to handle soft deletes
        entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);
    }
}

