using System;
using System.Linq;

namespace NotSimpleSquareRoot
{
    static class SqrtCalc
    {
        public static string Process (string input)
        {
            double Number1;
            if (double.TryParse(input.Trim( ), out Number1))
                return "Number";

            if (input.Contains("sin") && input.Contains("cos"))
            {
                for (int i = 1; i < input.Length; i++)
                    if (input[i] == 'i' && input[i - 1] != 's')
                        return "Complex";
                //if (input.Contains("sin^2") || input.Contains("cos^2"))
                return "Trigonometry";
            }

            if (input.Any(i => char.IsLetter(i) && i != 'i'))
                return "Complex";

            char[] Signs = { '+', '-', '*', '/', '(', ')' };
            if (input.Any(i => Signs.Contains(i)))
                return "Experssion";




            return "Error";
        }


    }
}