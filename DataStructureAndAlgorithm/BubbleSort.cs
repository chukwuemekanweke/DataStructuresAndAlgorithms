using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithm
{
    public class BubbleSort :SortBase, ISort
    {

        public BubbleSort(bool showLogValue):base(showLogValue)
        {

        }

        public int[] Sort(ArrayTestBed testBed)
        {
            int temp;
            var arrayObject = testBed.arr;

            for (int i = testBed.upper; i > 0;  i--)
            {
                for (int j = 0; j < i; ++j)
                {

                    if (arrayObject[j] > arrayObject[j + 1])
                    {
                        temp = arrayObject[j];
                        arrayObject[j] = arrayObject[j + 1];
                        arrayObject[j + 1] = temp;
                    }
                }

                if (ShowLog)
                    testBed.DispayElements();
            }
            return arrayObject;
        }

        public int[] ReverseSort(ArrayTestBed testBed)
        {
            int temp;
            var arrayObject = testBed.arr;

            for (int i = testBed.upper; i > 0; i--)
            {
                for (int j = 0; j < i; ++j)
                {

                    if (arrayObject[j] < arrayObject[j + 1])
                    {
                        temp = arrayObject[j];
                        arrayObject[j] = arrayObject[j + 1];
                        arrayObject[j + 1] = temp;
                    }
                }

                if (ShowLog)
                    testBed.DispayElements();

            }
            return arrayObject;
        }

     
    }
}
