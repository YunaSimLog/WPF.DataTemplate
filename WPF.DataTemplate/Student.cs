using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace WPF.DataTemplate
{
    public class Student
    {
        public string Name { get; set; } = "";
        public string Gender { get; set; } = "";

        public string BirthDay { get; set; } = "";
        public string Address { get; set; } = "";

        public override string ToString()
        {
            return $"Name: {Name}, Gender: {Gender}, BirthDay: {BirthDay}, Address: {Address}";
        }

        public static List<Student> Students => new()
        {
            new Student {Name = "심유나", Gender = "여자", BirthDay = "1992-11-19", Address  = "수원"},
            new Student {Name = "이가영", Gender = "여자", BirthDay = "1992-11-05", Address  = "수원"},
            new Student {Name = "김철수", Gender = "남자", BirthDay = "1997-01-01", Address  = "인천"},
        };
    }
}
