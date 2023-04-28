using MyVertexTask.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyVertexTask
{
    public partial class SER_FORM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Onclick(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                var filledForm = new SERForm1Side1
                {
                    HighSchool = GetHighSchool(TextBox9.Text, TextBox10.Text),
                    Name = TextBox3.Text,
                    Gender = RadioButton3.Checked ? "Male" : "Female",
                    PresentCollege = TextBox1.Text,
                    PresentConference = TextBox2.Text,
                    Sports = DropDownList1.SelectedValue,
                    PreviousSeasons = RadioButton2.Checked ? 1 : 0,
                    StudentID = TextBox4.Text,
                    Telephone = TextBox7.Text,
                    PresentAddress = TextBox6.Text,
                    DateofFilled = TextBox5.Text,
                    DateOfBirth = TextBox8.Text,
                    PostHighSchoolExps = GetPostHighSchoolExps(this),
                    CollegeSports = GetCollegeSports(this)
                };
            }
        }

        private static HighSchool GetHighSchool(string name, string dateLastAttended)
        {
            return new HighSchool
            {
                Name = name,
                DateLastAttended = dateLastAttended,
            };
        }

        private static List<CollegeSport> GetCollegeSports(Page page)
        {
            var CollegeSports = new List<CollegeSport>();

            for (int i = 1; i < 4; i++)
            {
                string sports = ((TextBox)page.FindControl("Sports" + i)).Text;
                string college = ((TextBox)page.FindControl("College" + i)).Text;
                string varsity = ((TextBox)page.FindControl("Varsity" + i)).Text;
                string semester = ((TextBox)page.FindControl("Semester" + i)).Text;
                string yr = ((TextBox)page.FindControl("Yr" + i)).Text;


                if (!string.IsNullOrEmpty(sports) || !string.IsNullOrEmpty(college) ||
                    !string.IsNullOrEmpty(varsity) || !string.IsNullOrEmpty(semester) || !string.IsNullOrEmpty(yr))
                {
                    CollegeSport collegeSport = new CollegeSport
                    {
                        Sports = sports,
                        College = college,
                        Semester = semester,
                        VrsityJVOrClub = varsity,
                        Year = yr
                    };

                    CollegeSports.Add(collegeSport);
                }
            }

            return CollegeSports;
        }

        private static List<PostHighSchoolExp> GetPostHighSchoolExps(Page page)
        {
            List<PostHighSchoolExp> postHighSchoolExpList = new List<PostHighSchoolExp>();

            for (int i = 1; i < 6; i++)
            {
                string fromMo = ((TextBox)page.FindControl("FromMo" + i)).Text;
                string fromYr = ((TextBox)page.FindControl("FromYr" + i)).Text;
                string toMo = ((TextBox)page.FindControl("ToMo" + i)).Text;
                string toYr = ((TextBox)page.FindControl("ToYr" + i)).Text;
                string collegesJobs = ((TextBox)page.FindControl("CollegesJobs" + i)).Text;

                
                if (!string.IsNullOrEmpty(fromMo) || !string.IsNullOrEmpty(fromYr) ||
                    !string.IsNullOrEmpty(toMo) || !string.IsNullOrEmpty(toYr) || !string.IsNullOrEmpty(collegesJobs))
                {
                    PostHighSchoolExp postHighSchoolExp = new PostHighSchoolExp
                    {
                        From = $"{fromMo}/{fromYr}",
                        To = $"{toMo}/{toYr}",
                        CollegesAttendedOrJobsHeld = collegesJobs
                    };
                    

                    postHighSchoolExpList.Add(postHighSchoolExp);
                }
            }

            return postHighSchoolExpList;
        }
    }
}