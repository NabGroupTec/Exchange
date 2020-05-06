using System.ComponentModel.DataAnnotations;

namespace Exchange.Domain.Entities
{
    public class Currency : BaseEntity
    {
        [MaxLength(255)]
        [StringLength(255)]
        [Required]
        [Display(Name = "Country")]
        public string Country { get; set; } // nvarchar(255)

        [MaxLength(255)]
        [StringLength(255)]
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; } // nvarchar(255)

        [Required]
        [Display(Name = "Number Digit")]
        public float NumberDigit { get; set; } // int

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Symbol")]
        public string Symbol { get; set; } // nvarchar(255)

        [Required]
        [Display(Name = "Purchase Rate")]
        public decimal PurchaseRate { get; set; } // decimal(18,2)

        [Required]
        [Display(Name = "Selling Rate")]
        public decimal SellingRate { get; set; } // decimal(18,2)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Symbol Float")]
        public string SymbolFloat { get; set; } // nvarchar(255)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Float Name")]
        public string FloatName { get; set; } // nvarchar(255)

        [Required]
        [Display(Name = "Is Primary")]
        public bool IsPrimary { get; set; } // bit


        // dbo.Currencies.UserId -> dbo.Users.Id (FK_Currencies_Users)
        public Users User { get; set; }
    }
}