using System;
using System.ComponentModel.DataAnnotations;

namespace MyVertexTask.Domain.Models
{
    public class CollegeSport
    {
        [Key, ScaffoldColumn(false)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Sports { get; set; }
        public string College { get; set; }
        public string VrsityJVOrClub { get; set; }
        public string Semester { get; set; }
        public string Year { get; set; }
    }
}