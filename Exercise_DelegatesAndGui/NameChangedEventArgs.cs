using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
* CREDIT: This code is made by a teacher at UCN.
* I used it as a code along session to get to know the code.
*/
namespace Exercise_DelegatesAndGui
{
    /*
     * The class extends EventArgs, which is a base class used for passing event data in .NET. 
     * This makes NameChangedEventArgs suitable to be passed as an argument in event handlers.
     */
    public class NameChangedEventArgs : EventArgs
    {
        /*
         * The class contains two read-only properties (init-only, meaning they can only be set during object initialization)
         * 
         * The init keyword in C# is used to define an init-only property, which allows the property to be 
         * set only during object initialization (i.e., when the object is created). 
         * After the initialization phase, the property becomes immutable, meaning it cannot be modified.
         * 
         * init provides a more restrictive way of setting properties compared to set. 
         * While a set accessor allows properties to be changed at any point, an init accessor limits 
         * the assignment of the property value to the moment when the object is created or initialized.
         */
        public string FirstName { get; init; }
        public string LastName { get; init; }

        /*
         * Constructor
         */
        public NameChangedEventArgs(string inFirstName, string inLastName)
        {
            FirstName = inFirstName;
            LastName = inLastName;
        }
    }
}
