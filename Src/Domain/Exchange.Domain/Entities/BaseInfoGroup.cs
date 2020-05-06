using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exchange.Domain.Entities
{
    public class BaseInfoGroup : BaseEntity
    {
        public BaseInfoGroup()
        {
            BaseInfoDetails = new HashSet<BaseInfoDetails>();
        }

        [MaxLength(255)]
        [StringLength(255)]
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; } // nvarchar(255)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Text")]
        public string Text { get; set; } // nvarchar(255)
        // dbo.BaseInfoGroups.UserId -> dbo.Users.Id (FK_BaseInfoGroups_Users)

        // dbo.BaseInfoDetails.BaseInfoGroupId -> dbo.BaseInfoGroups.Id (FK_dbo.BaseInfoDetails_dbo.BaseInfoGroups_BaseInfoGroupId)
        public ICollection<BaseInfoDetails> BaseInfoDetails { get; set; }
    }
}