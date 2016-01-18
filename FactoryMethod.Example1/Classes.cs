using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example1
{
    public interface ICarFactory
    {
        ICar CreateCar(string type);
    }

    public abstract class AbstractCarFactory : ICarFactory
    {
        public ICar CreateCar(string type)
        {
            var car = this.GetCar(type);
            return car;
        }
        public abstract ICar GetCar(string type);
    }

    public class BmwCarFactory : AbstractCarFactory
    {
        public override ICar GetCar(string type)
        {
            ICar car = null;
            switch (type)
            {
                case "3 Series":
                    car = new ThreeSeries("M3", "1998", 4);
                    break;
                case "5 Series":
                    car = new FiveSeries("M5", "1997", 2);
                    break;
                default:
                    break;           

            }
            return car;
        }
    }






    public interface ICar
    {
        string Name { get; }
        string Year { get; }     
        int Doors { get; }
        string ShowDescription();       
    }

    public abstract class Car : ICar
    {
        public Car(string name, string year, int doors)
        {
            this.Doors = doors;
            this.Name = name;
            this.Year = year;
        }      

        public int Doors
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public string Year
        {
            get; set;
        }

        public abstract string ShowDescription();      
        
    }

    public abstract class BaseBmw : Car
    {
        public BaseBmw(string name, string year, int doors) :base(name,year,doors)
        {

        }
        public abstract string Series { get;}
        public override string ShowDescription()
        {
            return $"{Year} - {Name} {Series} - with {Doors} doors";
        }
    }

    public class ThreeSeries : BaseBmw
    {
        public ThreeSeries(string name, string year, int doors) :base(name,year,doors)
        {

        }
        public override string Series
        {
            get
            {
                return "3 Series";
            }           
        }
    }

    public class FiveSeries : BaseBmw
    {
        public FiveSeries(string name, string year, int doors) : base(name, year, doors)
        {
                
        }

        public override string Series
        {
            get
            {
                return "5 Series";
            }
        }
    }

    public abstract class BaseAudi : Car
    {
        public abstract string ANumber { get; }

        public BaseAudi(string name, string year, int doors) : base(name, year, doors)
        {
        }

        public override string ShowDescription()
        {
            return $"{Year} - {Name} {ANumber} - with {Doors} doors";
        }
    }

    public class A4 : BaseAudi
    {
        public A4(string name, string year, int doors) : base(name, year, doors)
        {
        }
        public override string ANumber
        {
            get
            {
                return "A 4";
            }
        }
    }

    public class A7 : BaseAudi
    {
        public A7(string name, string year, int doors) : base(name, year, doors)
        {
        }
        public override string ANumber
        {
            get
            {
                return "A 7";
            }
        }
    }

}
