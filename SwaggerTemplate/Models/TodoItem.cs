﻿using System.ComponentModel.DataAnnotations;

namespace SwaggerTemplate.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

    }
}
