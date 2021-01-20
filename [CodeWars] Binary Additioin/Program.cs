using System;

namespace _CodeWars__Binary_Additioin
{
    public static class Kata
    {
        public static string AddBinary(int firstTerm, int secondTerm)
        {
            firstTerm += secondTerm;
            String temporaryVariable = "";
            while (firstTerm > 0)
            {
                temporaryVariable += (firstTerm % 2).ToString();
                firstTerm /= 2;
            }
            String returnValue = "";
            for (int index = temporaryVariable.Length - 1; index >= 0; index--)
            {
                returnValue += temporaryVariable[index];
            }
            return returnValue;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.AddBinary(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine())));
        }
    }
}
