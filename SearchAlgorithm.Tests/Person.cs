using System;

namespace SearchAlgorithm.Tests
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            if (other == null)
            {
                return 1;
            }
            
            return this.Age.CompareTo(other.Age);
        }
    }
}