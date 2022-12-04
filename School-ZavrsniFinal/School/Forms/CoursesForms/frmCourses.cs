using SchoolBL;
using SchoolModel;
using System;
using System.Collections;
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
    public partial class frmCourses : Form
    {
        private string _filter;
        List<CoursesSubjects> dgvCoursesSubjectsList = new List<CoursesSubjects>();
        bool  _isCourseUpdated = false;
        CoursesBL coursesBL = new CoursesBL();
        CoursesSubjectsBL coursesSubjectsBL = new CoursesSubjectsBL();
        SubjectsBL subjectsBL = new SubjectsBL();
        List<Courses> coursesList = new List<Courses>();
        List<CoursesSubjects> coursesSubjectsList = new List<CoursesSubjects>();
        List<Subjects> subjectsList = new List<Subjects>();
        public frmCourses()
        {
            InitializeComponent();
         
            Init();
        }

        private void Init()
        {
            LoadLists();
            mgCCSS.DataSource = LoadCCSS();
            if(LoadCCSS().Count>0)
            {
               
                mgCCSS.Columns[0].HeaderText = "Course";
           mgCCSS.Columns[1].HeaderText = "Course description";
            mgCCSS.Columns[3].HeaderText = "Subject";
            mgCCSS.Columns[4].HeaderText = "Subject description";
                mgCCSS.Columns[2].Visible = false;
                mgCCSS.Columns[5].Visible = false;
                mgCCSS.Columns[6].Visible = false;

            }
           
            


        }

        private void LoadLists()
        {
            coursesList.Clear();
            coursesSubjectsList.Clear();
            subjectsList.Clear();
            coursesList = coursesBL.SelectAllCourses();
            coursesSubjectsList = coursesSubjectsBL.SelectAllCourses();
            subjectsList = subjectsBL.SelectAllSubjects();
        }

        private void pbAddCourse_Click(object sender, EventArgs e)
        {
            
            AddCourses();
            
        }
        public void AddCourses()
        {
            bool IsOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frmAddCourses")
                {
                    IsOpen = true;
                    form.BringToFront();
                    break;
                }
            }
            if (IsOpen == false)
            {
                frmAddCourses addCourse = new frmAddCourses();
                addCourse.ShowDialog();
                Init();
                addCourse.BringToFront();


            }
        }
        public void FillgvCoursesSubjects()
        {


        }
        public ArrayList LoadCCSS()
        {
            ArrayList CCSSList = new ArrayList();

            var CCSS =
             from C in coursesList
             join CS in coursesSubjectsList on C.CoursesID equals CS.CoursesId
             select new { C.CoursesID,C.CoursesName,C.CoursesDescription,CS.CoursesSubjectsId,CS.CoursesId,CS.SubjectsId } into part1
             join S in subjectsList on part1.SubjectsId equals S.SubjectId
             select new {part1.CoursesName,part1.CoursesDescription,part1.CoursesID, S.SubjectName,S.SubjectDescription,S.SubjectId,part1.CoursesSubjectsId };

            foreach (var element in CCSS)
            {
                CCSSList.Add(element);
            }


          
            return CCSSList;
            

        }
        public ArrayList FilterByCourseName(string textbox)
        {
            ArrayList CCSSList = new ArrayList();

            var CCSS =
             from C in coursesList
          //   where C.CoursesName==textbox
             where C.CoursesName.ToLower().Contains( textbox.ToLower())
             join CS in coursesSubjectsList on C.CoursesID equals CS.CoursesId
             select new { C.CoursesID, C.CoursesName, C.CoursesDescription, CS.CoursesSubjectsId, CS.CoursesId, CS.SubjectsId } into part1
             join S in subjectsList on part1.SubjectsId equals S.SubjectId
             select new { part1.CoursesName, part1.CoursesDescription, part1.CoursesID, S.SubjectName, S.SubjectDescription, S.SubjectId, part1.CoursesSubjectsId };

            foreach (var element in CCSS)
            {
                
                 CCSSList.Add(element);
                
                
            }



            return CCSSList;


        }

        private void frmCourses_Load(object sender, EventArgs e)
        {
          
        }

        private void pbUpdateCourse_Click(object sender, EventArgs e)
        {
            Courses courses122 = new Courses();
            courses122= CourseFromDGV(mgCCSS);

            OpenUpdateCourse();
        }
        public void OpenUpdateCourse()
        {
            bool IsOpen = false;
            if(CourseFromDGV(mgCCSS).CoursesID == 0)
            {
                MessageBox.Show("Course list is empty");
                
            }
            else
            {
                foreach (Form form in Application.OpenForms)
                {
                if (form.Name == "frmUpdateCorses")
                {
                    IsOpen = true;
                    form.BringToFront();
                    break;
                }
                }
              if (IsOpen == false)
              {
                frmUpdateCourses updateCorses = new frmUpdateCourses();
                updateCorses.Course = CourseFromDGV(mgCCSS);
                updateCorses.CoursesSubjects = CoursesSubjectsFromDGV(mgCCSS);
                updateCorses.Course2 = CourseFromDGV(mgCCSS);
                updateCorses.ShowDialog();
                updateCorses.BringToFront();
                _isCourseUpdated = updateCorses.IsCourseUpdated;

                  RefreshCountryDGV();

            }

            }
            
            
        }

        private void RefreshCountryDGV()
        {

            LoadmgCCSS();
        }

        private Courses CourseFromDGV(DataGridView dataGridview)
        { 
            Courses course = new Courses();
            try
            {
           
            course.CoursesID = Int32.Parse(dataGridview.SelectedRows[0].Cells["CoursesID"].Value.ToString());
            course.CoursesName = dataGridview.SelectedRows[0].Cells["CoursesName"].Value.ToString();
            course.CoursesDescription = dataGridview.SelectedRows[0].Cells["CoursesDescription"].Value.ToString();
            return course;
            }
            catch
            {
                course.CoursesID = 0;
                course.CoursesName = null;
                course.CoursesDescription = null;
            }
            return course;
        }

        private CoursesSubjects CoursesSubjectsFromDGV(DataGridView dataGridview)
        {
            CoursesSubjects CoursesSubjects = new CoursesSubjects();
            
            CoursesSubjects.CoursesSubjectsId = Int32.Parse(dataGridview.SelectedRows[0].Cells["CoursesSubjectsId"].Value.ToString());
            CoursesSubjects.CoursesId = Int32.Parse(dataGridview.SelectedRows[0].Cells["CoursesId"].Value.ToString());
            CoursesSubjects.SubjectsId= Int32.Parse(dataGridview.SelectedRows[0].Cells["SubjectId"].Value.ToString());
            return CoursesSubjects;
        }

        private Subjects SubjectFromDGV(DataGridView dataGridview)
        {
            Subjects subject = new Subjects();
            try
            {
             subject.SubjectId = Int32.Parse(dataGridview.SelectedRows[0].Cells["SubjectId"].Value.ToString());
            subject.SubjectName = dataGridview.SelectedRows[0].Cells["SubjectName"].Value.ToString();
            subject.SubjectDescription = dataGridview.SelectedRows[0].Cells["SubjectDescription"].Value.ToString();
            }
            
            catch
            {
                subject.SubjectId = 0;
                subject.SubjectName = null;
                subject.SubjectDescription = null;
            }
            return subject;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadmgCCSS();
           
        }

        private void LoadmgCCSS()
        {
            LoadLists();
            mgCCSS.DataSource = LoadCCSS();
        }

        private void pbDeleteCourse_Click(object sender, EventArgs e)
        {
            if(CourseFromDGV(mgCCSS).CoursesID>0)
            {
              DeleteCourse();
            }
            else
            {
                MessageBox.Show("Course list is empty");
            }
            
        }
        private void DeleteCourse()
        {
            int a = CourseFromDGV(mgCCSS).CoursesID;
            int b = SubjectFromDGV(mgCCSS).SubjectId;
            if(CourseFromDGV(mgCCSS).CoursesID==0)
            {
                MessageBox.Show("Course list is empty");
            }
            else
            {

           
            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to delete Course", "Delete Course?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //  bool CourseIsDeleted = coursesBL.DeleteCourse(CourseFromDGV(mgCCSS).CoursesID, SubjectFromDGV(mgCCSS).SubjectId);
                bool CourseIsDeleted = coursesBL.DeleteCourse(CourseFromDGV(mgCCSS).CoursesID);
               
                if (CourseIsDeleted == true)
                {

                    MessageBox.Show("Course is deleted");
                }
                else
                {
                    MessageBox.Show("Ops something went wrong");
                }
                    LoadmgCCSS();
                }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            }
        }

        private void pbSearchbtn_Click(object sender, EventArgs e)
        {
            


            switch (cbFilter.SelectedIndex)
            {
                case 0:
                    _filter = tbSearch.Text;
                   mgCCSS.DataSource= FilterByCourseName(tbSearch.Text);
                    break;
               
                case 1:
                    LoadmgCCSS();
                    break;

            }
        }

        private void mgCCSS_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show($"Course description:  {CourseFromDGV(mgCCSS).CoursesDescription}    {Environment.NewLine}     Subject decription:  {SubjectFromDGV(mgCCSS).SubjectDescription}");
        }
    }
}

