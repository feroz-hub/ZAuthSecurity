using Domain.Entities.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;
 public class RolesMap
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RolesMap"/> class.
        /// </summary>
        /// <param name="entityBuilder">An EntityTypeBuilder object of type <see cref="Roles"/>.</param>
        public RolesMap(EntityTypeBuilder<Roles> entityBuilder)
        {
            RolesMapping(entityBuilder);
        }

        /// <summary>
        /// Defines the table name, columns, required fields and max length for Roles mapping.
        /// </summary>
        /// <param name="entityBuilder">An EntityTypeBuilder object of type <see cref="Roles"/>.</param>
        private void RolesMapping(EntityTypeBuilder<Roles> entityBuilder)
        {
            if (entityBuilder != null)
            {
                // Primary Key
                entityBuilder.HasKey(t => t.Id);

                // Properties
                entityBuilder.Property(t => t.Name).IsRequired().HasMaxLength(255);
                entityBuilder.Property(t => t.NormalizedName).IsRequired().HasMaxLength(255);
                entityBuilder.Property(t => t.ConcurrencyStamp).IsRequired().HasMaxLength(255);

                // Table & Column Mappings
                entityBuilder.ToTable("SF_Roles");
                entityBuilder.Property(t => t.Id).HasColumnName("Id");
                entityBuilder.Property(t => t.Description).HasColumnName("Description");
                entityBuilder.Property(t => t.IsDeleted).IsRequired().HasColumnName("IsDeleted");
                entityBuilder.Property(t => t.CreatedOn).IsRequired().HasColumnName("CreatedOn");
                entityBuilder.Property(t => t.CreatedBy).IsRequired().HasMaxLength(255);
                entityBuilder.Property(t => t.ModifiedOn).HasColumnName("ModifiedOn");
                entityBuilder.Property(t => t.ModifiedBy).HasMaxLength(255).HasColumnName("ModifiedBy");
                entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);
            }
        }
    }