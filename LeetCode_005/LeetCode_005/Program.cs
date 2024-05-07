using System;
using System.Runtime.Intrinsics;
using System.Security.Cryptography.X509Certificates;


//Prerequisites

public class Learning
{
    public delegate void Print(string s); //Change for different display types as need

    public static void Main(string[] args)
    {
        //Setup
        string s = "cabbage";

        Print show = Display;
        //Result

        show(LongestPalindrome(s));

        //Solution
        string LongestPalindrome(string s)
        {
            string result = "";
            int resultLength = 0;

            for (int i = 0; i < s.Length; i++) 
            {
                int l = i, r = i;
                while (l >= 0 && r < s.Length && s[l] == s[r])
                {
                    if (r - l + 1 > resultLength)
                    {
                        result = s.Substring(l, r - l + 1);
                        resultLength = r - l + 1;
                    }

                    l -= 1;
                    r += 1;
                }

                l = i; r = i + 1;
                while (l >= 0 && r < s.Length && s[l] == s[r])
                {
                    if (r - l + 1 > resultLength)
                    {
                        result = s.Substring(l, r - l + 1);
                        resultLength = r - l + 1;
                    }

                    l -= 1;
                    r += 1;
                }
            }

            return result;

        }
    }

    //Flexible display method
    public static void Display(string s)
    {
        Console.Write("The longest palindrome is {0}", s);
    }
}