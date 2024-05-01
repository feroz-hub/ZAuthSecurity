using Domain.Entities.Endpoint;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Endpoint;

/// <summary>
/// Configures the mapping for the ClientPostLogoutRedirectUris entity using Entity Framework Core's Fluent API.
/// </summary>
public class ClientPostLogoutRedirectUrisMap
{
    private const string ClientPostLogoutRedirectUrisTableName = "ClientPostLogoutRedirectUris";

    /// <summary>
    /// Initializes a new instance of the <see cref="ClientPostLogoutRedirectUrisMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">The EntityTypeBuilder instance for ClientPostLogoutRedirectUris.</param>
    public ClientPostLogoutRedirectUrisMap(EntityTypeBuilder<ClientPostLogoutRedirectUris> entityBuilder)
    {
        ClientPostLogoutRedirectUrisMapping(entityBuilder);
    }

    /// <summary>
    /// Configures the mapping for the ClientPostLogoutRedirectUris entity.
    /// </summary>
    /// <param name="entityBuilder">The EntityTypeBuilder instance for ClientPostLogoutRedirectUris.</param>
    private static void ClientPostLogoutRedirectUrisMapping(EntityTypeBuilder<ClientPostLogoutRedirectUris> entityBuilder)
    {
        if (entityBuilder == null) return;

        // Table name
        entityBuilder.ToTable(ClientPostLogoutRedirectUrisTableName);

        // Primary Key
        entityBuilder.HasKey(x => x.Id);
        entityBuilder.HasIndex(x => new { x.ClientId, x.PostLogoutRedirectUri }).IsUnique();

        // Properties
        entityBuilder.Property(x => x.PostLogoutRedirectUri).IsRequired().HasMaxLength(510).HasColumnName("PostLogoutRedirectUri");

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

