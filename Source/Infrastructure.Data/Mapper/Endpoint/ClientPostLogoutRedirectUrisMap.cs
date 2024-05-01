using Domain.Entities.Endpoint;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Endpoint;

public class ClientPostLogoutRedirectUrisMap
{
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientPostLogoutRedirectUrisMap"/> class.
        /// </summary>
        /// <param name="entityBuilder">An EntityTypeBuilder object of type <see cref="ClientPostLogoutRedirectUris"/>.</param>
        public ClientPostLogoutRedirectUrisMap(EntityTypeBuilder<ClientPostLogoutRedirectUris> entityBuilder)
        {
            ClientPostLogoutRedirectUrisMapping(entityBuilder);
        }

        /// <summary>
        /// Defines the table name, columns, required fields and max length for ClientPostLogoutRedirectUris mapping.
        /// </summary>
        /// <param name="entityBuilder">An EntityTypeBuilder object of type <see cref="ClientPostLogoutRedirectUris"/>.</param>
        private void ClientPostLogoutRedirectUrisMapping(EntityTypeBuilder<ClientPostLogoutRedirectUris> entityBuilder)
        {
            if (entityBuilder != null)
            {
                entityBuilder.ToTable("SF_ClientPostLogoutRedirectUris");

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
                entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);
            }
        }
}