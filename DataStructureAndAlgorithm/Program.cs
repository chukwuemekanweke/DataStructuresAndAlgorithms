using System;
using System.Threading;

namespace DataStructureAndAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ArrayTestBed numbersTestBed = new ArrayTestBed(10);
            ISort bubbleSort = new BubbleSort();
            Random rnd = new Random(100);
            for (int i=0; i<=9; i++)
            {
                numbersTestBed.Insert((int)(rnd.NextDouble()*100));
            }
            numbersTestBed.DispayElements();



            var clonedTestArrayBed = numbersTestBed.CloneObject();

            Metrics metric = new Metrics("Bubble Sort");

            var result  = bubbleSort.Sort(numbersTestBed);

            metric.Dispose();
            metric = new Metrics("Reverse Bubble Sort");

            var result2 = bubbleSort.ReverseSort(clonedTestArrayBed);
            metric.Dispose();


            numbersTestBed.arr = result;
            numbersTestBed.DispayElements();

            numbersTestBed.arr = result2;
            numbersTestBed.DispayElements();



            Console.ReadLine();
        }
    }
}
