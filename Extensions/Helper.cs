using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_StaticExtension_Due1Nov.Extensions
{
    internal static class Helper
    {
        public static string PromptAndGetNonEmptyString(string prompt)
        {
            string input = null;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();

                if(String.IsNullOrWhiteSpace(input) || input == string.Empty)
                    Console.WriteLine("Empty input is not allowed!");

            } while (String.IsNullOrWhiteSpace(input) || input == string.Empty);
            
            return input;
        }

        public static int PromptAndGetPositiveInt(string prompt)
        {
            int input = 0;
            do
            {
                input = Convert.ToInt32(Helper.PromptAndGetNonEmptyString(prompt));

                if (input <= 0)
                    Console.WriteLine("Positive non zero input is required!");

            } while (input < 0);

            return input;
        }

    }
}
