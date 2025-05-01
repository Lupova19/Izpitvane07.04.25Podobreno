using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Teachers
{
   public class Teacher : TeachersInformation
    {
        public string Grades { get; set; }
        public string Subject { get; set; }
        public string Contract { get; set; }

        public Teacher(string name, string school, string grades, string subject, string contract): base(name, school)
        {
            Grades = grades;
            Subject = subject;
            Contract = contract;
        }

        public override string DisplayTeachers()
        {
            return $"Име: {Name}, Училище: {School}, Клас: {Grades}, Предмет: {Subject}, Договор: {Contract}";
        }
    }
}
