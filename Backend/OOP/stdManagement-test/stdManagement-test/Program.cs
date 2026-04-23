using stdManagement_test.Models;

namespace stdManagement_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Courses> courses = new List<Courses>();
            Courses[] courses = new Courses[3]
            {
                new Courses(1,"Js","Ahmad"),
                new Courses(2,"C#","Rahma"),
                new Courses(3,"PHP","Leen")
            };

            Student[] stds = new Student[2]
            {
                new Student(1,"Leen"),
                new Student(2,"Lujain")
            };

            stds[0].enrollCourse(courses[0]);
            stds[1].enrollCourse(courses[1]);
            stds[1].enrollCourse(courses[2]);

            //Console.WriteLine(stds[0]);
            //Console.WriteLine(stds[1]);

            Console.WriteLine("\n------------school--------------\n");

            School h1 = new School();
            h1.addStd(stds[0]);
            h1.addStd(stds[1]);
            h1.addCourse(courses[0]);
            h1.addCourse(courses[1]);
            Console.WriteLine(string.Join(" , ",h1));

        }
    }
}
