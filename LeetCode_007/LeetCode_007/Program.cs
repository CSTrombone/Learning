using System;
using System.Globalization;
using System.Runtime.Intrinsics;
using System.Security.Cryptography.X509Certificates;


//Prerequisites

public class Learning
{
    public delegate void Print(int x); //Change for different display types as need

    public static void Main(string[] args)
    {
        //Setup
        Print show = Display;

        int x = -2147483412;

        //Result
        show(Reverse(x));


        //Solution
        int Reverse(int x)
        {
            int result = 0;

            int MIN = -2147483648;
            int MAX = 2147483647;

            while (x != 0)
            {
                int digit = x % 10;
                x /= 10;

                if (result > MAX / 10 || (result == MAX / 10 && digit >= MAX % 10))
                    return 0;

                if (result < MIN / 10 || (result == MIN / 10 && digit <= MIN % 10))
                    return 0;

                result = result * 10 + digit; 

            }

            return result;
        }

    }

    //Flexible display method
    public static void Display(int x)
    {
        Console.Write(x);
    }
}
