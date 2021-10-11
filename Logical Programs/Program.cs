using System;

namespace Logical_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, rem, sum = 0 ;
            num = int.Parse(Console.ReadLine());
            Console.Write("Enter a no." +num);
            for (int i=1;i<num;i++)
            {
                rem = num % i;
                if(rem==0)
                {
                    sum = sum + i;
                }
            }
            if (sum == num)
                Console.Write("perfect number");
            else
                Console.Write("Not a perfect number");
            }

        }
    }
    
