using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example2
{

    //example from https://msdn.microsoft.com/en-us/library/ee817667.aspx 
    public abstract class Computer
    {
        public abstract int Mhz { get; }
    }

    public class ConcreteComputer : Computer
    {
        public override int Mhz
        {
            get
            {
                return 500;
            }

        }
    }

    public class BrandXComputer : Computer
    {
        public override int Mhz
        {
            get
            {
                return 1500;
            }
        }
    }


    public abstract class ComputerFactory
    {
        public abstract Computer GetComputer();
    }

    public class ConcreteComputerFactory : ComputerFactory
    {
        public override Computer GetComputer()
        {
            return new ConcreteComputer();
        }
    }

    public class BrandXComputerFactory : ComputerFactory
    {
        public override Computer GetComputer()
        {
            return new BrandXComputer();
        }
    }

    public class ComputerAssembler
    {
        public void AssembleComputer(ComputerFactory factory)
        {
            Computer computer = factory.GetComputer();
            Console.WriteLine($"assembled a {computer.GetType().Name} running at {computer.Mhz}");
        }
    }
}
