using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Medilink_Final_Project.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Photo { get; set; }

        [Required, MaxLength(500)]
        public string Content { get; set; }

        [Required, MaxLength(500)]
        public string Advantage { get; set; }

        [Required, MaxLength(600)]
        public string Text { get; set; }

        [NotMapped]
        public IFormFile Upload { get; set; }
        public List<Doctor> Doctors { get; set; }
    }
}
