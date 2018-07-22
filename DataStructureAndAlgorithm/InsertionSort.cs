using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithm
{
    public class InsertionSort :SortBase, ISort
    {


        public InsertionSort(bool showLogValue):base(showLogValue)
        {

        }


        public int[] ReverseSort(ArrayTestBed arrayObject)
        {
            int tempValue;
            var numberArray = arrayObject.arr;
            int j;
            for (int i = 0; i <= arrayObject.upper; i++)
            {

                tempValue = numberArray[i];
                j = i;
                while (j > 0 && numberArray[j - 1] < tempValue)
                {
                    numberArray[j] = numberArray[j - 1];
                    --j;
                }
                numberArray[j] = tempValue;
                if (ShowLog)
                    arrayObject.DispayElements();

            }
            return numberArray;
        }

        public int[] Sort(ArrayTestBed arrayObject)
        {
            int tempValue;
            var numberArray = arrayObject.arr;
            int j;
            for (int i = 0; i <= arrayObject.upper; i++)
            {

                tempValue = numberArray[i];
                j = i;
               while(j>0 && numberArray[j - 1] > tempValue)
                {
                    numberArray[j] = numberArray[j - 1];
                    --j;
                }
                numberArray[j] = tempValue;

                if (ShowLog)
                    arrayObject.DispayElements();
            }
            return numberArray;
        }
    }
}
