using SchoolModel;
using SchoolDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBL
{
    public class SubjectsBL
    {
        public  bool DeleteSubject(int SubjectId)
        {
            bool SubjectIsDeleted = false;
            SubjectIsDeleted = SubjectsDAL.DeleteSubject(SubjectId);
            return SubjectIsDeleted;
        }
            public  Subjects SelectSubjectByName(Subjects subject)
        {
            Subjects subjects = new Subjects();
            subjects = SubjectsDAL.SelectSubjectByName(subject);
            return subjects;
        }
            public List<Subjects> SelectAllSubjects()
        {
            List<Subjects> subjects = new List<Subjects>();
            subjects = SubjectsDAL.SelectAllSubjects();
            return subjects;
        }
        public  bool SaveSubject(Subjects subject)
        {
            bool IsSubjectsSaved = false;
            IsSubjectsSaved = SubjectsDAL.SaveSubject(subject);
            return IsSubjectsSaved;
        }
        public  bool ValidateSubjectName(Subjects subject)
        {
            bool IsUnique = String.IsNullOrEmpty(SelectSubjectByName(subject).SubjectName);
            bool isNameValid = false;
            if (String.IsNullOrEmpty(subject.SubjectName) == false && IsUnique == true)
            {
                isNameValid = true;
            }
            else
            {
                isNameValid = false;
            }
            return isNameValid;
        }
        public bool ValidateSubjectName2(Subjects subject)
        {
           
            bool isNameValid = false;
            if (String.IsNullOrEmpty(subject.SubjectName) == false)
            {
                isNameValid = true;
            }
            else
            {
                isNameValid = false;
            }
            return isNameValid;
        }
        public bool ValidateSubjectDescription(Subjects subject)
        {
            bool isDescriptionValid = false;
            if (String.IsNullOrEmpty(subject.SubjectDescription) == false)
            {
                isDescriptionValid = true;
            }
            else
            {
                isDescriptionValid = false;
            }
            return isDescriptionValid;
        }
        public List<Subjects> FilterBySubjectName(List<Subjects> oldsubjectList, string TextBox)
        {

            List<Subjects> newSubjectList = new List<Subjects>();
            foreach (var element in oldsubjectList)
            {
                if (element.SubjectName.ToLower().Contains(TextBox.ToLower())==true)
                {
                    newSubjectList.Add(element);
                }
               


            }
            return newSubjectList;

        }
        public  bool UpdateSubject(Subjects subject, int SubjectIdfromGird)
        {
            bool IsCourseUpdated = false;
            IsCourseUpdated = SubjectsDAL.UpdateSubject(subject, SubjectIdfromGird);
           return IsCourseUpdated;
        }
    }
}
