using System.ComponentModel.DataAnnotations;

namespace Exchange.Domain.Entities
{
    public class Coins : BaseEntity
    {
        [MaxLength(255)]
        [StringLength(255)]
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; } // nvarchar(255)

        [Required]
        [Display(Name = "Buy Rate")]
        public decimal BuyRate { get; set; } // decimal(18,2)

        [Required]
        [Display(Name = "Sell Rate")]
        public decimal SellRate { get; set; } // decimal(18,2)
    }
}