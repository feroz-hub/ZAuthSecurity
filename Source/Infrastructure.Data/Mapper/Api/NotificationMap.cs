using Domain.Entities.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;

/// <summary>
/// Mapper class to create Notification table using Entity Framework code first approach.
/// </summary>
public class NotificationMap
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NotificationMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">An EntityTypeBuilder of type <see cref="Notification"/> object.</param>
    public NotificationMap(EntityTypeBuilder<Notification> entityBuilder)
    {
        NotificationMapping(entityBuilder);
    }

    /// <summary>
    /// Defines the table name, columns, required fields and max length for Notification mapping.
    /// </summary>
    /// <param name="entityBuilder">An EntityTypeBuilder object of type <see cref="Notification"/>.</param>
    private void NotificationMapping(EntityTypeBuilder<Notification> entityBuilder)
    {
        if (entityBuilder == null) return;
        // Primary Key
        entityBuilder.HasKey(t => t.Id);
        entityBuilder.HasIndex(t => t.Type).HasDatabaseName("IX_NOTI_TYPE");

        // Properties
        entityBuilder.Property(t => t.UserId).IsRequired();
        entityBuilder.Property(t => t.Type).IsRequired();
        entityBuilder.Property(t => t.Activity).HasMaxLength(255);
        entityBuilder.Property(t => t.Status).HasMaxLength(255);
        entityBuilder.Property(t => t.Sender).IsRequired().HasMaxLength(255);
        entityBuilder.Property(t => t.Recipient).IsRequired().HasMaxLength(255);
        entityBuilder.Property(t => t.MessageId).IsRequired().HasMaxLength(255);

        // Table & Column Mappings
        entityBuilder.ToTable("SF_Notification");
        entityBuilder.Property(t => t.Id).HasColumnName("Id");
        entityBuilder.Property(t => t.IsDeleted).IsRequired().HasColumnName("IsDeleted");
        entityBuilder.Property(t => t.CreatedOn).IsRequired().HasColumnName("CreatedOn");
        entityBuilder.Property(t => t.CreatedBy).IsRequired().HasMaxLength(255).HasColumnName("CreatedBy");
        entityBuilder.Property(t => t.ModifiedOn).HasColumnName("ModifiedOn");
        entityBuilder.Property(t => t.ModifiedBy).HasMaxLength(255).HasColumnName("ModifiedBy");
        entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);

        entityBuilder.Ignore(x => x.RowVersion);
    }
}