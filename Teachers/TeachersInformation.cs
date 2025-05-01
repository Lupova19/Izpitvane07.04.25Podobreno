using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teachers
{
    public abstract class TeachersInformation : IDisplayTeachers
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Imeto trqbva da ima pone 2 bukvi!");
                }
               this.name = value;
            }
        }

        public string School { get; set; }

        protected TeachersInformation(string name, string school)
        {
            Name = name;
            School = school;
        }

        public abstract string DisplayTeachers();
    }
}
