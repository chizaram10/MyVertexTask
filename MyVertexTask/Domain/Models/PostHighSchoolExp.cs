using System;
using System.ComponentModel.DataAnnotations;

namespace MyVertexTask.Domain.Models
{
    public class PostHighSchoolExp
    {
        [Key, ScaffoldColumn(false)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string CollegesAttendedOrJobsHeld { get; set; }
        public string From { get; set; }
        public string To { get; set; }
    }
}