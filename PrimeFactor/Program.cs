using System;

namespace PrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0; //user input
     
            int cnt = 0; // how many times divisible
            int primeCnt = 0; //how many prime numbers

            Console.WriteLine("Please enter a whole number");
            num = Convert.ToInt32(Console.ReadLine()); //converts input into number
         

            Console.Write(" The Prime factor of {0}:\n", num);
            for (int i = 2; i < num; i++)
            {
                // check for divisibility
                if (num % i == 0) //if divisble
                {
                    cnt = 0;
                    // check for prime number
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                            cnt++;
                    }
                    if (cnt == 2)
                    {
                        primeCnt = 1;
                        Console.Write(i + " ");
                    }
                }
            }

            if (primeCnt == 0) //if prime count == 0 means no factors
                Console.Write("There is no Prime factor for {0} ", num);

            Console.ReadLine();
        }
    }
}
