using System;

namespace CMS.UI.Models
{
    public class Student
    {
        public Student(int studentId, string firstName, string lastName, int courseId)
        {
            this.StudentId = studentId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.CourseId = courseId;

        }
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CourseId { get; set; }


    }
}
