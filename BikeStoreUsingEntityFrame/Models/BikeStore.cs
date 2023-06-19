using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BikeStoreUsingEntityFrame.Models
{
    public partial class BikeStore : DbContext
    {
        public BikeStore()
            : base("name=Store")
        {
        }

        public virtual DbSet<brand> brands { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<order_items> order_items { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<staff> staffs { get; set; }
        public virtual DbSet<stock> stocks { get; set; }
        public virtual DbSet<store> stores { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<brand>()
                .Property(e => e.brand_name)
                .IsUnicode(false);

            modelBuilder.Entity<brand>()
                .HasMany(e => e.products)
                .WithRequired(e => e.brand)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<category>()
                .Property(e => e.category_name)
                .IsUnicode(false);

            modelBuilder.Entity<category>()
                .HasMany(e => e.products)
                .WithRequired(e => e.category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.street)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.zip_code)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.orders)
                .WithRequired(e => e.customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<order_items>()
                .Property(e => e.list_price)
                .HasPrecision(7, 2);

            modelBuilder.Entity<order_items>()
                .Property(e => e.discount)
                .HasPrecision(7, 2);

            modelBuilder.Entity<order>()
                .HasMany(e => e.order_items)
                .WithRequired(e => e.order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<product>()
                .Property(e => e.product_name)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.model_year)
                .HasPrecision(4, 0);

            modelBuilder.Entity<product>()
                .Property(e => e.list_price)
                .HasPrecision(7, 2);

            modelBuilder.Entity<product>()
                .HasMany(e => e.order_items)
                .WithRequired(e => e.product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<product>()
                .HasMany(e => e.stocks)
                .WithRequired(e => e.product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<staff>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<staff>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<staff>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<staff>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<staff>()
                .HasMany(e => e.orders)
                .WithRequired(e => e.staff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<store>()
                .Property(e => e.store_name)
                .IsUnicode(false);

            modelBuilder.Entity<store>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<store>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<store>()
                .Property(e => e.street)
                .IsUnicode(false);

            modelBuilder.Entity<store>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<store>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<store>()
                .Property(e => e.zip_code)
                .IsUnicode(false);

            modelBuilder.Entity<store>()
                .HasMany(e => e.orders)
                .WithRequired(e => e.store)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<store>()
                .HasMany(e => e.staffs)
                .WithRequired(e => e.store)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<store>()
                .HasMany(e => e.stocks)
                .WithRequired(e => e.store)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.UserType)
                .IsUnicode(false);
        }
    }
}
