using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Medilink_Final_Project.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        [Required(ErrorMessage = "Ad və Soyad boş ola bilməz"), MaxLength(50, ErrorMessage = "Maksimum 50 xarakter olmalıdır")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Haqqımda boş ola bilməz"), MaxLength(1000, ErrorMessage = "Maksimum 1000 xarakter olmalıdır")]
        public string AboutMe { get; set; }

        [MaxLength(100)]
        public string Photo { get; set; }

        [Required(ErrorMessage = "Telefon boş ola bilməz"), MaxLength(50, ErrorMessage = "Maksimum 50 xarakter olmalıdır")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Ofis boş ola bilməz"), MaxLength(50, ErrorMessage = "Maksimum 50 xarakter olmalıdır")]
        public string Office { get; set; }

        [Required(ErrorMessage = "E-poçt boş ola bilməz"), MaxLength(50, ErrorMessage = "Maksimum 50 xarakter olmalıdır")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Facebook Linki boş ola bilməz"), MaxLength(50, ErrorMessage = "Maksimum 50 xarakter olmalıdır")]
        public string Facebook { get; set; }

        [Required(ErrorMessage = "Twitter Linki boş ola bilməz"), MaxLength(50, ErrorMessage = "Maksimum 50 xarakter olmalıdır")]
        public string Twitter { get; set; }

        [Required(ErrorMessage = "Linkedin Linki boş ola bilməz"), MaxLength(50, ErrorMessage = "Maksimum 50 xarakter olmalıdır")]
        public string Linkedin { get; set; }

        [Required(ErrorMessage = "Gmail Linki boş ola bilməz"), MaxLength(50, ErrorMessage = "Maksimum 50 xarakter olmalıdır")]
        public string Gmail { get; set; }

        [Required(ErrorMessage = "Kontent boş ola bilməz"), MaxLength(500, ErrorMessage = "Maksimum 500 xarakter olmalıdır")]
        public string Content { get; set; }

        [NotMapped]
        public IFormFile Upload { get; set; }
    }
}
