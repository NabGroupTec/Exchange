using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exchange.Domain.Entities
{
    public class VoucherHeader
    {
        public VoucherHeader()
        {
            VoucherLines = new HashSet<VoucherLine>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; } // int

        [Required] [Display(Name = "User Id")] public int UserId { get; set; } // int

        [Required]
        [Display(Name = "Manual Date")]
        [MaxLength(10)]
        [StringLength(10)]
        public string ManualDate { get; set; } // datetime

        [Required]
        [Display(Name = "Log Record")]
        public DateTime LogRecord { get; set; } // datetime

        [MaxLength(1000)]
        [StringLength(1000)]
        [Display(Name = "Comment")]
        public string Comment { get; set; } // nvarchar(1000)

        // dbo.VoucherHeaders.UserId -> dbo.Users.Id (FK_dbo.VoucherHeaders_dbo.Users_UserId)
        public Users User { get; set; }

        // dbo.VoucherLines.VoucherHeaderId -> dbo.VoucherHeaders.Id (FK_dbo.VoucherLines_dbo.VoucherHeaders_VoucherHeaderId)
        public ICollection<VoucherLine> VoucherLines { get; set; }
    }
}