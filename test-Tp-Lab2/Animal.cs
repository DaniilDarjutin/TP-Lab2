using CompanionApp;
using System;

namespace test_Tp_Lab2
{
    public abstract class Animal : Alive
    {

        private int age;
        private string name;
        private string shape;

        public Animal (int age, string name, string shape)
        {
            this.age = age;
            this.name = name;
            this.shape = shape;
        }

        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        public abstract void MakeSound();


    }
}
