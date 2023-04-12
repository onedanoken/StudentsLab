using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLab
{
    [Serializable]
    public class GradStudent : Student
    {

        public GradStudent() : base()
        {
        }
        public GradStudent(string firstName, string surname, string faculty, string education) : base(firstName, surname, faculty) 
        {
            this.Education = education;
        }
    }
}
