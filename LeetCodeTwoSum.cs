using System;
using System.Linq;


namespace LeetCode3
{
    class Program // TWO SUM (Search an array for two numbers that add up to the target number)
    {
        static void Main(string[] args)
        {
            Array nums = new Array[2, 7, 11, 15];
            int target = 9;

            Dictionary<int, int> intStore = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (intStore.ContainsKey(target - nums[i]))
                {
                    return new int[] { intStore[target - nums[i]], i };
                }
                else
                {
                    intStore[nums[i]] = i;
                }
                // BELOW was MY first ATTEMPT
                //public int[] TwoSum(int[] nums, int target)
                //{
                //int firstNum = 0;

                //int[] values = new int[nums.Length];

                //for (int x = 0; x < nums.Length; x++)
                //{
                // values[x] = Convert.ToInt32(nums.GetValue(x).ToString());

                // if (x < target)
                // {
                // x = firstNum;
                // int secondNum = target - firstNum;
                //}

                // }

                //return(firstNum, secondNum);
                // Console.WriteLine("Target is: ", target);
                // Console.WriteLine(firstNum);
            }

    }

}

    

