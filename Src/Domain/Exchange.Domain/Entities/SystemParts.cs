using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exchange.Domain.Entities
{
    public class SystemParts : BaseEntity
    {
        [MaxLength(255)]
        [StringLength(255)]
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; } // nvarchar(255)

        [MaxLength(255)]
        [StringLength(255)]
        [Required]
        [Display(Name = "Text")]
        public string Text { get; set; } // nvarchar(255)

        [Required] [Display(Name = "Level")] public int Level { get; set; } // int

        [Required]
        [Display(Name = "Priority")]
        public int Priority { get; set; } // int

        public ICollection<UserAccess> UserAccesses { get; set; }
    }
}