using System;
using System.Runtime.Intrinsics;
using System.Security.Cryptography.X509Certificates;


//Prerequisites

public class Learning
{
    public delegate void Print(int[] x); //Change for different display types as need

    public static void Main(string[] args)
    {
        //Setup
        Print show = Display;

        int[] nums = { 2, 7, 11, 15 };

        int target = 9;

        //Result

        show(TwoSum(nums, target));

        //Solution
        int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            Dictionary<int, int> numsTable = new Dictionary<int, int>(nums.Length);

            for (int i = 0; i < nums.Length; i++)
            {
                if (numsTable.ContainsKey(target - nums[i]))
                {
                    return new int[] { numsTable[target - nums[i]], i };
                }

                numsTable[nums[i]] = i;
            }

            return result;
        }

    }

    //Flexible display method
    public static void Display(int[] x)
    {
        Console.Write("Index {0}, Index {1}", x[0], x[1]);
    }
}