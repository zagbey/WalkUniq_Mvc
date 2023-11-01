﻿using System.ComponentModel.DataAnnotations;

namespace WalkUniq.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required] // not null
        public required string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
