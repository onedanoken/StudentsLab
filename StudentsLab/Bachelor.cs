using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLab
{
    [Serializable]
    public class Bachelor : Student
    {
        public Bachelor() : base() {}
        public Bachelor(string firstName, string surname, string faculty) : base(firstName, surname, faculty) { }
    }
}
