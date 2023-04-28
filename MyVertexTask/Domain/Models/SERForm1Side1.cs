using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyVertexTask.Domain.Models
{
    public class SERForm1Side1
    {
        [Key, ScaffoldColumn(false)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Required(ErrorMessage = "*")]
        public string Name { get; set; }
        [Required(ErrorMessage = "*")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "*")]
        public string PresentCollege { get; set; }
        [Required(ErrorMessage = "*")]
        public string PresentConference { get; set; }
        [Required(ErrorMessage = "*")]
        public string Sports { get; set; }
        [Required(ErrorMessage = "*")]
        public int PreviousSeasons { get; set; }
        [Required(ErrorMessage = "*")]
        public string StudentID { get; set; }
        [Required(ErrorMessage = "*")]
        public string Telephone { get; set; }
        [Required(ErrorMessage = "*")]
        public string PresentAddress { get; set; }
        [Required(ErrorMessage = "*")]
        public string DateofFilled { get; set; }
        [Required(ErrorMessage = "*")]
        public string DateOfBirth { get; set; }

        [ScaffoldColumn(false)]
        public string HighSchoolID { get; set; }
        
        public HighSchool HighSchool { get; set; }

        public ICollection<PostHighSchoolExp> PostHighSchoolExps { get; set; }
        public ICollection<CollegeSport> CollegeSports { get; set; }
    }
}