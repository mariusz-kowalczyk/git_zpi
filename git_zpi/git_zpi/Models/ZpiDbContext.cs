using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_zpi.Models
{
    class ZpiDbContext : DbContext
    {
        public ZpiDbContext()
            : base("SqlClient")
        {
        }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<InvoiceModel> Invoices { get; set; }
        public DbSet<InvoiceAddressModel> InvoiceAddresses { get; set; }
        public DbSet<InvoiceProductModel> InvoiceProducts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<InvoiceModel>()
                .HasOptional(i => i.ProviderAddress)
                .WithOptionalDependent()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InvoiceModel>()
                .HasOptional(i => i.BuyerAddress)
                .WithOptionalDependent()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InvoiceModel>()
                .HasOptional(i => i.DeliveryAddress)
                .WithOptionalDependent()
                .WillCascadeOnDelete(false);
        }
    }
}
