namespace lastWebApi.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=ModelFinal")
        {
        }

        public virtual DbSet<interests> interests { get; set; }
        public virtual DbSet<posts> posts { get; set; }
        public virtual DbSet<users> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<interests>()
                .Property(e => e.id)
                .HasPrecision(10, 0);

            modelBuilder.Entity<interests>()
                .Property(e => e.description)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<interests>()
                .Property(e => e.users_id)
                .HasPrecision(10, 0);

            modelBuilder.Entity<posts>()
                .Property(e => e.id)
                .HasPrecision(10, 0);

            modelBuilder.Entity<posts>()
                .Property(e => e.description)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<posts>()
                .Property(e => e.users_id)
                .HasPrecision(10, 0);

            modelBuilder.Entity<posts>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.id)
                .HasPrecision(10, 0);

            modelBuilder.Entity<users>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.email)
                .IsUnicode(false);
            
        }
    }
}
