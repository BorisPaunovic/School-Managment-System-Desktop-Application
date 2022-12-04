using SchoolModel;
using SchoolDAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBL
{
    public class CoursesSubjectsBL
    {
        public bool AddCourseSubject(int CoursesID, int SubjectsID)
        {
            bool IsCourseSubjectInserted = false;
            IsCourseSubjectInserted = CoursesSubjectsDAL.AddCourseSubject(CoursesID, SubjectsID);
            return IsCourseSubjectInserted;
        }
        public  List<CoursesSubjects> SelectAllCourses()
        {
            List<CoursesSubjects> CoursesSubjectsList = new List<CoursesSubjects>();
            CoursesSubjectsList = CoursesSubjectsDAL.SelectAllCoursesSubjects();
            return CoursesSubjectsList;
        }
        public List<CoursesSubjects> SelectCoursesSubjectsById(int CoursesId)
        {
            List<CoursesSubjects> coursesSubjectsList = new List<CoursesSubjects>();
            coursesSubjectsList = CoursesSubjectsDAL.SelectCoursesSubjectsById(CoursesId);
            return coursesSubjectsList;
        }
        public  bool UpdateCoursesSubjects(CoursesSubjects coursesSubject)
        {
            bool IsCourseSubjectUpdated = false;
            IsCourseSubjectUpdated = CoursesSubjectsDAL.UpdateCourseSubject(coursesSubject);
            return IsCourseSubjectUpdated;


        }
    }
}