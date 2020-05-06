using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exchange.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required] [Display(Name = "User Id")] public int UserId { get; set; }

        [Required]
        [Display(Name = "Log Record")]
        public DateTime LogRecord { get; set; }

        [Required] [Display(Name = "Status")] public int Status { get; set; }

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "Comment")]
        public string Comment { get; set; }

        //public virtual Users User { get; set; }
    }
}