using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] fibonacci = Fibonacci(50);          

            foreach (double num in fibonacci)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
  
        }

        static double[] Fibonacci (int size)
        {
            double[] fibonacci = new double[size];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            int counter = 2;
            while (counter < size)
            {
                for (int i = 1; i < counter; i++)
                {                 
                   fibonacci[counter] = fibonacci[counter - 2] + fibonacci[i];                    
                }
                counter++;

            }
            return fibonacci;
        }
    }
}
