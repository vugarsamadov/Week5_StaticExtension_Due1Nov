using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_StaticExtension_Due1Nov.Models
{
    internal class Student
    {
        // Group No requirements
        public const int UpperAlphaCount = 1;
        public const int NumCount = 3;

        private static int _id;

        public int Id { get; init; }
        public string FullName { get; init; }

        public string GroupNo { get; init; }
        public int Age { get; init; }

        public Student(string fullName, string groupNo, int age)
        {
            _id += 1;
            Id = _id;
            FullName = fullName;
            GroupNo = groupNo;  
            Age = age;
        }
    }
}
