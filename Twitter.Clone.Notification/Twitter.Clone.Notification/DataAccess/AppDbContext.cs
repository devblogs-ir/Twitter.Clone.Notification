using Microsoft.EntityFrameworkCore;
using Twitter.Clone.Notification.Model;

namespace Twitter.Clone.Notification.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            base.OnModelCreating(modelBuilder);

        }


        //dbsets here
        public DbSet<NotificationLog> NotificatoinLog { get; set; }
    }
}
