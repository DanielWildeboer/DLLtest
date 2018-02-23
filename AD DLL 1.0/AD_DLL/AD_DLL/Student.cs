using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_DLL
{
    public class Student : IComparable
    {
        private string studentName;
        private int studentNumber;

        public Student(int number, string name)
        {
            studentName = name;
            studentNumber = number;
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Student otherStudent = obj as Student;
            if (otherStudent != null)
                return this.studentNumber.CompareTo(otherStudent.studentNumber);
            else
                throw new ArgumentException("Object is not a Student!");
        }

        public string Name
        { get { return studentName; } }

        public int Number
        { get { return studentNumber; } }
    }
}

