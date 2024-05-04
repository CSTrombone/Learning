
using System;
using System.Drawing;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;


//Prerequisites

public class Learning
{
    public delegate void Print(double x); //Change for different display types as need

    public static void Main(string[] args)
    {
        //Setup
        int[] nums1 = { 6, 7, 8 };
        int[] nums2 = { 5, 9, 10 };

        Print show = Display;

        //Result

        show(FindMedianSortedArrays(nums1, nums2));

        //Solution
        double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {          
            int[] finalArray = new int[nums1.Length + nums2.Length];     

            int i = 0; int j = 0; int k = 0;

            while (i < nums1.Length && j < nums2.Length)            
                finalArray[k++] = (nums1[i] < nums2[j]) ? nums1[i++] : nums2[j++];

            while (i < nums1.Length)         
                finalArray[k++] = nums1[i++];
            

            while (j < nums2.Length)          
                finalArray[k++] = nums2[j++];

            if (finalArray.Length % 2 != 0) //If size is odd
                return finalArray[finalArray.Length / 2];
            else
                return (double)(finalArray[finalArray.Length / 2] + finalArray[(finalArray.Length / 2) - 1]) / 2;

        }

    }

    //Flexible display method
    public static void Display(double x)
    {
        Console.Write("The median is {0:N}", x);
    }
}
