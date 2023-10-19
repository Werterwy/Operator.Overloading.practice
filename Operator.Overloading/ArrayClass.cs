using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.Overloading
{
    /// <summary>
    /// 2.	Дан класс содержащий внутри себя массив. Реализовать перегрузку операторов < , > так, чтобы 
    /// если сумма элементов массива 1 класса больше, возвращалось значение true и наоборот.
    /// </summary>
    public class ArrayClass
    {
        private int[] array;

        public ArrayClass(int[] elements)
        {
            array = elements;
        }

        public static bool operator <(ArrayClass left, ArrayClass right)
        {
            return left.GetSum() < right.GetSum();
        }

        public static bool operator >(ArrayClass left, ArrayClass right)
        {
            return left.GetSum() > right.GetSum();
        }

        private int GetSum()
        {
            int sum = 0;
            foreach (int element in array)
            {
                sum += element;
            }
            return sum;
        }
    }

}
