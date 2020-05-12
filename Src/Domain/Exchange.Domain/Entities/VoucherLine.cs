using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exchange.Domain.Entities
{
    public class VoucherLine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; } // int

        [Required]
        [Display(Name = "Voucher Header Id")]
        public int VoucherHeaderId { get; set; } // int

        [Required]
        [Display(Name = "Entity Code")]
        public int EntityCode { get; set; } // int

        [MaxLength(1000)]
        [StringLength(1000)]
        [Display(Name = "Comment")]
        public string Comment { get; set; } // nvarchar(1000)

        [Required]
        [Display(Name = "Bed Price")]
        public decimal BedPrice { get; set; } // decimal(18,2)

        [Required]
        [Display(Name = "Bes Price")]
        public decimal BesPrice { get; set; } // decimal(18,2)

        [Required]
        [Display(Name = "Buy Price")]
        public decimal Cost { get; set; } // decimal(18,2)

        [Required]
        [Display(Name = "Currency Id")]
        public int CurrencyId { get; set; } // int

        [Required]
        [Display(Name = "Rate Price")]
        public decimal RatePrice { get; set; } // decimal(18,2)

        [Required]
        [Display(Name = "Bed TMIN")]
        public decimal BedTMIN { get; set; } // decimal(18,2)

        [Required]
        [Display(Name = "Bes TMIN")]
        public decimal BesTMIN { get; set; } // decimal(18,2)

        // dbo.VoucherLines.VoucherHeaderId -> dbo.VoucherHeaders.Id (FK_dbo.VoucherLines_dbo.VoucherHeaders_VoucherHeaderId)
        public VoucherHeader VoucherHeader { get; set; }

        // dbo.VoucherLines.CurrencyId -> dbo.Currencies.Id (FK_dbo.VoucherLines_dbo.Currencies_CurrencyId)
        public Currency Currency { get; set; }
    }
}