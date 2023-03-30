using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_StudentManagement
{
    internal class Student
    {

        public Student() { }

        public string Name { get; set; }
        public string StudentCode { get; set; }
        public string Address { get; set; }

        public string BrithDay { get; set; }
        public double MathScore { get; set; }

        public bool Gender { get; set; }

        public Student( string Name, string StudentCode,
            string Address, string BirthDay,bool Gender, double MathScore )
        {

            this.Name = Name;
            this.StudentCode = StudentCode;
            this.Address = Address;
            this.BrithDay = BirthDay;
            this.MathScore = MathScore;
            this.Gender = Gender;
        }


    }
}
