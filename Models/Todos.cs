﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apidemo.Models
{
    public partial class Todos
    {
        [Key]
        public int Id { get; set; }
        public string Item { get; set; }
    }
}