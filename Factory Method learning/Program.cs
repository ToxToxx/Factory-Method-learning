using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new EarthTransportDriver("Вадим", "2В");
            Transport transport1 = driver.Create();

            driver = new WaterTransportDriver("Максим", "Капитан");
            Transport transport = driver.Create();

            driver = new AirTransportDriver("Марк", "Пилот");
            Transport transport2 = driver.Create();

            Console.ReadLine();
        }
    }
    // abstract class for a driver
    abstract class Driver
    {
        public string Name { get; set; }
        public string Specification { get; set; }

        public Driver(string name, string specification)
        {
            Name = name;
            Specification = specification;
        }
        // fabric method
        abstract public Transport Create();
    }
    // drive earth transport
    class EarthTransportDriver : Driver
    {
        public EarthTransportDriver(string name, string specification) : base(name,specification)
        { }

        public override Transport Create()
        {
            return new EarthTransport();
        }
    }
    // drive water transport
    class WaterTransportDriver : Driver
    {
        public WaterTransportDriver(string name, string specification) : base(name, specification)
        { }

        public override Transport Create()
        {
            return new WaterTransport();
        }
    }
    // drive air Transport
    class AirTransportDriver : Driver
    {
        public AirTransportDriver(string name, string specification) : base(name, specification)
        { }

        public override Transport Create()
        {
            return new AirTransport();
        }
    }

    abstract class Transport
    {

    }

    class EarthTransport : Transport
    {
        public EarthTransport()
        {
            Console.WriteLine("Rides earth transport");
        }
    }
    class WaterTransport : Transport
    {
        public WaterTransport()
        {
            Console.WriteLine("Rides water transport");
        }
    }
    
    class AirTransport : Transport
    {
        public AirTransport()
        {
            Console.WriteLine("Flies over sea");
        }
    }
}
