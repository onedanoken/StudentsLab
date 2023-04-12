using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StudentsLab
{
    [Serializable]
    [XmlInclude(typeof(GradStudent))]
    [XmlInclude(typeof(Bachelor))]
    public abstract class Student
    {
        public string firstName;
        public string surname;
        public string faculty;
        public string education;

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

        public string Education
        {
            get { return this.education; }
            set { this.education = value; }
        }
        public Student()
        {
            this.firstName = null;
            this.surname = null;
            this.faculty = null;
        }

        public Student(string firstName, string surname, string faculty)
        {
            this.firstName = firstName;
            this.surname = surname;
            this.faculty = faculty;
        }
    }
}
