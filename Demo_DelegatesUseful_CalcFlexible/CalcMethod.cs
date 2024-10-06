using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
* CREDIT: This code is made by a teacher at UCN.
* I used it as a code along session to get to know the code.
* 
* CalcMethods Property: 
* This property returns a list of all possible calculation methods (enumerated in CalcMethodEnum). 
* It uses Enum.GetValues to get all enum values, casts them to an array, then converts this array to a list for easy use.
* 
* SomeCalculation Delegate: 
* This delegate defines a function signature, i.e., it expects methods that take two decimal numbers and return a decimal. 
* This is used to dynamically assign methods at runtime based on user selection.
* 
* Calculation Method: 
* This method accepts a SomeCalculation delegate (a method that matches the delegate signature) and two numbers. 
* It invokes the delegate method, effectively performing the desired calculation.
* 
* GetCalcDel Method: 
* This method accepts a CalcMethodEnum value (which specifies the desired calculation) and returns the corresponding 
* delegate method. It uses a switch statement to determine which calculation method should be used based on 
* the enum value. 
* 
* If the selected method is:
* Addition: It returns the CalcAddition method.
* Division: It returns a lambda expression that divides two numbers.
* Multiplication: It returns a lambda expression that multiplies two numbers.
* MSpecial: It returns a lambda expression for a custom calculation (multiplying the first number by 100 and then by the second number).
* CalcAddition Method: This is a private helper method that performs the addition of two numbers. 
* It is used when the Addition enum value is selected.
* 
* This design allows the CalcMethod class to dynamically handle multiple types of calculations by 
* selecting the appropriate delegate method at runtime based on user input.
*/

namespace Demo_DelegatesUseful_CalcFlexible
{
    // Class definition for CalcMethod, which provides different calculation methods
    public class CalcMethod
    {

        // Public property that returns a list of all possible calculation methods (from CalcMethodEnum)
        public List<CalcMethodEnum> CalcMethods
        {
            get
            {
                // Retrieve all values from the CalcMethodEnum and cast them to an array
                CalcMethodEnum[] calcEnums = (CalcMethodEnum[])Enum.GetValues(typeof(CalcMethodEnum));

                // Convert the array of enum values to a List<CalcMethodEnum> and store it in foundMethods
                List<CalcMethodEnum> foundMethods = calcEnums.ToList<CalcMethodEnum>();

                // Return the list of available calculation methods
                return foundMethods;
            }
        }

        // Declare a delegate named SomeCalculation that takes two decimal parameters and returns a decimal
        public delegate decimal SomeCalculation(decimal n1, decimal n2);

        // Method that accepts a delegate of type SomeCalculation and two decimal values
        // It invokes the delegate (which represents a calculation method) and returns the result
        public decimal Calculation(SomeCalculation calcMethod, decimal n1, decimal n2)
        {
            return calcMethod(n1, n2); // Perform the calculation by calling the delegate
        }

        // Method that returns a specific calculation delegate based on the selected calculation method (from enum)
        public SomeCalculation GetCalcDel(CalcMethodEnum selMethod)
        {
            // Declare a delegate variable to hold the appropriate calculation method
            SomeCalculation foundDelegate = null;

            // Switch statement to assign the appropriate delegate method based on the selected enum value
            switch (selMethod)
            {
                // Case for addition - assign the CalcAddition method to the delegate
                case CalcMethodEnum.Addition:
                    foundDelegate = CalcAddition;
                    break;

                // Case for division - use a lambda expression for division and assign it to the delegate
                case CalcMethodEnum.Division:
                    foundDelegate = (n1, n2) => n1 / n2;
                    break;

                // Case for multiplication - use a lambda expression for multiplication and assign it to the delegate
                case CalcMethodEnum.Multiplication:
                    foundDelegate = (n1, n2) => n1 * n2;
                    break;

                // Case for a special multiplication method (MSpecial) - perform custom multiplication
                case CalcMethodEnum.MSpecial:
                    foundDelegate = (n1, n2) => (n1 * 100) * n2;
                    break;
            }

            // Return the found delegate (which is now set to the appropriate calculation method)
            return foundDelegate;
        }

        // Private method to perform addition, matches the delegate signature
        private decimal CalcAddition(decimal num1, decimal num2)
        {
            return (num1 + num2); // Return the sum of the two numbers
        }
    }
}
