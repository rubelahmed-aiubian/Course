using System;

namespace Cour
{
    class Program
    {
        static void Main(string[] args)
        {
            string cName, cCode;
            int cCredit;
            Console.WriteLine("\n================Course Program==================\n");
            Console.WriteLine("Enter Course Name: "); 
            cName = Console.ReadLine();
            Console.WriteLine("Enter Course Code: ");
            cCode = Console.ReadLine();
            Console.WriteLine("Enter Course Credit: ");
            cCredit = Convert.ToInt16(Console.ReadLine());

            Course myCourse = new Course(cName,cCode,cCredit);

            myCourse.ShowCourseInfo();
        }
    }
}
