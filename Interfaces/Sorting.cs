using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ISortAlgorithm
    {
        public double[] Sort(double[] input);
    }

    public class Sorting
    {
        private static int VALUECOUNT = 10;
        private ISortAlgorithm SortAlgorithm;

        public Sorting(ISortAlgorithm sortAlgorithm, int valueCount)
        {
            VALUECOUNT = valueCount;
            this.SortAlgorithm = sortAlgorithm;
        }

        public void Run()
        { 
            double[] input = new double[VALUECOUNT];
            var rand = new Random();
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Math.Round(rand.NextDouble() * 100);
            }

            PrintValues(input);
            DateTime startTime = DateTime.Now;
            double[] output = SortAlgorithm.Sort(input);
            DateTime finischTime = DateTime.Now;
            PrintValues(output);
            Console.WriteLine("Duration: " + (finischTime - startTime).ToString());
        }

        private void PrintValues(double[] values)
        {
            foreach (var value in values)
            {
                Console.Write(value.ToString() + "\t");
            }
            Console.WriteLine();
        }
    }
}
