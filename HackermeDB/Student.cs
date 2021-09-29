using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackermeDB
{
    public class Student
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string DateOfBirth { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public List<string> CoursesList = new List<string>();
        public string Course {
            get
            {
                string c = " ";
                for (int i = 0; i < CoursesList.Count; i++)
                {
                    if(i== CoursesList.Count-1 || CoursesList.Count == 1)
                    {
                        c += CoursesList[i];
                    }
                    else
                    {
                        c += CoursesList[i] + ", ";
                    } 
                }
                return c;
            } } 
        public string Paid { get; set; } = "0";

        public Student(string id, string firstName, string lastName, string phoneNumber, string dOB, string city, string email, List<string> coursesList)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            DateOfBirth = dOB;
            City = city;
            Email = email;
            CoursesList = coursesList;
        }


        public Student(string id, string firstName, string lastName, string phoneNumber, string dOB, string city, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            DateOfBirth = dOB;
            City = city;
            Email = email;
        }

        //public DateTime Created { get; set; }
        //public DateTime Updated { get; set; }
        //public int UserCureatedId { get; set; }
        //public int UserUpdatedId { get; set; }
    }
}
