using System;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car printCar = new Car() { Make = "Honda", Model = "CRV", Year = 2010 };
            Console.WriteLine($"Make: {printCar.Make}, Model: {printCar.Model}, Year: {printCar.Year}");
        }
    }
}
