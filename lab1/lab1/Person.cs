using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Person
    {
        protected string name;
        protected string surname;
        protected DateTime bornDate;
        public int BornDate
        {
            get
            {
                return bornDate.Year;
            }
            set
            {
                if (value <= DateTime.Now.Year && value > 1900)
                {
                    int day = bornDate.Day;
                    int month = bornDate.Month;
                    bornDate = new DateTime(value, month, day);
                }
            }
        }
        public Person()
        {
            name = "Petro";
            surname = "Petrov";
            bornDate = new DateTime(2000, 1, 1);
        }
        public Person(string name, string surname, DateTime bornDate)
        {
            this.name = name;
            this.surname = surname;
            this.bornDate = bornDate;
        }
        public virtual void PrintFullInfo()
        {
            Console.WriteLine("Name: " + name + '\n' + "Surname: " + surname + '\n' + "Born Date: " + bornDate.ToShortDateString());
        }
        public string Name { get { return name; } }
        public string Surname { get { return surname; } }

        public int HowOld()
        {
            DateTime dateNow = DateTime.Now;
            int year = dateNow.Year - bornDate.Year;
            if (dateNow.Month < bornDate.Month ||
                (dateNow.Month == bornDate.Month && dateNow.Day < bornDate.Day))
                year--;
            return year;
        }
    }
    
}
