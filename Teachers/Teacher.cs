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
        private string grades;
        public string Grades
        {
            get { return grades; }
            set { grades = value; }
        }

        private string subject;
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        private string contract;
        public string Contract
        {
            get { return contract; }
            set { contract = value; }
        }

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
