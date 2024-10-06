using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
* CREDIT: This code is made by a teacher at UCN.
* I used it as a code along session to get to know the code.
* 
* Declares a public enum named CalcMethodEnum.
* An enum is a special "value type" in C# that allows you to define a set of named constants.
* This particular enum represents different calculation methods.
* Enums make the code easier to read and maintain, as they replace "magic numbers" 
* (i.e., hardcoded numeric values) with meaningful names. This is particularly useful in a 
* calculator or any system that needs to distinguish between different types of operations.
*/

namespace Demo_DelegatesUseful_CalcInflexible
{
    public enum CalcMethodEnum { 
        NotSet, 
        Addition, 
        Division, 
        Multiplication 
    }
}
