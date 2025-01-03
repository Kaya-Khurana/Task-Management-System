using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Task
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        public bool IsCompleted { get; set; }
    }
}
