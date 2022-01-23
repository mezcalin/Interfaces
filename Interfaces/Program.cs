using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interfaces");

            //Interface with implemented class
            Sorting sorting = new Sorting(new BubbleSort(), 10);
            sorting.Run();

            //Interface without implemented class
        }
    }
}
