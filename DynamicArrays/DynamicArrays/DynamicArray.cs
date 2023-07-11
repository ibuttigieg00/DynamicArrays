using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrays
{
    public class DynamicArray
    {
        int[] numbers;
        public int length { get; set; }
        private int counter = 0;
        public DynamicArray(int _length)
        {
            length = _length;
            numbers = new int[length];
        }

        // Insert n in the last position of the array
        public void PushBack(int n)
        {
            if (length == counter)
            {
                Resize();
                length = numbers.Length;
            }
            numbers[counter] = n;
            counter++;
        }

        public void Resize()
        {
            int[] resizedArray = new int[2*length];

            for (int i = 0; i < length; i++)
            {
                resizedArray[i] = numbers[i];
            }
            numbers = resizedArray;
        }
    }
}
