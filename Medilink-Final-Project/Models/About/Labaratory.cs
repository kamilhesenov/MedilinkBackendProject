﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Medilink_Final_Project.Models.About
{
    public class Labaratory
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Heading { get; set; }

        [Required, MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        [Required, MaxLength(500)]
        public string Subject { get; set; }

        [Required, MaxLength(600)]
        public string Text { get; set; }

        [MaxLength(100)]
        public string Photo { get; set; }

        [NotMapped]
        public IFormFile Upload { get; set; }
    }
}
