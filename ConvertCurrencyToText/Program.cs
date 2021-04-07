﻿using Humanizer;
using System;
using System.Globalization;

namespace ConvertCurrencyToText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convert Currency To Text description!");
            
            // Values to test
            double[] darr = { 2.5, 2.05, 12.12 ,23.2, 2, 2.0, 0.23, 2.2, 1, 2323,1.1,2.1,1.5,0.1,0.98,13239.12,20000.00,1234567.89,23,3,4,5,9.99 };

            TestArrayOfCurrencyToText(darr, "pt-pt", "euro", "euros", "cêntimo", "cêntimos", "e");
            TestArrayOfCurrencyToText(darr, "en-en", "euro", "euros", "cent", "cents","and");
            TestArrayOfCurrencyToText(darr, "fr-fr", "euro", "euros", "centime", "centimes","e");
            TestArrayOfCurrencyToText(darr, "es-es", "euro", "euros", "centimo", "céntimos","con");
            
        }
        /// <summary>
        /// Converts an Array of currency values to their writen descrition 
        /// </summary>
        /// <param name="darr">The array of currency values</param>
        /// <param name="language">the local description eg pt-pt</param>
        /// <param name="currencyOne">Currency name in singular, eg Euro, Dolar</param>
        /// <param name="currencyMany">Currency name in Plural, eg Euros, Dolars</param>
        /// <param name="centOne">The name of one cent in the given culture</param>
        /// <param name="centMany">The name of cents in the given culture</param>
        /// <param name="andstring">The "and" separator in that language for X euros "and" Y cents</param>
        private static void TestArrayOfCurrencyToText(double[] darr, string language, string currencyOne, string currencyMany, string centOne, string centMany, string andstring)
        {
            Console.WriteLine($"Language: {language}");
            foreach (double d in darr)
            {
                Console.WriteLine(d + " \t = \t" + ConvertCurrencyToText(d, language,currencyOne,currencyMany,centOne,centMany, andstring));
                //Console.WriteLine($"new CurrencyDesc({d} , \"{ConvertCurrencyToText(d, language, currencyOne, currencyMany, centOne, centMany, andstring)}\"),");
            }
            Console.WriteLine();
        }


        /// <summary>
        /// Converts a currency double to it's written representation (assumes a double with 2 fractional digits)
        /// </summary>
        /// <param name="amount">The currency amount to convert to text description</param>
        /// <param name="culture">the culture that will be used to convert</param>
        /// <param name="currencyOne">Currency name in singular, eg Euro, Dolar</param>
        /// <param name="currencyMany">Currency name in Plural, eg Euros, Dolars</param>
        /// <param name="centOne">The name of one cent in the given culture</param>
        /// <param name="centMany">The name of cents in the given culture</param>
        /// <param name="andstring">The "and" separator in that language for X euros "and" Y cents</param>
        /// <returns>The written description of the currency in that language</returns>
        public static string ConvertCurrencyToText(double amount, string culture, string currencyOne, string currencyMany,string centOne, string centMany, string andstring)
        {
            //Using https://github.com/Humanizr/Humanizer

            CultureInfo cultureInfo = CultureInfo.GetCultureInfo(culture);

            long integerPart = (long)Math.Truncate(amount);
            string amountStr = amount.ToString("#.##", cultureInfo);
           
            //Get the decimal separator the specified culture
            char[] sep = cultureInfo.NumberFormat.NumberDecimalSeparator.ToCharArray();

            //Split the string on the separator 
            string[] segments = amountStr.Split(sep);
            

            switch (segments.Length)
            {
                //Only one segment, so there was not fractional value
                case 1:
                    return integerPart.ToWords(cultureInfo) + OneOrManyCurrency(integerPart,currencyOne, currencyMany);

                //Two segments, so return the length of the second segment
                case 2:
                    
                    int fractionalPart = Convert.ToInt32(segments[1]);
                    if (segments[1].Length == 1) { fractionalPart *= 10; }; //to convert 2.5 to 2.50
                    if (integerPart == 0) 
                    { return fractionalPart.ToWords(cultureInfo) + OneOrManyCurrency(fractionalPart,centOne,centMany);
                    }
                    else 
                    {
                        return integerPart.ToWords(cultureInfo) + OneOrManyCurrency(integerPart, currencyOne, currencyMany) + " "+ andstring+" " + fractionalPart.ToWords(cultureInfo) + OneOrManyCurrency(fractionalPart, centOne, centMany); ;
                    }
                    
                //More than two segments means it's invalid, so throw an exception
                default:
                    throw new Exception("Something bad happened in ConvertAmountToText!");
            }


        }
        /// <summary>
        /// Returns the unit or multiple description according to the provided value if 1 or many
        /// </summary>
        /// <param name="value">the value to describe</param>
        /// <param name="one">the unit representation</param>
        /// <param name="many">the many representation</param>
        /// <returns>the one or many string</returns>
        private static string OneOrManyCurrency(long value, string one, string many)
        {
            if (value == 1) return " " +one;
            else return " " + many;
        }

    }
}
