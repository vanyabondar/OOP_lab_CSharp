using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ivan", "Bondar", new DateTime(1999, 10, 9), Student.Education.Bachelor, "IP-72", 1007203);
            Console.WriteLine(student.ToString());
            Examination[] exam_list = {new Examination(3, "Psychology", "Kononec M. V.", 100, true, new DateTime(2018, 12, 18)),
                new Examination(3, "Philosophy", "Kycuk K. A.", 97, true, new DateTime(2018, 12, 28)),
                new Examination(3, "Object-Oriented Programming", "Mykha I. P.", 88, true, new DateTime(2019, 1, 9)),
                new Examination(3, "Callisthenics", "Ivanov I. I.", 80, false, new DateTime(2018, 12, 19))
            };
            student.AddExams(exam_list);
            student.PrintFullInfo();
            CompleteTask(3);
            CompleteTask(4);
            CompleteTask(8);
            CompleteTask(11);

            Console.ReadKey();
            

        }
        public static void CompleteTask(int taskCount)
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Task " + taskCount);
            switch (taskCount)
            {
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                case 8:
                    Task8();
                    break;
                case 11:
                    Task11();
                    break;
            }
        }
        static void Task3()
        {
            Examination examination1 = new Examination();
            Console.WriteLine(examination1.ToString());
            Console.WriteLine("National Scale Name: " + examination1.NationalScaleName());
            Console.WriteLine("Ects Scale Name: " + examination1.EctsScaleName());

            Examination examination2 = new Examination(3, "Philosophy", "Kycuk K. A.", 97, true, new DateTime(2018, 12, 28));
            Console.WriteLine(examination2.ToString());
            Console.WriteLine("National Scale Name: " + examination2.NationalScaleName());
            Console.WriteLine("Ects Scale Name: " + examination2.EctsScaleName());

            Examination examination3 = new Examination(3, "Object-Oriented Programming", "Mykha I. P.", 88, true, new DateTime(2019, 1, 9));
            Console.WriteLine(examination3.ToString());
            Console.WriteLine("National Scale Name: " + examination3.NationalScaleName());
            Console.WriteLine("Ects Scale Name: " + examination3.EctsScaleName());

            Examination examination4 = new Examination(3, "Callisthenics", "Ivanov I. I.", 80, false, new DateTime(2018, 12, 19));
            Console.WriteLine(examination4.ToString());
            Console.WriteLine("National Scale Name: " + examination4.NationalScaleName());
            Console.WriteLine("Ects Scale Name: " + examination4.EctsScaleName());

        }

        static void Task4()
        {
            bool flag = false;
            while (!flag)
            {
                try
                {
                    Console.Write("Введiть номер залiковки: ");
                    long n = Convert.ToInt64(Console.ReadLine());
                    Student student = new Student();
                    student.BookAmount = n;
                    flag = true;
                    student.PrintFullInfo();
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }
        static void Task8()
        {
            Student student = new Student("Ivan", "Bondar", new DateTime(1999, 10, 9), Student.Education.Bachelor, "IP-72", 1007203);
            Console.WriteLine(student.ToString());
            Examination[] exam_list = {new Examination(3, "Psychology", "Kononec M. V.", 100, true, new DateTime(2018, 12, 18)),
                new Examination(3, "Philosophy", "Kycuk K. A.", 97, true, new DateTime(2018, 12, 28)),
                new Examination(3, "Object-Oriented Programming", "Mykha I. P.", 88, true, new DateTime(2019, 1, 9)),
                new Examination(3, "Callisthenics", "Ivanov I. I.", 80, false, new DateTime(2018, 12, 19))
            };
            student.AddExams(exam_list);
            Console.WriteLine("All examination:");
            for (int i = 0; i < exam_list.Length; i++)
            {
                Console.WriteLine(exam_list[i].ToString());
            }

            Console.WriteLine("Only differentiated examination:");
            foreach (Examination ex in student)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        static void Task11()
        {
            Person person1 = new Person();
            person1.PrintFullInfo();
            Console.WriteLine(person1.HowOld() + " years");

            Person person2 = new Person("Ivan", "Ivanov", new DateTime(1985,1,20));
            person2.PrintFullInfo();
            Console.WriteLine(person2.HowOld() + " years");
        }

    }

}

