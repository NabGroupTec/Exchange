using System.ComponentModel.DataAnnotations;

namespace Exchange.Domain.Entities
{
    public class Country : BaseEntity
    {
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Iso")]
        public string Iso { get; set; } // nvarchar(255)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Continent")]
        public string Continent { get; set; } // nvarchar(255)

        [MaxLength(255)]
        [StringLength(255)]
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; } // nvarchar(255)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Code")]
        public string Code { get; set; } // nvarchar(255)
    }
}