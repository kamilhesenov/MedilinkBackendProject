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

        [Required(ErrorMessage = "Ad boş ola bilməz"), MaxLength(50, ErrorMessage = "Maksimum 50 xarakter olmalıdır")]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Photo { get; set; }

        [Required(ErrorMessage = "Kontent boş ola bilməz"), MaxLength(500, ErrorMessage = "Maksimum 500 xarakter olmalıdır")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Mənfəət boş ola bilməz"), MaxLength(500, ErrorMessage = "Maksimum 500 xarakter olmalıdır")]
        public string Advantage { get; set; }

        [Required(ErrorMessage = "Mətin boş ola bilməz"), MaxLength(600, ErrorMessage = "Maksimum 600 xarakter olmalıdır")]
        public string Text { get; set; }

        [NotMapped]
        public IFormFile Upload { get; set; }
        public List<Doctor> Doctors { get; set; }
    }
}
