using Domain.Entities.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;

public class ApiResourceClaimsMap
{ 
    public ApiResourceClaimsMap(EntityTypeBuilder<ApiResourceClaims> entityBuilder)
    {
        ApiClaimsMapping(entityBuilder);
    }

   
    private void ApiClaimsMapping(EntityTypeBuilder<ApiResourceClaims> entityBuilder)
    {
        if (entityBuilder == null) return;
        entityBuilder.ToTable("SF_ApiResourceClaims");

        // Primary Key
        entityBuilder.HasKey(x => x.Id);
        entityBuilder.HasIndex(t => new { t.ApiResourceId, t.Type }).HasDatabaseName("IX_APIRES_CLM_RESID_TYPE").IsUnique();

        // Properties
        entityBuilder.Property(x => x.Type).HasMaxLength(255).IsRequired();
        entityBuilder.Property(x => x.ApiResourceId).IsRequired();

        // Table & Column Mappings
        entityBuilder.Property(x => x.IsDeleted).IsRequired().HasColumnName("IsDeleted");
        entityBuilder.Property(x => x.CreatedOn).IsRequired().HasColumnName("CreatedOn");
        entityBuilder.Property(x => x.CreatedBy).IsRequired().HasMaxLength(255).HasColumnName("CreatedBy");
        entityBuilder.Property(x => x.ModifiedOn).HasColumnName("ModifiedOn");
        entityBuilder.Property(x => x.ModifiedBy).HasMaxLength(255).HasColumnName("ModifiedBy");
        entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);
    }
}