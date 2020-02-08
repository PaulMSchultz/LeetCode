using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paulmschultzLeet2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsPalindrome(int x)
            {
                if (x < 0 || (x % 10 == 0 && x != 0))
                { //input has to be Not a negative, not end in 0, not be 0
                    return false; //anything but input % 10 == 0, results in a false return
                }
                int revertNum = 0; //create variable
                while (x > revertNum) //while input is > 0
                {
                    //multipling the var by 10, adding the input % 10 value to the var
                    //this checks 'half' of the input number to see if it is a palindrome
                    revertNum = revertNum * 10 + x % 10;
                    //by increasing revertNum and decreasing x this gives a stopping point
                    x = x / 10;     
                }
                //this says true if the numbers match, diving by ten allows for odd inputs to be evaluated
                return x == revertNum || x == revertNum / 10;
            }
            Console.WriteLine("Enter a number to check if it is a palindrome...You will get a 'true or 'fasle'");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsPalindrome(input));

        }
    }
}
