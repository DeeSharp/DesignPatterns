using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Day1
{
    public abstract class AbstractCourse
    {
        public abstract int CourseDuration { get; set; }

        public abstract string CourseName { get; set; }

        public abstract string CreateCourseMaterial();

        public abstract string CreateSchedule();
    }

    public class NetCourse : AbstractCourse
    {
        public override int CourseDuration
        {
            get; set;
        }

        public override string CourseName
        {
            get; set;
        }

        public override string CreateCourseMaterial()
        {
            return "CLR, IL";
        }

        public override string CreateSchedule()
        {
            return "1st Jan 2016, 20 Feb 2016";
        }
    }

    public class JavaCourse : AbstractCourse
    {
        public override int CourseDuration
        {
            get; set;
        }

        public override string CourseName
        {
            get; set;
        }

        public override string CreateCourseMaterial()
        {
            return "JVM, Annotations";
        }

        public override string CreateSchedule()
        {
            return "2 Jan 2016, 3 Feb 2016";
        }
    }

    public class CNetCourse : AbstractCourse
    {
        public override int CourseDuration
        {
            get; set;
        }

        public override string CourseName
        {
            get; set;
        }

        public override string CreateCourseMaterial()
        {
            return "Corporate - CLR, IL";
        }

        public override string CreateSchedule()
        {
            return "Corporate - 1st Jan 2016, 20 Feb 2016";
        }
    }

    public class CJavaCourse : AbstractCourse
    {
        public override int CourseDuration
        {
            get; set;
        }

        public override string CourseName
        {
            get; set;
        }

        public override string CreateCourseMaterial()
        {
            return "Corporate - JVM, Annotations";
        }

        public override string CreateSchedule()
        {
            return "Corporate - 2 Jan 2016, 3 Feb 2016";
        }
    }

    public class ONetCourse : AbstractCourse
    {
        public override int CourseDuration
        {
            get; set;
        }

        public override string CourseName
        {
            get; set;
        }

        public override string CreateCourseMaterial()
        {
            return "Corporate - CLR, IL";
        }

        public override string CreateSchedule()
        {
            return "Corporate - 1st Jan 2016, 20 Feb 2016";
        }
    }

    public class OJavaCourse : AbstractCourse
    {
        public override int CourseDuration
        {
            get; set;
        }

        public override string CourseName
        {
            get; set;
        }

        public override string CreateCourseMaterial()
        {
            return "Corporate - JVM, Annotations";
        }

        public override string CreateSchedule()
        {
            return "Corporate - 2 Jan 2016, 3 Feb 2016";
        }
    }

    public class OAdvNetCourse : AbstractCourse
    {
        public override int CourseDuration
        {
            get; set;
        }

        public override string CourseName
        {
            get; set;
        }

        public override string CreateCourseMaterial()
        {
            return "Corporate - CLR, IL";
        }

        public override string CreateSchedule()
        {
            return "Corporate - 1st Jan 2016, 20 Feb 2016";
        }
    }

    public class OAdvJavaCourse : AbstractCourse
    {
        public override int CourseDuration
        {
            get; set;
        }

        public override string CourseName
        {
            get; set;
        }

        public override string CreateCourseMaterial()
        {
            return "OAdv - JVM, Annotations";
        }

        public override string CreateSchedule()
        {
            return "OAdv - 2 Jan 2016, 3 Feb 2016";
        }
    }
}
