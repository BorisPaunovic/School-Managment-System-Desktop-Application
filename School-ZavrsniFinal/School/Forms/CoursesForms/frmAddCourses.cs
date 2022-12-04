using School.Forms.SubjectsForms;
using SchoolBL;
using SchoolModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School.Forms
{
    public partial class frmAddCourses : Form
    {
        private bool _isClbSubjectsValid= false;
        private bool _IsCoursesSubjectsSaved = false;
        List<Subjects> chosenSubjects = new List<Subjects>();
        List<Subjects> subjectsList = new List<Subjects>();
        private bool _isCourseNameValid = false;
        private bool _isCourseDescriptionValid = false;
        private bool _isEverythingValid = false;
        private bool _IsCourseSaved = false;
        Courses courses = new Courses();
        Courses courseByName = new Courses();
        CoursesBL coursesBL = new CoursesBL();
        SubjectsBL subjectsBL = new SubjectsBL();
        CoursesSubjects coursesSubjects = new CoursesSubjects();
        CoursesSubjectsBL coursesSubjectsBL = new CoursesSubjectsBL();
        private bool _courseIsAdded = false;
        public bool CourseIsAdded
        {
            get { return _courseIsAdded; }
        }
        public frmAddCourses()
        {
            InitializeComponent();
            coursesBindingSource.DataSource = courses;
         
            subjectsList = subjectsBL.SelectAllSubjects();

            LoadSubjects();
        }

        private void LoadSubjects()
        {
            foreach(var element in subjectsList)
            {
                clbSubjects.Items.Add(element.SubjectName);
            }
        }

        private void btnSaveCourse_Click(object sender, EventArgs e)
        {
           
            //ValidateEverything();
            AddCourse();
           
        }
        public void ValidateEverything()
        {
            _isCourseNameValid = coursesBL.ValidateCoursename(coursesNameTextBox.Text);
            _isCourseDescriptionValid = coursesBL.ValidateCourseDescription(courses.CoursesDescription);
            _isClbSubjectsValid = coursesBL.ValidateClbSubjects(clbSubjects);
            _isEverythingValid = coursesBL.ValidateCourse(_isCourseNameValid,_isCourseDescriptionValid, _isClbSubjectsValid);
            
            if (_isCourseNameValid == false)
            {
                errorProvider1.SetError(coursesNameTextBox, "Course name is not valid");
            }
            if (_isCourseDescriptionValid == false)
            {
                errorProvider1.SetError(coursesDescriptionTextBox, "Course Description is not valid");
            }
           if(_isClbSubjectsValid==false)
            {
                errorProvider1.SetError(clbSubjects, $"You must chose  {subjectsList.Count} Subjects");
                
            }
           
        }

        public void AddCourse()
        {
            int counter = 0;
            ValidateEverything();


            if (_isEverythingValid == true)
            {
                errorProvider1.Clear();
                _IsCourseSaved = coursesBL.SaveCourse(courses);
               
                courseByName = coursesBL.SelectCourseByName(courses.CoursesName);
                LoadChosenSubjects();
                foreach (var element in chosenSubjects)
                {
                    _IsCoursesSubjectsSaved = coursesSubjectsBL.AddCourseSubject(courseByName.CoursesID, element.SubjectId);
                    if(_IsCoursesSubjectsSaved==true)
                    {
                        counter++;
                        MessageBox.Show($"Course subject is saved {counter}");
                    }
                    else if(_IsCoursesSubjectsSaved==false)
                    {
                        MessageBox.Show("Ops something went wrong ");
                    }
                }



                if (_IsCourseSaved == true)
                {
                    
                    _courseIsAdded = true;
                    MessageBox.Show("Course is saved");
                    
                }
                else if (_IsCourseSaved == false)
                {
                    MessageBox.Show("Oops something went wrong");
                }

            }

        }
        public void LoadChosenSubjects()
        {

            foreach (var element in clbSubjects.CheckedItems)
            {

                var a =
                    from sj in subjectsList
                    where sj.SubjectName == element
                    select sj;
                foreach (var chosenElement in a)
                {
                    chosenSubjects.Add(chosenElement);
                }
            }
            

           
        }

      

        private void pbAddSubject_Click(object sender, EventArgs e)
        {
            AddSubjects();
        }
        public void AddSubjects()
        {
            bool IsOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frmAddSubjects")
                {
                    IsOpen = true;
                    form.BringToFront();
                    break;
                }
            }
            if (IsOpen == false)
            {
                frmAddSubjects addSubjects = new frmAddSubjects();
                addSubjects.Show();
                addSubjects.BringToFront();

            }
        }
    }
}
