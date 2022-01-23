using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class BubbleSort : ISortAlgorithm
    {
        public double[] Sort(double[] input)
        {
            double[] sorted = input;
            for (int i = 0; i < sorted.Length; i++)
            {
                for (int j = i + 1; j < sorted.Length; j++)
                {
                    if (sorted[i] > sorted[j])
                    {
                        double temp = sorted[i];
                        sorted[i] = sorted[j];
                        sorted[j] = temp;
                    }
                }
            }
            return sorted;
        }
    }

    public class QuickSort : ISortAlgorithm
    {
        public double[] Sort(double[] input)
        {
            if (input.Length <= 1)
                return input;

            int pivotIndex = (input.Length) / 2;
            double pivot = input[pivotIndex];

            double[] leftArray = input.Take(pivotIndex).ToArray();
            double[] rightArray = input.Skip(pivotIndex).ToArray();

            _ = Sort(leftArray);
            _ = Sort(rightArray);
        }
    }
}
