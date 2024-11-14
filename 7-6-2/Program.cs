namespace _7_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;

        public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart
        {

        }
    }

    class CarPart
    {

    }

    class Engine
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
