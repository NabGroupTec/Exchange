using System.ComponentModel.DataAnnotations;

namespace Exchange.Domain.Entities
{
    public class BankAccount : BaseEntity
    {
        [MaxLength(255)]
        [StringLength(255)]
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; } // nvarchar(255)

        [MaxLength(255)]
        [StringLength(255)]
        [Required]
        [Display(Name = "Bank Name")]
        public string BankName { get; set; } // nvarchar(255)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Account Number")]
        public string AccountNumber { get; set; } // nvarchar(255)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Shaba Number")]
        public string ShabaNumber { get; set; } // nvarchar(255)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Cart Number")]
        public string CartNumber { get; set; } // nvarchar(255)

        [Required]
        [Display(Name = "Currency Id")]
        public int CurrencyId { get; set; } // int


        // dbo.BankAccounts.CurrencyId -> dbo.Currencies.Id (FK_dbo.BankAccounts_dbo.Currencies_CurrencyId)
        public Currency Currency { get; set; }

        // dbo.BankAccounts.UserId -> dbo.Users.Id (FK_BankAccounts_Users)
    }
}