using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace LeetCode1 //Subtract the Product and Sum of Digits of an Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask for input
            Console.WriteLine("Enter a number: ");
            //convert input to an int type
            int input = Convert.ToInt32(Console.ReadLine());
            //new int type to call the method
            int output = result(input);
            //output the result from the called method
            Console.WriteLine(output);

            int result(int n)
            {
                //created variables
                var ch = n;
                var sum = 0;
                var prod = 1;
                //loop to work through all isolated digits
                while (ch > 0)
                {
                    //every iteration you are using the digit on the right and working left
                    var i = ch % 10;
                    //adding the "remainder" to the total sum
                    sum += i;
                    //multiplying the "remainder" (starting with 1 to prevent * 0) to the total
                    prod *= i;
                    //dividing by 10 to isolate the next digit on the left
                    ch /= 10;
                }
                //returning the desired result
                return prod - sum;
            }
        }
    }
}
