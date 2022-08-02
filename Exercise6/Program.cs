using System;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "";
            int i;
            Console.WriteLine("Enter a string");
            str1 = Console.ReadLine();

            string[] sep = str1.Split(' ');
            string mystring = string.Empty;

            for (i = 0; i < sep.Length; i++)
            {
                if (mystring.Length < sep[i].Length)
                {
                    mystring = sep[i];
                }


            }
            Console.WriteLine($"\nThe Longest word is:(mystring)");
            Console.WriteLine();
        }
    }
}
