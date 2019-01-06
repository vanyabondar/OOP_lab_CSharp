using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Student : Person
    {
        public enum Education { Master, Bachelor, SecondEducation, PhD };
        protected Education levelOfQualification;
        protected string groupName;
        protected long bookAmount;
        protected List<Examination> doneExaminations;
        public Student():base()
        {
            levelOfQualification = Education.Bachelor;
            groupName = "AB-12";
            bookAmount = 1000000;
            doneExaminations = new List<Examination>();

        }

        public Student(string name, string surname, DateTime bornDate, Education levelOfQualification, string groupName, int bookAmount):base(name, surname, bornDate)
        {
            this.levelOfQualification = levelOfQualification;
            this.groupName = groupName;
            this.BookAmount = bookAmount;
            this.doneExaminations = new List<Examination>();

        }

        public float AverageMark
        {
            get
            {
                float sum = 0;
                foreach (Examination ex in doneExaminations)
                {
                    sum += ex.Mark;
                }
                return sum / doneExaminations.Count;
            }
        }
        public void AddExams(Examination[] examList)
        {
            doneExaminations.AddRange(examList);
        }
        public override string ToString()
        {
            return name + " " + surname + ", " + groupName;
        }
        public override void PrintFullInfo()
        {
            base.PrintFullInfo();
            Console.Write("Level of qualification: ");
            switch (levelOfQualification)
            {
                case Education.Master:
                    Console.WriteLine("Master");
                    break;
                case Education.Bachelor:
                    Console.WriteLine("Bachelor");
                    break;
                case Education.SecondEducation:
                    Console.WriteLine("Second education");
                    break;
                case Education.PhD:
                    Console.WriteLine("PhD");
                    break;
            }
            Console.WriteLine($"Group name: {groupName}");
            Console.WriteLine($"Record book number: {bookAmount}");
            Console.WriteLine("Done examinations: ");
            foreach (Examination exam in doneExaminations)
            {
                Console.WriteLine($"{exam.ToString()}");
            }
            if (doneExaminations.Count == 0)
            {
                Console.WriteLine("-");
            }
        }

        public long BookAmount
        {
            get
            {
                return bookAmount;
            }
            set
            {
                if (value <= 99999 || value > 99999999)
                {
                    throw new Exception("The number of the record book must belong to the interval [1000000; 99999999]");
                }
                else
                {
                    bookAmount = value;
                }
            }
        }

        public IEnumerator<Examination> GetEnumerator()
        {
            foreach (Examination exam in doneExaminations)
            {
                if (exam.IsDifferentiated == true)
                {
                    yield return exam;
                }
            }
        }

    }
}
