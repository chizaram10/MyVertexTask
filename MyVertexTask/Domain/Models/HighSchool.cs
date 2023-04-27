using System;
using System.ComponentModel.DataAnnotations;

namespace MyVertexTask.Domain.Models
{
    public class HighSchool
    {
        [Key, ScaffoldColumn(false)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Required]
        public string Name { get; set; }
        [Required]
        public string DateLastAttended { get; set; }
    }
}