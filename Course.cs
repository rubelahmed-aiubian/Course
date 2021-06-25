using System;
namespace Cour
{
    public class Course
    {
        private string courseName;
        string courseCode; 
        private int courseCredit;

        //empty constructor
        public Course()
        {

        }
        //valued constructor
        public Course(string cn, string cc, int cre)
        {
            Name = cn;
            Code = cc;
            Credit = cre;
        }

        //properties

        public string Name
        {
            get
            {
                return courseName;
            }
            set
            {
                courseName = value;
            }
        }
        public string Code
        {
            get
            {
                return courseCode;
            }
            set
            {
                courseCode = value;
            }
        }
        public int Credit
        {
            get
            {
                return courseCredit;
            }
            set
            {
                courseCredit = value;
            }
        }

        //show info
        public void ShowCourseInfo()
        {
            Console.WriteLine("\n----------------------Show Course Info----------------------\n");
            Console.WriteLine("Course Name: "+Name+"\nCourse Code: "+Code+"\n Course Credit: {0}",Credit);
            Console.WriteLine("\n----------------------End Program----------------------\n");
        }
    }
}