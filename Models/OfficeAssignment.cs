﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apidemo.Models
{
    public partial class OfficeAssignment
    {
        [Key]
        [Column("InstructorID")]
        public int InstructorId { get; set; }
        [StringLength(50)]
        public string Location { get; set; }

        [ForeignKey(nameof(InstructorId))]
        [InverseProperty(nameof(Person.OfficeAssignment))]
        public virtual Person Instructor { get; set; }
    }
}