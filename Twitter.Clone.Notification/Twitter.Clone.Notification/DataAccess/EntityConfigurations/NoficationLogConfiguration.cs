using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Twitter.Clone.Notification.Model;

namespace Twitter.Clone.Notification.DataAccess.EntityConfigurations
{
    public class NoficationLogConfiguration : IEntityTypeConfiguration<NotificationLog>
    {
        public void Configure(EntityTypeBuilder<NotificationLog> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.EventBody).HasMaxLength(500);
        }
    }
}
