﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medilink_Final_Project.Models.Contact
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
