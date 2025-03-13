﻿using System.ComponentModel.DataAnnotations;

namespace MvcWebApp.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name ="Employee Name")]
        [StringLength(25, MinimumLength = 2)]
        public string Name { get; set; }
        
        [StringLength(25, MinimumLength = 5)]
        public string Designation { get; set; }

        [StringLength(50, MinimumLength = 5)]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; } 

        public DateTime? RecordCreatedOn { get; set; }

    }
}
