using Domain.Entities.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mapper.Api;

public class UserSecurityQuestionsMap
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSecurityQuestionsMap"/> class.
        /// </summary>
        /// <param name="entityBuilder">An EntityTypeBuilder object of type <see cref="UserSecurityQuestions"/>.</param>
        public UserSecurityQuestionsMap(EntityTypeBuilder<UserSecurityQuestions> entityBuilder)
        {
            UserSecurityQuestionsMapping(entityBuilder);
        }

        /// <summary>
        /// Defines the table name, columns, required fields and max length for UserSecurityQuestions mapping.
        /// </summary>
        /// <param name="entityBuilder">An EntityTypeBuilder object of type <see cref="UserSecurityQuestions"/>.</param>
        private void UserSecurityQuestionsMapping(EntityTypeBuilder<UserSecurityQuestions> entityBuilder)
        {
            if (entityBuilder != null)
            {
                // Primary Key
                entityBuilder.HasKey(t => t.Id);
                entityBuilder.HasIndex(t => new { t.UserId, t.SecurityQuestionId }).HasDatabaseName("IX_USRSEC_UID_QUEID").IsUnique();
                entityBuilder.HasIndex(t => new { t.SecurityQuestionId }).HasDatabaseName("IX_USRSEC_QUEID");

                // Properties
                entityBuilder.Property(t => t.Answer).IsRequired().HasMaxLength(255);

                // Table & Column Mappings
                entityBuilder.ToTable("SF_UserSecurityQuestions");
                entityBuilder.Property(t => t.UserId).IsRequired().HasColumnName("UserId");
                entityBuilder.Property(t => t.SecurityQuestionId).IsRequired().HasColumnName("SecurityQuestionId");
                entityBuilder.Property(t => t.CreatedOn).IsRequired().HasColumnName("CreatedOn");
                entityBuilder.Property(t => t.CreatedBy).IsRequired().HasMaxLength(255).HasColumnName("CreatedBy");
                entityBuilder.Property(t => t.ModifiedOn).HasColumnName("ModifiedOn");
                entityBuilder.Property(t => t.ModifiedBy).HasMaxLength(255).HasColumnName("ModifiedBy");
                entityBuilder.HasQueryFilter(m => EF.Property<bool>(m, "IsDeleted") == false);
            }
        }
    }