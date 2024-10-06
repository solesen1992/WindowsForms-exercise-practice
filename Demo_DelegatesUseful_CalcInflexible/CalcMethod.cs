using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
* CREDIT: This code is made by a teacher at UCN.
* I used it as a code along session to get to know the code.
* 
* This class provides basic arithmetic functionality for addition, division, and multiplication, 
* and a list of available operations that can be performed.
*/

namespace Demo_DelegatesUseful_CalcInflexible
{
    public class CalcMethod
    {
        // Declares a public class named CalcMethod. This class will contain methods for various calculations and a property for calculation methods.

        public List<CalcMethodEnum> CalcMethods
        {
            // Defines a public property named CalcMethods, which is a list of CalcMethodEnum values.
            // The property will expose a list of supported calculation methods.

            get
            {
                // The getter allows access to the CalcMethods property.

                List<CalcMethodEnum> foundMethods = new List<CalcMethodEnum> {
                    // Declares and initializes a list of CalcMethodEnum with four values. This list contains the available calculation methods.
                    CalcMethodEnum.NotSet,          // First enum value, indicating no method is set.
                    CalcMethodEnum.Addition,        // Enum value for addition.
                    CalcMethodEnum.Division,        // Enum value for division.
                    CalcMethodEnum.Multiplication   // Enum value for multiplication.
                };

                return foundMethods;
                // Returns the list of calculation methods.
            }
        }

        public decimal CalcAddition(decimal num1, decimal num2)
        {
            // Declares a method named CalcAddition that takes two decimal numbers as parameters and returns a decimal result.
            // This method performs the addition of num1 and num2.

            return (num1 + num2);
            // Returns the sum of the two decimal numbers.
        }

        public decimal CalcDivision(decimal num1, decimal num2)
        {
            // Declares a method named CalcDivision that takes two decimal numbers as parameters and returns a decimal result.
            // This method performs division of num1 by num2.

            return (num1 / num2);
            // Returns the result of dividing num1 by num2.
        }

        public decimal CalcMultiplication(decimal num1, decimal num2)
        {
            // Declares a method named CalcMultiplication that takes two decimal numbers as parameters and returns a decimal result.
            // This method performs multiplication of num1 and num2.

            return (num1 * num2);
            // Returns the product of num1 and num2.
        }
    }
}
