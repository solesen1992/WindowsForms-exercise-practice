using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
* CREDIT: This code is made by a teacher at UCN.
* I used it as a code along session to get to know the code.
* 
* The method attempts to parse a string to a decimal and returns the decimal value.
* If parsing fails, it returns a default value provided by the caller.
*/

namespace Demo_DelegatesUseful_CalcFlexible
{
    public class NumberMethod
    {
        // Declares a static method GetStringAsDecimal that takes a string (inText) and a decimal (defaultVal) as input parameters.
        // The method returns a decimal value.
        public static decimal GetStringAsDecimal(string inText, decimal defaultVal)
        {
            // foundDecimal is declared and assigned a value based on whether the string inText can be successfully parsed as a decimal.
            // Tries to convert inText into a decimal. If successful, the result is stored in foundDecimal, and wasOk is set to true.
            bool wasOk = decimal.TryParse(inText, out decimal foundDecimal);
            
            // Checks if the string could not be parsed as a decimal (wasOk is false).
            if (!wasOk)
            {   
                // If parsing fails, set foundDecimal to the defaultVal parameter value provided by the caller.
                foundDecimal = defaultVal;
            }
            // Returns the foundDecimal value, either the parsed decimal or the default value if parsing failed.
            return foundDecimal;
        }
    }
}