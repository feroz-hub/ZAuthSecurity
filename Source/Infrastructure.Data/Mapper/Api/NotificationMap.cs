using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;


/// <summary>
/// Configures the mapping between the Notification entity and its corresponding database table.
/// </summary>
public class NotificationMap
{
    private const string NotificationTableName = "Notification";

    /// <summary>
    /// Initializes a new instance of the <see cref="NotificationMap"/> class.
    /// </summary>
    /// <param name="entityBuilder">The entity builder for Notification.</param>
    public NotificationMap(EntityTypeBuilder<Notification> entityBuilder)
    {
        NotificationMapping(entityBuilder);
    }

    // Method to define the mapping between Notification entity and database table
    private static void NotificationMapping(EntityTypeBuilder<Notification> entityBuilder)
    {
        if (entityBuilder == null) return;

        // Table name
        entityBuilder.ToTable(NotificationTableName);

        // Primary Key
        entityBuilder.HasKey(t => t.Id);

        // Index
        entityBuilder.HasIndex(t => t.Type).HasDatabaseName("IX_NOTI_TYPE");

        // Properties
        entityBuilder.Property(t => t.UserId).IsRequired();
        entityBuilder.Property(t => t.Type).IsRequired();
        entityBuilder.Property(t => t.Activity).HasMaxLength(255);
        entityBuilder.Property(t => t.Status).HasMaxLength(255);
        entityBuilder.Property(t => t.Sender).IsRequired().HasMaxLength(255);
        entityBuilder.Property(t => t.Recipient).IsRequired().HasMaxLength(255);
        entityBuilder.Property(t => t.MessageId).IsRequired().HasMaxLength(255);

        // Column mappings
        entityBuilder.Property(t => t.IsDeleted).IsRequired().HasColumnName("IsDeleted");
        entityBuilder.Property(t => t.CreatedOn).IsRequired().HasColumnName("CreatedOn");
        entityBuilder.Property(t => t.CreatedBy).IsRequired().HasMaxLength(255).HasColumnName("CreatedBy");
        entityBuilder.Property(t => t.ModifiedOn).HasColumnName("ModifiedOn");
        entityBuilder.Property(t => t.ModifiedBy).HasMaxLength(255).HasColumnName("ModifiedBy");

        // Query filter for soft deletion
        entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);

        // Ignore RowVersion property
        entityBuilder.Ignore(x => x.RowVersion);
    }
}
