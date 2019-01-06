using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Examination: IMarkName
    {
        protected int semester;
        protected string subjectName;
        protected string teacherName;
        protected int mark;
        protected bool isDifferentiated;
        protected DateTime dateExamination;
        public Examination()
        {
            semester = 1;
            subjectName = "Math";
            teacherName = "Petrov P. P.";
            mark = 60;
            isDifferentiated = true;
            dateExamination = new DateTime(2019, 1, 1);
        }

        public Examination(int semester, string subjectName, string teacherName, int mark, bool isDifferentiated, DateTime dateExamination)
        {
            this.semester = semester;
            this.subjectName = subjectName;
            this.teacherName = teacherName;
            this.mark = mark;
            this.isDifferentiated = isDifferentiated;
            this.dateExamination = dateExamination;
        }

        public override string ToString()
        {
            return $"{semester} - {subjectName}, {teacherName}, {mark}.";
        }

        public int Semester { get { return semester; } }
        public string SubjectName { get { return subjectName; } }
        public string TeacherName { get { return teacherName; } }
        public int Mark { get { return mark; } }
        public bool IsDifferentiated {get { return isDifferentiated;} }
        public DateTime DateExamination { get; set; }

        public string NationalScaleName()
        {
            if (mark > 100 || mark < 0)
            {
                return "Uncorrect mark";
            }

            if (mark >= 95)
            {
                return "Perfectly";
            }
            else if (mark >= 85)
            {
                return "Very good";
            }
            else if (mark >= 75)
            {
                return "Good";
            }
            else if (mark >= 65)
            {
                return "Satisfactorily";
            }
            else if (mark >= 60)
            {
                return "Enough";
            }
            else if (mark >= 35)
            {
                return "Unsatisfactory (with the possibility re - assembly)";
            }
            else
            {
                return "Unsatisfactory (with obligatoryrepeat course)";
            }
        }

        public string EctsScaleName()
        {
            if (mark > 100 || mark < 0)
            {
                return "Uncorrect mark";
            }

            if (mark >= 95)
            {
                return "A";
            }
            else if (mark >= 85)
            {
                return "B";
            }
            else if (mark >= 75)
            {
                return "C";
            }
            else if (mark >= 65)
            {
                return "D";
            }
            else if (mark >= 60)
            {
                return "E";
            }
            else if (mark >= 35)
            {
                return "Fx";
            }
            else
            {
                return "F";
            }
        }
    }
}
