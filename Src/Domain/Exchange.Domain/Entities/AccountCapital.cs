using System.ComponentModel.DataAnnotations;

namespace Exchange.Domain.Entities
{
    public class AccountCapital : BaseEntity
    {
        [MaxLength(255)]
        [StringLength(255)]
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; } // nvarchar(255)
    }
}