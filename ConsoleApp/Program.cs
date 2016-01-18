using FactoryMethod.Day1;
using FactoryMethod.Day4;
using FactoryMethod.Example1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowDay1();
            //ShowDay4();

            ShowExample1();
        }

        private static void ShowExample1()
        {
            ICarFactory factory = new BmwCarFactory();
            var car = factory.CreateCar("3 Series");
            Console.WriteLine(car.ShowDescription());

            
        }

        private static void ShowDay4()
        {
            var args = new string[] { "k" };
            AbstractCourseFactory courseFactory = new AdvancedOnlineCourseFactory();
            courseFactory.CreateCourse("N");

        }

        private static void ShowDay1()
        {
            var args = new string[] { "k" };
            AbstractCourse course =  null;
            if(string.Equals("N",args[0]))
            {
                course = new NetCourse();
            }
            else
            {
                course = new JavaCourse();
            }

            Console.WriteLine(course.CreateCourseMaterial());
            Console.WriteLine(course.CreateSchedule());
        }
    }
}
