using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.Overloading
{
    public class OneDimensionArray
    {
        private int[] array;

        public OneDimensionArray(int[] elements)
        {
            array = elements;
        }

        public static OneDimensionArray operator *(OneDimensionArray array1, OneDimensionArray array2)
        {
            if (array1.Length != array2.Length)
            {
                throw new InvalidOperationException("Arrays must have the same length for multiplication.");
            }

            int[] result = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i] * array2[i];
            }

            return new OneDimensionArray(result);
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return array[index];
            }
            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                array[index] = value;
            }
        }

        public static explicit operator int(OneDimensionArray array)
        {
            return array.Length;
        }

        public static bool operator ==(OneDimensionArray array1, OneDimensionArray array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator !=(OneDimensionArray array1, OneDimensionArray array2)
        {
            return !(array1 == array2);
        }

        public static bool operator <=(OneDimensionArray array1, OneDimensionArray array2)
        {
            if (array1.Length != array2.Length)
            {
                throw new InvalidOperationException("Arrays must have the same length for comparison.");
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > array2[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator >=(OneDimensionArray array1, OneDimensionArray array2)
        {
            if (array1.Length != array2.Length)
            {
                throw new InvalidOperationException("Arrays must have the same length for comparison.");
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] < array2[i])
                {
                    return false;
                }
            }

            return true;
        }

        public int Length
        {
            get { return array.Length; }
        }
    }
}
