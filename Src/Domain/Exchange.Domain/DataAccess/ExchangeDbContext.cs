using System.Data.Entity;
using Exchange.Domain.DataAccess.Migrations;
using Exchange.Domain.Entities;

namespace Exchange.Domain.DataAccess
{
    public class ExchangeDbContext : DbContext
    {
        static ExchangeDbContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ExchangeDbContext, Configuration>());
        }

        public DbSet<BaseInfoGroup> BaseInfoGroups { get; set; }
        public DbSet<BaseInfoDetails> BaseInfoDetails { get; set; }
        public DbSet<People> People { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<UserAccess> UserAccess { get; set; }
        public DbSet<SystemParts> SystemParts { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Cost> Costs { get; set; }
        public DbSet<Coins> Coins { get; set; }
        public DbSet<CashDesk> CashDesks { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<AccountCapital> AccountCapitals { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<VoucherHeader> VoucherHeaders { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Estate> Estates { get; set; }
        public DbSet<VoucherLine> VoucherLines { get; set; }
        public DbSet<PerlerDocuments> PerlerDocuments { get; set; }
        public DbSet<ReceivingDocuments> ReceivingDocuments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VoucherLine>().HasRequired(i => i.Currency).WithMany().WillCascadeOnDelete(false);
        }
    }
}