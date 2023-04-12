using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLab
{
    [Serializable]
    public class WorkWithStudents
    {
        public List<Student> students; // массив студентов

        public List<Student> Students 
        { 
            get { return this.students; } 
            set { this.students = value; } 
        }

        public WorkWithStudents()
        {
            students = new List<Student>();
        }

        public List<Student> GetStudents() 
        { 
            return this.students; 
        }

        public List<Student> AddStudent(GradStudent student) 
        { 
            students.Add(student);
            return this.students;
        }

        public List<Student> AddStudent(Bachelor student)
        {
            students.Add(student);
            return this.students;
        }

        public List<Student> RemoveStudent(GradStudent student) 
        { 
            students.Remove(student);
            return this.students;
        }

        public List<Student> RemoveStudent(Bachelor student)
        {
            students.Remove(student);
            return this.students;
        }
    }
}
