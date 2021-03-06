﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMR.Models
{
    public class Faculty
    {
        public int Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [StringLength(200, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public virtual ICollection<FacultyAssignment> FacultyAssignment { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}