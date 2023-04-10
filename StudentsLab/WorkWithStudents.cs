using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLab
{
    class WorkWithStudents
    {
        public List<Student> AddStudent(Student student)
        {
            this.students.Add(student);
            return this.students;
        }

        public List<Student> RemoveStudent(Student student)
        {
            this.students.Remove(student);
            return this.students;
        }

    }
}
