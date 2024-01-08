using System;
using System.Linq;


namespace ConsoleApp1
{
  
    class Program
    {
        static void Main(string[] args)
        {
            string inputString1 = Console.ReadLine();
            string inputString2 = Console.ReadLine();
            int sum = 0;

            string[] firstArr = inputString1.Split(" ");
            string[] secondArr = inputString2.Split(" ");
            for (int i = 0; i <= firstArr.Length - 1; i++)
            {
                int currentNum1 = int.Parse(firstArr[i]);
                int currentNum2 = int.Parse(secondArr[i]);

                if (currentNum1 != currentNum2)
                {
                    Console.WriteLine("Arrays are not identical. Found difference at {0} index.", i);
                    break;
                }
                sum = sum + currentNum1;
            }
            Console.WriteLine("Arrays are identical. Sum: {0}", sum);
        }
    }
}
    






