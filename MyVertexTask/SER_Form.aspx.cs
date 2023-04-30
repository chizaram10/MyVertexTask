using MyVertexTask.DAL.Repo;
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
        private readonly ISERForm1Side1Repo repo = new SERForm1Side1Repo();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cvGender_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = RadioButton3.Checked || RadioButton4.Checked;
        }

        protected void cvPreviousSeasonsOptions_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = RadioButton1.Checked || RadioButton2.Checked;
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
                    PostHighSchoolExps = GetPostHighSchoolExps(FromMo1.Parent),
                    CollegeSports = GetCollegeSports(FromMo1.Parent)
                };

                repo.SaveForm(filledForm);
                Response.Redirect(Request.RawUrl + "?success=true");
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

        private static List<CollegeSport> GetCollegeSports(Control control)
        {
            var collegeSports = new List<CollegeSport>();

            for (int i = 1; i < 4; i++)
            {
                string sportsID = $"Sport{i}";
                string collegeID = $"College{i}";
                string varsityID = $"Varsity{i}";
                string semesterID = $"Semester{i}";
                string yrID = $"Yr{i}";

                string sports = ((TextBox)control.FindControl(sportsID)).Text;
                string college = ((TextBox)control.FindControl(collegeID)).Text;
                string varsity = ((TextBox)control.FindControl(varsityID)).Text;
                string semester = ((TextBox)control.FindControl(semesterID)).Text;
                string yr = ((TextBox)control.FindControl(yrID)).Text;


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

                    collegeSports.Add(collegeSport);
                }
            }

            return collegeSports;
        }

        private static List<PostHighSchoolExp> GetPostHighSchoolExps(Control control)
        {
            List<PostHighSchoolExp> postHighSchoolExpList = new List<PostHighSchoolExp>();

            for (int i = 1; i < 6; i++)
            {
                string fromMoID = $"FromMo{i}";
                string fromYrID = $"fromYr{i}";
                string toMoID = $"ToMo{i}";
                string toYrID = $"ToYr{i}";
                string collegesJobsID = $"CollegesJobs{i}";
                
                string fromMo = ((TextBox)control.FindControl(fromMoID)).Text;
                string fromYr = ((TextBox)control.FindControl(fromYrID)).Text;
                string toMo = ((TextBox)control.FindControl(toMoID)).Text;
                string toYr = ((TextBox)control.FindControl(toYrID)).Text;
                string collegesJobs = ((TextBox)control.FindControl(collegesJobsID)).Text;

                
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