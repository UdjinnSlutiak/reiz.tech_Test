using System;

namespace Test.
    Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            var calculation = new Calculation();

            int angle = calculation.GetAngle(hours: hours, minutes: minutes);

            Console.WriteLine($"Angle between arrows: {angle}");
        }
    }
}
