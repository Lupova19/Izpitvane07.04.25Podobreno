using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teachers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Vavedi broj uchiteli: ");
                int n = int.Parse(Console.ReadLine());

                List<Teacher> listTeachers = new List<Teacher>();

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Vavedi danni za uchitel {i + 1}:");
                    var danni = Console.ReadLine().Split();

                    Teacher teacher = new Teacher(danni[0], danni[1], danni[2], danni[3], danni[4]);
                    listTeachers.Add(teacher);
                }

                Console.WriteLine("Vsichki vavedeni uchiteli:");
                foreach (var item in listTeachers)
                {
                    Console.WriteLine(item.DisplayTeachers());
                }

                Console.Write("Vavedi ime na uchitel: ");
                string nameOfTeacher = Console.ReadLine();
                var foundTeacher = listTeachers.FirstOrDefault(x => x.Name == nameOfTeacher);
                Console.WriteLine(foundTeacher.DisplayTeachers());

                Console.Write("Vavedi predmet: ");
                string nameSubject = Console.ReadLine();
                var count = listTeachers.Count(x => x.Subject == nameSubject);
                Console.WriteLine($"Broj uchiteli po {nameSubject}: {count}");

                var smallestGrade = listTeachers.OrderBy(x => x.Grades).FirstOrDefault();
                Console.WriteLine("Uchitel prepodavasht na naj-malkiqt klas:");
                Console.WriteLine(smallestGrade.DisplayTeachers());

                using (StreamWriter writer = new StreamWriter("teachers.txt"))
                {
                    foreach (var item in listTeachers)
                    {
                        writer.WriteLine(item.DisplayTeachers());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
