﻿using System.ComponentModel.DataAnnotations;

namespace Exchange.Domain.Entities
{
    public class Cost : BaseEntity
    {
        [MaxLength(255)]
        [StringLength(255)]
        [Required]
        [Display(Name = "Name")]

        public string Name { get; set; }
    }
}