using FactoryMethod.Day1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Day4
{
    public abstract class AbstractCourseFactory 
    {
        public AbstractCourse CreateCourse(string scheduleType)
        {
            AbstractCourse course = this.GetCourse(scheduleType);
            course.CreateCourseMaterial();
            course.CreateSchedule();
            return course;
        }
        public abstract AbstractCourse GetCourse(string scheduleType);        
    }


    public class OnlineCourseFactory : AbstractCourseFactory
    {
        public override AbstractCourse GetCourse(string scheduleType)
        {
            if(string.Equals("N",scheduleType))
            {
                return new ONetCourse();
            }
            else
            {
                return new OJavaCourse();
            }
        }
    }

    public class AdvancedOnlineCourseFactory :OnlineCourseFactory
    {
        public override AbstractCourse GetCourse(string scheduleType)
        {
            if (string.Equals("N", scheduleType))
            {
                return new OAdvNetCourse();
            }
            else
                return new OAdvJavaCourse();
        }
    }

    public class CorporateCourseFactory : AbstractCourseFactory
    {
        public override AbstractCourse GetCourse(string scheduleType)
        {
            if (string.Equals("N", scheduleType))
            {
                return new CNetCourse();
            }
            else
                return new CJavaCourse();
        }
    }
}
