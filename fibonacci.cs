using System;

namespace project_folder
{
    class Program
    {
        static void Main(string[] args)
        {
            //given n, return nth number in the fibonacci sequence.
            
            Console.WriteLine("What term of the Fibonacci Sequence would you like to know:");
            int term = Convert.ToInt32(Console.ReadLine());
        
            int currentIndex = 1;
            int temp = 0;
            int lastIndex = 0;

            while (term > 1)
            {
                temp = lastIndex;
                lastIndex = currentIndex;
                currentIndex = currentIndex + temp;
                term--;
            }

            Console.WriteLine("That term of the Fibonacci Sequence is: " + currentIndex + ".");
        }
    }
}
