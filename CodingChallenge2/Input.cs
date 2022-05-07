using System;
using Exceptions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Week2Assignment2
{
    class Input
    {
        /// <summary>
        /// This function asked for the positive integer and if user doesn't enter correct integer then
        /// it ask to enter again
        /// </summary>
        /// <returns></returns>
        public static int PositiveInteger()
        {
            int num = -1;
            do
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num < 0)
                        throw new NumberNegativeException("Number is Negative Enter Again");
                }
                catch (NumberNegativeException exception)
                {
                    Console.WriteLine(exception);
                }
                catch (System.FormatException exception)
                {
                    Console.WriteLine("Incorrect data type Enter Again " + exception);
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Enter Again " + exception);
                }
            } while (num <= 0);
            return num;

        }

        /// <summary>
        /// This function is used to input double number
        /// until its a positive double
        /// </summary>
        /// <returns></returns>
        public static double PositiveDouble()
        {
            double num = -1;
            do
            {
                try
                {
                    num = Convert.ToDouble(Console.ReadLine());
                    if (num < 0)
                        throw new NumberNegativeException("Number is Negative Enter Again");
                }
                catch (NumberNegativeException exception)
                {
                    Console.WriteLine(exception);
                }
                catch (System.FormatException exception)
                {
                    Console.WriteLine("Incorrect data type Enter Again " + exception);
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Enter Again " + exception);
                }
            } while (num <= 0);
            return num;
        }

        /// <summary>
        /// This is used to input string that doesn't contain any number
        /// and if so then ask again and also convert into title case
        /// </summary>
        /// <returns></returns>
        public static string StringInput()
        {
            string str = null;

            do
            {
                try
                {
                    str = Console.ReadLine();
                    str = ConvertTitlecase(str);
                    if (str == null)
                        throw new StringContainDigit("String Contain Digit");
                }
                catch (StringContainDigit exception)
                {
                    Console.WriteLine(exception);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);

                }
            } while (str == null);

            return str;
        }

        /// <summary>
        /// It is used to convert string to title case and if it contain digit then return null
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private static string ConvertTitlecase(string name)
        {
            if (name.Any(char.IsDigit))     //Contain Digit
                return null;

            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            name = textInfo.ToTitleCase(name);      //Title Case
            return name;
        }
    }
}
