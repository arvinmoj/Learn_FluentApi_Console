using Microsoft.EntityFrameworkCore;
namespace Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: "Password=A!1q2w3e!;Persist Security Info=True;User ID=SA; Initial Catalog = FluentApi; Data Source=ASUS\\SQLSERVER");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Student>()
                .Property(s => s.StudentId)
                .IsRequired()
                .HasColumnName("STU_ID");

            modelBuilder.Entity<Models.Student>()
                .Property(s => s.StudentName)
                .IsRequired()
                .HasColumnName("STU_NAME")
                .HasMaxLength(150);

            // One To One Relation
            modelBuilder.Entity<Models.Student>()
                .HasOne<Models.StudentAddress>(f => f.Address)
                .WithOne(s => s.Student)
                .HasForeignKey<Models.StudentAddress>(s => s.StudentId);

            // One To Many Relation
            modelBuilder.Entity<Models.Student>()
                .HasOne<Models.Grade>(c => c.Grade)
                .WithMany(c => c.Students)
                .HasForeignKey(c => c.GradeId);

            modelBuilder.Entity<Models.StudentCourse>()
                .HasKey(c => new { c.StudentId, c.CourseId });

            modelBuilder.Entity<Models.StudentCourse>()
                .HasOne<Models.Course>(c => c.Course)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(c => c.CourseId);

            modelBuilder.Entity<Models.StudentCourse>()
                .HasOne<Models.Student>(c => c.Student)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(c => c.StudentId);
        }

        public DbSet<Models.Student> Students { get; set; }

        public DbSet<Models.StudentAddress> StudentAddresses { get; set; }

        public DbSet<Models.Grade> Grades { get; set; }

        public DbSet<Models.StudentCourse> StudentCourses { get; set; }
    }
}