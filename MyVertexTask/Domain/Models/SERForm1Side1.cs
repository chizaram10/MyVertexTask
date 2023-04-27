using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyVertexTask.Domain.Models
{
    public class SERForm1Side1
    {
        [Key, ScaffoldColumn(false)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string PresentCollege { get; set; }
        [Required]
        public string PresentConference { get; set; }
        [Required]
        public string Sports { get; set; }
        [Required]
        public int PreviousSeasons { get; set; }
        [Required]
        public string StudentID { get; set; }
        [Required]
        public string Telephone { get; set; }
        [Required]
        public string PresentAddress { get; set; }
        [Required]
        public string DateofFilled { get; set; }
        [Required]
        public string DateOfBirth { get; set; }

        [ScaffoldColumn(false)]
        public string HighSchoolID { get; set; }
        [Required]
        public HighSchool HighSchool { get; set; }

        public ICollection<PostHighSchoolExp> PostHighSchoolExps { get; set; }
        public ICollection<CollegeSport> CollegeSports { get; set; }
    }
}