using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackermeDB
{
    public class Course
    {
        public string CourseName { get; set; }
        public String CourseId { get; set; } 
        public DateTime StartingDate { get; set; }
        public int NumOfLessons { get; set; }
        public static List<Student> StudentsList { get; set; } = new List<Student>();

        public Course(string courseName, DateTime startingDate, int numOfLessons)
        {
            CourseName = courseName;
            CourseId = CourseName + StartingDate.Date;
            StartingDate = startingDate;
            NumOfLessons = numOfLessons;
        }
    }
}
