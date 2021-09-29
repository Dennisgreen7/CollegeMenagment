using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackermeDB
{
    public static class MyDB
    {
        public static BindingList<Student> StudentsList { get; set; } = new BindingList<Student>();
        //public static List<Student> StudentsList { get; set; } = new List<Student>();
        public static List<Course> CoursesList { get; set; } = new List<Course>();
    }
}
