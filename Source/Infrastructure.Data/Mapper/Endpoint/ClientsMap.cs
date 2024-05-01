using Domain.Entities.Endpoint;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Endpoint;


public class ClientsMap
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClientsMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">An EntityTypeBuilder object of type <see cref="Clients"/>.</param>
    public ClientsMap(EntityTypeBuilder<Clients> entityBuilder)
    {
        ClientsMapping(entityBuilder);
    }

    /// <summary>
    /// Defines the table name, columns, required fields and max length for Clients mapping.
    /// </summary>
    /// <param name="entityBuilder">An EntityTypeBuilder object of type <see cref="Clients"/>.</param>
    private void ClientsMapping(EntityTypeBuilder<Clients> entityBuilder)
    {
        if (entityBuilder != null)
        {
            entityBuilder.ToTable("SF_Clients");

            // Primary Key
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.HasIndex(x => new { x.ClientId, x.ClientSecret }).HasDatabaseName("IX_CLI_CLID_CLSEC")
                .IsUnique();

            // Properties
            entityBuilder.Property(x => x.ClientId).HasMaxLength(128).IsRequired();
            entityBuilder.Property(x => x.ClientName).HasMaxLength(255);
            entityBuilder.Property(x => x.ClientSecret).HasMaxLength(128);

            // Table & Column Mappings
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
            entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);
        }
    }
}
