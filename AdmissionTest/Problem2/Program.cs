using System;

namespace Problem2
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var text= number.ToEnglishNumber();
            Console.WriteLine(text);
        }
    }
    public static class Converter
    {
        public static string ToEnglishNumber(this int number)
        {
            if (number == 1)
                return "One";
            else if (number == 2)
                return "Two";
            else if (number == 3)
                return "Three";
            else if (number == 4)
                return "Four";
            else if (number == 5)
                return "Five";
            else if (number == 6)
                return "Six";
            else if (number == 7)
                return "Seven";
            else if (number == 8)
                return "Eight";
            else
                return "Nine";
        }
    }
}
