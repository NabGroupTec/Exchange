using System.ComponentModel.DataAnnotations;

namespace Exchange.Domain.Entities
{
    public class UserAccess : BaseEntity
    {
        [Required]
        [Display(Name = "Users Id")]
        public int UsersId { get; set; } // int

        public Users Users { get; set; }

        [Required]
        [Display(Name = "System Parts Id")]
        public int SystemPartsId { get; set; } // int


        // dbo.UserAccesses.SystemPartsId -> dbo.SystemParts.Id (FK_dbo.UserAccesses_dbo.SystemParts_SystemPartsId)
        public SystemParts SystemPart { get; set; }
    }
}