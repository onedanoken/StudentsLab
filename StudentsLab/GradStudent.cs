using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLab
{
    class GradStudent : Student
    {
        protected string education;

        public string Education
        {
            get { return this.education; }
            set { this.education = value; }
        }
        public GradStudent(string firstName, string surname, string faculty, string education) : base(firstName, surname, faculty) 
        {
            this.education = education;
        }
    }
}
