using Domain.Entities.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;

public class PasswordHistoryMap
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PasswordHistoryMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">An EntityTypeBuilder object of type <see cref="PasswordHistory"/>.</param>
    public PasswordHistoryMap(EntityTypeBuilder<PasswordHistory> entityBuilder)
    {
        PasswordHistoryMapping(entityBuilder);
    }

    /// <summary>
    /// Defines the table name, columns, required fields and max length for PasswordHistory mapping.
    /// </summary>
    /// <param name="entityBuilder">An EntityTypeBuilder object of type <see cref="PasswordHistory"/>.</param>
    private void PasswordHistoryMapping(EntityTypeBuilder<PasswordHistory> entityBuilder)
    {
        if (entityBuilder == null) return;
        entityBuilder.ToTable("SF_PasswordHistory");

        // Primary Key
        entityBuilder.HasKey(t => t.Id);

        // Properties
        entityBuilder.Property(t => t.Id).HasColumnName("Id");
        entityBuilder.Property(t => t.PasswordHash).IsRequired().HasMaxLength(255);
        entityBuilder.Property(t => t.UserId).IsRequired().HasColumnName("UserID");
        entityBuilder.Property(t => t.IsDeleted).IsRequired().HasColumnName("IsDeleted");
        entityBuilder.Property(t => t.ChangedOn).IsRequired().HasColumnName("ChangedOn");
        entityBuilder.Property(t => t.CreatedOn).IsRequired().HasColumnName("CreatedOn");
        entityBuilder.Property(t => t.CreatedBy).IsRequired().HasMaxLength(255).HasColumnName("CreatedBy");
        entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);

        entityBuilder.Ignore(x => x.ModifiedBy);
        entityBuilder.Ignore(x => x.ModifiedOn);
        entityBuilder.Ignore(x => x.RowVersion);
    }
}