using School.Forms.SubjectsForms;
using SchoolBL;
using SchoolModel;
using SchoolDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School.Forms.CoursesForms
{
    public partial class frmUpdateCourses : Form
    {
      
      private  bool  _isCourseUpdated = false;
      private bool _isCourseSubjectUpdated = false;
        private Courses _course;
      
         CoursesSubjects dgvCoursesSubjects = new CoursesSubjects();
         CoursesBL coursesBL = new CoursesBL();
         CoursesSubjectsBL coursesSubjectsBL = new CoursesSubjectsBL();
         Courses _course2 = new Courses();
         SubjectsBL subjectsBL = new SubjectsBL();

         List<CoursesSubjects> dgvCoursesSubjectsList = new List<CoursesSubjects>();
         List<CoursesSubjects> dbCoursesSubjectsList = new List<CoursesSubjects>();
     
         List<Subjects> subjectsList = new List<Subjects>();
         List<Subjects> subjectsNames = new List<Subjects>();
        private bool _isCourseNameValid;
        private bool _isCourseDescriptionValid;
        private bool _isClbSubjectsValid = false;
       

        public CoursesSubjects CoursesSubjects
        {
            set { dgvCoursesSubjects = value; }
        }
        public bool IsCourseUpdated
        {
            get { return _isCourseUpdated; }
        }
       public Courses Course
        {
            set { _course = value; }
        }
        public Courses Course2
        {
            set { _course2 = value; }
        }
        public frmUpdateCourses()
        {
            InitializeComponent();
            Init();
            LoadSubjects();
         


        }
         private void Init()
        {
            coursesBindingSource.DataSource = _course2;
            subjectsList = subjectsBL.SelectAllSubjects();
         
            
        }
         public List<CoursesSubjects> LoaddgvCoursesSubjectsList(List<CoursesSubjects> DbCoursesSubjectsList, List<Subjects> SubjectsNamesList)
        {
            List<CoursesSubjects> coursesSubjects = new List<CoursesSubjects>();
            int counter = 0;
            foreach (var element in DbCoursesSubjectsList)
            {
                element.SubjectsId = SubjectsNamesList[counter].SubjectId;

                coursesSubjects.Add(element);
                counter++;


            }
            return coursesSubjects;
        }
       private List<Subjects> LoadSubjectNames()
       {
            List<Subjects> subjectsNames2 = new List<Subjects>();
            foreach (var element in clbSubjects.CheckedItems)
            {

               foreach(var element2 in subjectsList)
                {
                    if(element.ToString()==element2.SubjectName)
                    {
                        subjectsNames2.Add(element2);
                    }
               }
            }
            return subjectsNames2;
       }

        private void LoadSubjects()
        {
            
            foreach (var element in subjectsList)
            {
                clbSubjects.Items.Add(element.SubjectName);
            }
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
       
        private void pbAddSubject_Click(object sender, EventArgs e)
        {
            AddSubjects();
        }

     
        public bool ValidateClbSubjects(CheckedListBox checkedListBox)
        {
            int a = subjectsNames.Count;
            int b = dbCoursesSubjectsList.Count;
            bool _isClbSubjectsValid = false;
            if ( a>=b)
            {
                _isClbSubjectsValid = true;
            }
            else if(a<b)
            {
                _isClbSubjectsValid = false;
            }
            return _isClbSubjectsValid;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
          ValidateEverything();
            UpdateCourse();
          
            
        }

        public void ValidateEverything()
        {

            _isCourseNameValid = coursesBL.ValidateCoursename(coursesNameTextBox.Text);
            _isCourseDescriptionValid = coursesBL.ValidateCourseDescription(coursesDescriptionTextBox.Text);
           
            
            

            if (_isCourseNameValid == false)
            {
                errorProvider1.SetError(coursesNameTextBox, "Course name is not valid");
            }
            if (_isCourseDescriptionValid == false)
            {
                errorProvider1.SetError(coursesDescriptionTextBox, "Course Description is not valid");
            }
            
           

        }
        public void UpdateCourse()
        {
            int counter = 0;
            ValidateEverything();
            Init();

            _isClbSubjectsValid = ValidateClbSubjects(clbSubjects);
            if (_isCourseNameValid==true&& _isCourseDescriptionValid==true)
            {
                errorProvider1.Clear();
              
                subjectsNames = LoadSubjectNames();
                dbCoursesSubjectsList = coursesSubjectsBL.SelectCoursesSubjectsById(dgvCoursesSubjects.CoursesId);
                _isClbSubjectsValid = ValidateClbSubjects(clbSubjects);
                if (_isClbSubjectsValid == true && _isCourseNameValid == true && _isCourseDescriptionValid == true)
                {
                    _isCourseUpdated = coursesBL.UpdateCourse(_course2, _course.CoursesID);
                    dgvCoursesSubjectsList = LoaddgvCoursesSubjectsList(dbCoursesSubjectsList, subjectsNames);
                    this.Close();
                }
               



                foreach (var element in dgvCoursesSubjectsList)
                {
                    _isCourseSubjectUpdated = coursesSubjectsBL.UpdateCoursesSubjects(element);
                    MessageBox.Show($"CourseSubject is updated {counter++}");
                }


                if (_isCourseUpdated == true)
                {
                    MessageBox.Show("Course Is Updated");

                }
                else
                {
                    MessageBox.Show("Ops something went wrong course");
                }
                if (_isCourseSubjectUpdated == true)
                {
                    MessageBox.Show("CourseSubject Is Updated");

                }
                else
                {
                    MessageBox.Show("Ops something went wrong course subject5");
                }
                if (_isClbSubjectsValid == false)
                {
                    errorProvider1.SetError(clbSubjects, $"You must chose at least {dgvCoursesSubjectsList.Count()} Subject");
                    MessageBox.Show("Subject is not Valid");
                }






                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _isClbSubjectsValid = ValidateClbSubjects(clbSubjects);
        }

        private void frmUpdateCourses_Load(object sender, EventArgs e)
        {
            coursesBindingSource.DataSource = _course2;
           
          
        }
    }
}
