using System;
using test_Tp_Lab2;

namespace CompanionApp
{
    public class Cat : Animal
    {

        public Cat(int age, string name)
            : base(age, name,
                "   /       \\\n" +
                "  l  u   u  l\n" +
                "--l----*----l--\n" +
                "   \\   w   /     - Meow!\n" +
                "     ======\n" +
                "   /       \\ __\n" +
                "   l        l\\ \\\n" +
                "   l        l/ /\n" +
                "   l  l l   l /\n" +
                "   \\ ml lm /_/")
        { }
        
        public override void MakeSound()
        {
            Random random = new Random();
            if (random.Next(2) == 0)
            {
                Console.WriteLine(
                "   /       \\\n" +
                "  l  u   u  l\n" +
                "--l----*----l--\n" +
                "   \\   w   /     --------- Meow!\n" +
                "     ======\n" +
                "   /       \\ __\n" +
                "   l        l\\ \\\n" +
                "   l        l/ /\n" +
                "   l  l l   l /\n" +
                "   \\ ml lm /_/");
            }
            else
            {
                Console.WriteLine(
                "   /       \\\n" +
                "  l  u   u  l\n" +
                "--l----*----l--\n" +
                "   \\   w   /     -------- Silent.....\n" +
                "     ======\n" +
                "   /       \\ __\n" +
                "   l        l\\ \\\n" +
                "   l        l/ /\n" +
                "   l  l l   l /\n" +
                "   \\ ml lm /_/");
            }
        }
    }
}