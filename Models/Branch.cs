﻿using System.ComponentModel.DataAnnotations;

namespace Shipping_System.Models
{
    public class Branch
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [MinLength(3, ErrorMessage = "Name must be more than 3 char")]
        public string Name { get; set; }

        public DateTime? CreationDate { get; set; }

        public bool IsDeleted { get; set; }
        public List<ApplicationUser>? Users { get; set; }
    }
}
