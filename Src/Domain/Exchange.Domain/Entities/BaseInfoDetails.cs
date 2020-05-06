using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exchange.Domain.Entities
{
    public class BaseInfoDetails : BaseEntity
    {
        public BaseInfoDetails()
        {
            People = new HashSet<People>();
        }

        [Required]
        [Display(Name = "Base Info Group Id")]
        public int BaseInfoGroupId { get; set; } // int

        [MaxLength(255)]
        [StringLength(255)]
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; } // nvarchar(255)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Text")]
        public string Text { get; set; } // nvarchar(255)


        public BaseInfoGroup BaseInfoGroup { get; set; }

        // dbo.BaseInfoDetails.UserId -> dbo.Users.Id (FK_BaseInfoDetails_Users)

        // dbo.People.Nationality -> dbo.BaseInfoDetails.Id (FK_dbo.People_dbo.BaseInfoDetails_Nationality)
        public ICollection<People> People { get; set; }
    }
}