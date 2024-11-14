namespace _7_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    abstract class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;

        public abstract void ChangePart<TPart>(TPart newPart) where TPart : CarPart;
    }

    class ElectricCar<TEngine> : Car<TEngine> where TEngine : Engine
    {
        public override void ChangePart<TPart>(TPart newPart)
        {
            
        }

    }

    class GasCar<TEngine> : Car<TEngine> where TEngine : Engine
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }

    }
    abstract class CarPart
    {

    }

    abstract class Engine
    {
    }


    class ElectricEngine : Engine
    { }

    class GasEngine : Engine
    { }

    class Battery : CarPart
    {
        
    }

    class Differential : CarPart 
    { }

    class Wheel : CarPart
    { }




}
