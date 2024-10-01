using System;

namespace CompanionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(3, "Barsik");
            Dog dog = new Dog(5, "Bobik");

            Person person1 = new Person("Denis", cat);
            Person person2 = new Person("Marina", dog);

            person1.GetCompanionInfo();
            person2.GetCompanionInfo();
        }
    }
}