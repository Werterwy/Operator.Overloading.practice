using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1 1.	Создать класс с несколькими свойствами. Реализовать перегрузку операторов ==, != и Equals.

            Console.WriteLine("Ex1");
            Person person1 = new Person("John", "Doe", 30);
            Person person2 = new Person("Jane", "Smith", 25);
            Person person3 = new Person("John", "Doe", 30);

            //  перегруженные операторы сравнения
            bool areEqual = (person1 == person2);
            bool areNotEqual = (person1 != person2);
            bool areEqual2 = (person1 == person3);

            Console.WriteLine($"person1 == person2: {areEqual}");
            Console.WriteLine($"person1 != person2: {areNotEqual}");
            Console.WriteLine($"person1 == person3: {areEqual2}");
            Console.WriteLine("");

            //Ex2 2.	Дан класс содержащий внутри себя массив. Реализовать перегрузку операторов < , > так, чтобы
            //если сумма элементов массива 1 класса больше, возвращалось значение true и наоборот.

            Console.WriteLine("Ex2");
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };
            int[] array3 = { 7, 8, 9 };

            ArrayClass arr1 = new ArrayClass(array1);
            ArrayClass arr2 = new ArrayClass(array2);
            ArrayClass arr3 = new ArrayClass(array3);

            bool result1 = arr1 < arr2;
            bool result2 = arr2 > arr3;
            bool result3 = arr1 > arr3;

            Console.WriteLine("arr1 < arr2: " + result1);
            Console.WriteLine("arr2 > arr3: " + result2); 
            Console.WriteLine("arr1 > arr3: " + result3); 
            Console.WriteLine("");

            //Ex3 3.	Задание будет базироваться на примере в этом уроке. Необходимо реализовать второй вариант сложения денег – чтобы
            //можно было суммировать деньги в разных валютах. Для этого создайте отдельный класс, который будет предоставлять механизм
            //конвертации денег по заданному курсу. Кроме этого, перегрузите для класса Money оператор сравнения «==»
            //(при перегрузке данного оператора, обязательной является и перегрузка противоположного ему оператора «!=»).

            Console.WriteLine("Ex3");
            Money money1 = new Money(100, "USD");
            Money money2 = new Money(75, "USD");
            Money money3 = new Money(100, "EUR");

            Money sum1 = money1 + money2;
            Console.WriteLine($"money1 + money2 = {sum1.Amount} {sum1.Currency}");

            bool areEqual1 = money1 == money2;
            bool areNotEqual1 = money1 != money2;
            Console.WriteLine($"money1 == money2: {areEqual1}");
            Console.WriteLine($"money1 != money2: {areNotEqual1}");

            CurrencyConverter converter = new CurrencyConverter();
            Money convertedMoney = converter.Convert(money1, "EUR", 0.85M);
            Console.WriteLine($"Converted money: {convertedMoney.Amount} {convertedMoney.Currency}");
            Console.WriteLine("");

            //Ex4 4.	Класс – одномерный массив. Дополнительно перегрузить следующие операции: * – умножение массивов;
            //[] – доступ по индексу, int() – размер массива; == – проверка на равенство; <= – сравнение

            Console.WriteLine("Ex4");
            int[] Arr1 = { 1, 2, 3 };
            int[] Arr2 = { 4, 5, 6 };

            OneDimensionArray Array1 = new OneDimensionArray(Arr1);
            OneDimensionArray Array2 = new OneDimensionArray(Arr2);

            OneDimensionArray multiplicationResult = Array1 * Array2;
            Console.Write("Multiplication Result: ");
            for (int i = 0; i < multiplicationResult.Length; i++)
            {
                Console.Write(multiplicationResult[i] + " ");
            }

            Console.WriteLine("\nArray1 Length: " + (int)Array1);
            Console.WriteLine("Array1 == Array2: " + (Array1 == Array2));
            Console.WriteLine("Array1 <= Array2: " + (Array1 <= Array2));
        }
    }
}
