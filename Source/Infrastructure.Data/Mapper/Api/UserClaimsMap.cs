using Domain.Entities.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;

/// <summary>
    /// Mapper class to create UserClaims table using Entity Framework code first approach.
    /// </summary>
    public class UserClaimsMap
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserClaimsMap"/> class.
        /// </summary>
        /// <param name="entityBuilder">An EntityTypeBuilder object of type <see cref="UserClaims"/>.</param>
        public UserClaimsMap(EntityTypeBuilder<UserClaims> entityBuilder)
        {
            UserClaimMapping(entityBuilder);
        }

        /// <summary>
        /// Defines the table name, columns, required fields and max length for UserClaims mapping.
        /// </summary>
        /// <param name="entityBuilder">An EntityTypeBuilder object of type <see cref="UserClaims"/>.</param>
        private void UserClaimMapping(EntityTypeBuilder<UserClaims> entityBuilder)
        {
            if (entityBuilder != null)
            {
                // Primary Key
                entityBuilder.HasKey(t => t.Id);

                // Table & Column Mappings
                entityBuilder.ToTable("SF_UserClaims");
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
                entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);
            }
        }
    }