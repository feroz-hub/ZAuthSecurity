using Domain.Entities.Endpoint;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Endpoint;
/// <summary>
/// Configures the mapping for the Clients entity using Entity Framework Core's Fluent API.
/// </summary>
public class ClientsMap
{
    private const string ClientsTableName = "Clients";

    /// <summary>
    /// Initializes a new instance of the <see cref="ClientsMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">The EntityTypeBuilder instance for Clients.</param>
    public ClientsMap(EntityTypeBuilder<Clients> entityBuilder)
    {
        ClientsMapping(entityBuilder);
    }

    /// <summary>
    /// Configures the mapping for the Clients entity.
    /// </summary>
    /// <param name="entityBuilder">The EntityTypeBuilder instance for Clients.</param>
    private static void ClientsMapping(EntityTypeBuilder<Clients> entityBuilder)
    {
        if (entityBuilder == null) return;

        // Table name
        entityBuilder.ToTable(ClientsTableName);

        // Primary Key
        entityBuilder.HasKey(x => x.Id);
        entityBuilder.HasIndex(x => new { x.ClientId, x.ClientSecret }).HasDatabaseName("IX_CLI_CLID_CLSEC")
            .IsUnique();

        // Properties
        entityBuilder.Property(x => x.ClientId).HasMaxLength(128).IsRequired();
        entityBuilder.Property(x => x.ClientName).HasMaxLength(255);
        entityBuilder.Property(x => x.ClientSecret).HasMaxLength(128);

        // Column Mappings
        entityBuilder.Property(x => x.IsDeleted).IsRequired().HasColumnName("IsDeleted");
        entityBuilder.Property(x => x.CreatedOn).IsRequired().HasColumnName("CreatedOn");
        entityBuilder.Property(x => x.CreatedBy).IsRequired().HasMaxLength(255).HasColumnName("CreatedBy");
        entityBuilder.Property(x => x.ModifiedOn).HasColumnName("ModifiedOn");
        entityBuilder.Property(x => x.ModifiedBy).HasMaxLength(255).HasColumnName("ModifiedBy");

        // Mappings
        entityBuilder.HasMany(x => x.RedirectUris).WithOne(x => x.Client)
            .HasForeignKey(x => x.ClientId).IsRequired().OnDelete(DeleteBehavior.Cascade);
        entityBuilder.HasMany(x => x.PostLogoutRedirectUris).WithOne(x => x.Client)
            .HasForeignKey(x => x.ClientId).IsRequired().OnDelete(DeleteBehavior.Cascade);

        // Query filter to handle soft deletes
        entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);
    }
}

