using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithm
{
    public class SelectionSort : SortBase,ISort
    {


        public SelectionSort(bool showLogValue):base(showLogValue)
        {

        }

        public int[] ReverseSort(ArrayTestBed arrayObject)
        {
            int maximumValueIndex, tempValue;
            var numberArray = arrayObject.arr;
            for (int i = 0; i <= arrayObject.upper; ++i)
            {
                maximumValueIndex = i;
                for (int j = i + 1; j <= arrayObject.upper; ++j)
                {
                    if (numberArray[j] < numberArray[maximumValueIndex])
                    {
                        maximumValueIndex = j;
                    }
                }

                tempValue = numberArray[i];
                numberArray[i] = numberArray[maximumValueIndex];
                numberArray[maximumValueIndex] = tempValue;

                if(ShowLog)
                arrayObject.DispayElements();
            }
            return numberArray;
        }

        public int[] Sort(ArrayTestBed arrayObject)
        {
            int minimumValueIndex, tempValue;
            var numberArray = arrayObject.arr;
            for (int i = 0; i <= arrayObject.upper; ++i)
            {
                minimumValueIndex = i;
                for (int j  = i+1; j  <= arrayObject.upper; ++j)
                {
                    if(numberArray[j] > numberArray[minimumValueIndex])
                    {
                        minimumValueIndex = j;
                    }
                }

                tempValue = numberArray[i];
                numberArray[i] = numberArray[minimumValueIndex];
                numberArray[minimumValueIndex] = tempValue;

                if (ShowLog)
                    arrayObject.DispayElements();

            }
            return numberArray;
        }
    }
}
