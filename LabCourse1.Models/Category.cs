﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LabCourse1.Models
{
    public class Category
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100, ErrorMessage ="Display Order must be in range of 1-100") ]
        public int DisplayOrder { get; set; }
    }
}
