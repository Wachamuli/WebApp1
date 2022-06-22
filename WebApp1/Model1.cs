using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApp1
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<mark> marks { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<supplier> suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<category>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<category>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<mark>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<mark>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.listPrice)
                .HasPrecision(22, 2);

            modelBuilder.Entity<product>()
                .Property(e => e.purchasePrice)
                .HasPrecision(22, 2);

            modelBuilder.Entity<product>()
                .Property(e => e.width)
                .HasPrecision(22, 2);

            modelBuilder.Entity<product>()
                .Property(e => e.height)
                .HasPrecision(22, 2);

            modelBuilder.Entity<product>()
                .Property(e => e.weight)
                .HasPrecision(22, 2);

            modelBuilder.Entity<product>()
                .Property(e => e.color)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.picture)
                .IsUnicode(false);

            modelBuilder.Entity<supplier>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<supplier>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<supplier>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<supplier>()
                .Property(e => e.website)
                .IsUnicode(false);
        }
    }
}
