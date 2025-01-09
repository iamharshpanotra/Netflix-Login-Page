using System;

namespace TestLearn2
{
    class Program
    {
        public void EvenNumbers()
        {
            int Start = 0;

            while (Start <= 20)
            {
                Console.WriteLine(Start);
                Start = Start + 2;
            }
        }

        public static void Method()
        {
            // Create an instance of Program to call the instance method EvenNumbers
            Program p = new Program();
            p.EvenNumbers();
        }

        static void Main(string[] args)
        {
            // Call the static Method to start the program
            Method();
        }
    }
}
