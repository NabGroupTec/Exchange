using System;
using System.ComponentModel.DataAnnotations;

namespace Exchange.Domain.Entities
{
    public class Employee : BaseEntity
    {
        [MaxLength(255)]
        [StringLength(255)]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } // nvarchar(255)

        [MaxLength(255)]
        [StringLength(255)]
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } // nvarchar(255)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Father Name")]
        public string FatherName { get; set; } // nvarchar(255)


        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "National Code")]
        public string NationalCode { get; set; } // nvarchar(10)

        [Required]
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; } // datetime


        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Tell")]
        public string Tell { get; set; } // nvarchar(255)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Mobile")]
        public string Mobile { get; set; } // nvarchar(255)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Email")]
        public string Email { get; set; } // nvarchar(255)


        [MaxLength(1000)]
        [StringLength(1000)]
        [Display(Name = "Address")]
        public string Address { get; set; } // nvarchar(1000)

        [MaxLength] [Display(Name = "Photo")] public byte[] Photo { get; set; } // varbinary(max)
    }
}