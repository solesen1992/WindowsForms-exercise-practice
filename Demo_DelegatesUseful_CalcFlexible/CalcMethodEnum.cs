using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
* CREDIT: This code is made by a teacher at UCN.
* I used it as a code along session to get to know the code.
* 
* Enum CalcMethodEnum: 
* An enumeration (enum) is a distinct type that consists of a set of named constants, called the enumerator list. 
* In this case, CalcMethodEnum defines a list of possible calculation methods.
* 
* Enumerator values: The enum contains four values:
* NotSet: Represents a default or unset calculation method.
* Addition: Represents the addition operation.
* Division: Represents the division operation.
* Multiplication: Represents the multiplication operation.
* MSpecial: Likely represents a custom or special calculation method. 
* The exact meaning of "MSpecial" is not provided in the code snippet.
*/

namespace Demo_DelegatesUseful_CalcFlexible
{
    public enum CalcMethodEnum { 
        NotSet, 
        Addition, 
        Division, 
        Multiplication, 
        MSpecial 
    }
}
