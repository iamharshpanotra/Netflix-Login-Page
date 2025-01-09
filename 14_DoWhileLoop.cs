using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLearn2
{
    class _14_DoWhileLoop
    {
        public static void While()
        {
            Console.WriteLine("Please enter your choice");
            int choice = int.Parse(Console.ReadLine());

            int cost = 0;

            while (cost <= choice)
            {
                Console.Write(cost + " ");
                cost = cost + 2;
            }

            do
            {
                Console.WriteLine("Do you want to continue - Yes or No? ");

                string userChoice = Console.ReadLine();

                if (userChoice != "Yes" && userChoice != "No")
                {
                    Console.WriteLine("Invalid Choice, Please enter yes or no.");
                }
            }
        }
    }
}
