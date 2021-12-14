using Microsoft.EntityFrameworkCore;
using SrAuto.Models;

namespace SrAuto.Data
{
    public class SrAutoContext : DbContext
    {

        public SrAutoContext(DbContextOptions<SrAutoContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<DateFix> DateFixes { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Date> Dates { get; set; }
        public DbSet<Fix> Fixes { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<DateReason> DateReasons { get; set; }

        /*
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        */
    }
}