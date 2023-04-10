using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLab
{
    class Student
    {
        protected string firstName;
        protected string surname;
        protected string faculty;

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string Surname
        {
            get { return this.surname; }
            set { this.surname = value; }
        }

        public string Faculty
        {
            get { return this.faculty; }
            set { this.faculty = value; }
        }

        public Student(string firstName, string surname, string faculty)
        {
            this.firstName = firstName;
            this.surname = surname;
            this.faculty = faculty;
        }
    }
}
