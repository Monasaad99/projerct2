using System;

namespace section1
{
    class program
    {

        static void Main(String[] args)
        {
            int number, sum = 0,n;
            Console.WriteLine("Please enter the number");
            int Number = int.Parse(Console.ReadLine());
            n = Number;
            int i = 1;
            for (; i < Number; i++);
            {
                if (Number % i == 0)
                {
                    sum = sum + i ;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("entered number is a perfect number");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("enterd number is not a perfect number");
                Console.ReadLine();

            }
        }
    }
}



                