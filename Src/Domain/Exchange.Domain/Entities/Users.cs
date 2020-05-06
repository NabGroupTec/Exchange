using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exchange.Domain.Entities
{
    public class Users : BaseEntity
    {
        public Users()
        {
            AccountCapitals = new HashSet<AccountCapital>();
            BankAccounts = new HashSet<BankAccount>();
            BaseInfoDetails = new HashSet<BaseInfoDetails>();
            BaseInfoGroups = new HashSet<BaseInfoGroup>();
            CashDesks = new HashSet<CashDesk>();
            Coins = new HashSet<Coins>();
            Costs = new HashSet<Cost>();
            Countries = new HashSet<Country>();
            Currencies = new HashSet<Currency>();
            Incomes = new HashSet<Income>();
            People = new HashSet<People>();
            UserAccesses = new HashSet<UserAccess>();
            VoucherHeaders = new HashSet<VoucherHeader>();
        }

        [MaxLength(255)]
        [StringLength(255)]
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; } // nvarchar(255)

        [MaxLength(255)]
        [StringLength(255)]
        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; } // nvarchar(255)

        [MaxLength(255)]
        [StringLength(255)]
        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; } // nvarchar(255)

        [MaxLength(11)]
        [StringLength(11)]
        [Display(Name = "Tell")]
        public string Tell { get; set; } // nvarchar(11)

        [MaxLength(11)]
        [StringLength(11)]
        [Display(Name = "Mobile")]
        public string Mobile { get; set; } // nvarchar(11)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Address")]
        public string Address { get; set; } // nvarchar(255)


        public ICollection<AccountCapital> AccountCapitals { get; set; }

        // dbo.BankAccounts.UserId -> dbo.Users.Id (FK_BankAccounts_Users)
        public ICollection<BankAccount> BankAccounts { get; set; }

        // dbo.BaseInfoDetails.UserId -> dbo.Users.Id (FK_BaseInfoDetails_Users)
        public ICollection<BaseInfoDetails> BaseInfoDetails { get; set; }

        // dbo.BaseInfoGroups.UserId -> dbo.Users.Id (FK_BaseInfoGroups_Users)
        public ICollection<BaseInfoGroup> BaseInfoGroups { get; set; }

        // dbo.CashDesks.UserId -> dbo.Users.Id (FK_CashDesks_Users)
        public ICollection<CashDesk> CashDesks { get; set; }

        // dbo.Coins.UserId -> dbo.Users.Id (FK_Coins_Users)
        public ICollection<Coins> Coins { get; set; }

        // dbo.Costs.UserId -> dbo.Users.Id (FK_Costs_Users)
        public ICollection<Cost> Costs { get; set; }

        // dbo.Countries.UserId -> dbo.Users.Id (FK_Countries_Users)
        public ICollection<Country> Countries { get; set; }

        // dbo.Currencies.UserId -> dbo.Users.Id (FK_Currencies_Users)
        public ICollection<Currency> Currencies { get; set; }

        // dbo.Incomes.UserId -> dbo.Users.Id (FK_Incomes_Users)
        public ICollection<Income> Incomes { get; set; }

        // dbo.People.UserId -> dbo.Users.Id (FK_People_Users)
        public ICollection<People> People { get; set; }

        // dbo.UserAccesses.UsersId -> dbo.Users.Id (FK_dbo.UserAccesses_dbo.Users_UsersId)
        public ICollection<UserAccess> UserAccesses { get; set; }

        // dbo.VoucherHeaders.UserId -> dbo.Users.Id (FK_dbo.VoucherHeaders_dbo.Users_UserId)
        public ICollection<VoucherHeader> VoucherHeaders { get; set; }
    }
}