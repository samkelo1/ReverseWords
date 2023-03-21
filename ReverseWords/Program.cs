using System;
using System.Text;


public class Program
{
    public static void Main()
    {
        string inputString = "this is a test";
        string inputString2 = "foobar";
        string inputString3 = "all your base";
       

        Console.WriteLine("Reversed Word Order  : " + ReverseWordOrder_Way(inputString));
        Console.WriteLine("Reversed Word Order: " + ReverseWordOrder_Way(inputString2));
        Console.WriteLine("Reversed Word Order : " + ReverseWordOrder_Way(inputString3));
        Console.ReadLine();
    }

  

 public  static string ReverseWordOrder_Way(string inputString)
    {
        string reversedWordOrder = "";
        string word = "";

        for (int i = inputString.Length - 1; i >= 0; i--)
        {
            if (inputString[i].ToString() != " ")
                word = inputString[i] + word;
            else
            {
                reversedWordOrder = reversedWordOrder + " " + word;
                word = "";
            }
        }

        reversedWordOrder = reversedWordOrder + " " + word;
        return reversedWordOrder.Trim();
    }

   
}