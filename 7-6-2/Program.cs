namespace _7_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class Car<T1>
    {
        public T1 Engine;

        public virtual void ChangePart<T2>(T2 Part)
        {

        }
    }

    class ElectricEngine
    { }

    class GasEngine
    { }

    class Battery
    {
        
    }

    class Differential
    { }

    class Wheel
    { }




}
