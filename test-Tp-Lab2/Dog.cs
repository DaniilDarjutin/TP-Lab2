using System;
using test_Tp_Lab2;


namespace CompanionApp
{
    public class Dog : Animal
    {
        private string Name { get; set; }
        private int Age { get; set; }

        public Dog(int age, string name) : base(age, name,
                " /        //o__o\n" +
                "/\\       /  __/\n" +
                "\\ \\______\\  /     -ARF!\n" +
                " \\         /\n" +
                "  \\ \\----\\ \\\n" +
                "   \\_\\_   \\_\\_")
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine(
                " /        //o__o\n" +
                "/\\       /  __/\n" +
                "\\ \\______\\  /     -ARF!\n" +
                " \\         /\n" +
                "  \\ \\----\\ \\\n" +
                "   \\_\\_   \\_\\_");
        }
    }
}