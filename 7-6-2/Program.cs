namespace _7_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class Car<T1> where T1 :Engine
    {
        public T1 Engine;

        public virtual void ChangePart<T2>(T2 newPart) where T2 : CarPart
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
