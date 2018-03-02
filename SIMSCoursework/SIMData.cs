namespace SIMSCoursework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SIMData : DbContext
    {
        public SIMData()
            : base("name=SIMData")
        {
        }

        public virtual DbSet<academic_year> academic_year { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<comment> comments { get; set; }
        public virtual DbSet<department> departments { get; set; }
        public virtual DbSet<document> documents { get; set; }
        public virtual DbSet<idea> ideas { get; set; }
        public virtual DbSet<rate> rates { get; set; }
        public virtual DbSet<user_roles> user_roles { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<academic_year>()
                .Property(e => e.academicYear_Name)
                .IsUnicode(false);

            modelBuilder.Entity<academic_year>()
                .HasMany(e => e.ideas)
                .WithRequired(e => e.academic_year)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<category>()
                .Property(e => e.category_Name)
                .IsUnicode(false);

            modelBuilder.Entity<category>()
                .HasMany(e => e.ideas)
                .WithRequired(e => e.category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<comment>()
                .Property(e => e.comment_Body)
                .IsUnicode(false);

            modelBuilder.Entity<comment>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<department>()
                .Property(e => e.department_Name)
                .IsUnicode(false);

            modelBuilder.Entity<department>()
                .HasMany(e => e.users)
                .WithRequired(e => e.department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<document>()
                .Property(e => e.path)
                .IsUnicode(false);

            modelBuilder.Entity<idea>()
                .Property(e => e.idea_Title)
                .IsUnicode(false);

            modelBuilder.Entity<idea>()
                .Property(e => e.idea_Body)
                .IsUnicode(false);

            modelBuilder.Entity<idea>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<idea>()
                .HasMany(e => e.comments)
                .WithOptional(e => e.idea)
                .WillCascadeOnDelete();

            modelBuilder.Entity<idea>()
                .HasMany(e => e.documents)
                .WithOptional(e => e.idea)
                .WillCascadeOnDelete();

            modelBuilder.Entity<idea>()
                .HasOptional(e => e.rate)
                .WithRequired(e => e.idea);

            modelBuilder.Entity<user_roles>()
                .Property(e => e.userRole_Name)
                .IsUnicode(false);

            modelBuilder.Entity<user_roles>()
                .HasMany(e => e.users)
                .WithRequired(e => e.user_roles)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .Property(e => e.user_Uni_Id)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.user_FullName)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.user_Email)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.user_Password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.comments)
                .WithOptional(e => e.user)
                .WillCascadeOnDelete();

            modelBuilder.Entity<user>()
                .HasMany(e => e.rates)
                .WithRequired(e => e.user)
                .WillCascadeOnDelete(false);
        }
    }
}
