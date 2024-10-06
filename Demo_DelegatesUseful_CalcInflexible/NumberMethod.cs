using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
* CREDIT: This code is made by a teacher at UCN.
* I used it as a code along session to get to know the code.
* 
* This code ensures that invalid inputs are handled gracefully by returning a default value instead of throwing an exception.
*/


namespace Demo_DelegatesUseful_CalcInflexible
{
    public class NumberMethod
    {
        /*
         * Defines a static method 'GetStringAsDecimal' that takes two parameters:
         * 1. 'inText': A string that represents the number to be converted to decimal.
         * 2. 'defaultVal': A default decimal value to return if the conversion fails.
         * The method returns a decimal value.
         */
        public static decimal GetStringAsDecimal(string inText, decimal defaultVal)
        {
            /* 
             * 'wasOk' is a boolean variable that stores the result of trying to parse 'inText' to a decimal.
             * 'decimal.TryParse' tries to convert the string 'inText' into a decimal.
             * If successful, the parsed value is assigned to 'foundDecimal'.
             * If it fails, 'wasOk' is false, and 'foundDecimal' is not assigned.
            */
            bool wasOk = decimal.TryParse(inText, out decimal foundDecimal);

            /*
             * Checks if the parsing of the string to a decimal failed (i.e., 'wasOk' is false).
             */
            if (!wasOk)
            {
                // If the conversion fails, assign 'foundDecimal' the default value 'defaultVal'.
                foundDecimal = defaultVal;
            }

            /* Returns the value of 'foundDecimal'.
             * If parsing succeeded, this will be the decimal representation of 'inText'.
             * If parsing failed, this will be the 'defaultVal'.
            */
            return foundDecimal;
        }
    }
}
