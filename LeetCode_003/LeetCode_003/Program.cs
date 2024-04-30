using System;
using System.Runtime.Intrinsics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;


//Prerequisites

public class Learning
{
    public delegate void Print(int x); //Change for different display types as need

    public static void Main(string[] args)
    {
        //Setup
        Print show = Display;

        string s = "pwwkew";

        //Result

        show(LengthOfLongestSubstring(s));

        //Solution
        int LengthOfLongestSubstring(string s)
        {
            int result = 0;

            HashSet<char> set = new HashSet<char>(s.Length);

            int l = 0;            

            for (int r = 0; r < s.Length; r++)
            {
                while(set.Contains(s[r]))
                {
                    set.Remove(s[l]);
                    l += 1;
                }
                set.Add(s[r]);
                result = int.Max(result, r - l + 1);
            }

                return result;
        }


    }

    //Flexible display method
    public static void Display(int x)
    {
        Console.Write("The longest substring has a length of {0}.", x);
    }
}