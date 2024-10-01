using System;

namespace CompanionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Barsik", 3);
            Dog dog = new Dog("Bobik", 5);

            Person person1 = new Person("Denis", cat);
            Person person2 = new Person("Marina", dog);

            person1.GetCompanionInfo();
            person2.GetCompanionInfo();
        }
    }
}