using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.Overloading
{
    /// <summary>
    /// 1.	Создать класс с несколькими свойствами. Реализовать перегрузку операторов ==, != и Equals
    /// </summary>
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public static bool operator ==(Person person1, Person person2)
        {
            if (ReferenceEquals(person1, person2))
                return true;

            if (ReferenceEquals(person1, null) || ReferenceEquals(person2, null))
                return false;

            return person1.FirstName == person2.FirstName && person1.LastName == person2.LastName && person1.Age == person2.Age;
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1 == person2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Person person)
                return this == person;

            return false;
        }

    }
}
