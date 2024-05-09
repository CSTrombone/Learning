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
        Print show = Display;

        string s = "PAYPALISHIRING";
        int numRows = 13;

        //Result
        show(Convert(s, numRows));

        //Solution
        string Convert(string s, int numRows)
        {
            string result = "";

            if(numRows == 1)
                return s;

            for(int r = 0; r < numRows; r++)
            {
                int i = 2 * (numRows - 1);

                for(int c = r; c < s.Length; c += i)
                {
                    result += s[c]; //Do Outer Rows

                    if (r > 0 && r < numRows - 1 && c + i - 2 * r < s.Length) //Do middle rows
                    {
                        result += s[c + i - 2 * r];
                    }
                }
            }

            return result;
        }


    }

    //Flexible display method
    public static void Display(string s)
    {
        Console.Write(s);
    }
}
