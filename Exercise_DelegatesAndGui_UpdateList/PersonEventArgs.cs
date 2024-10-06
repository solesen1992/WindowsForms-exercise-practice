using Exercise_DelegatesAndGui_UpdateList.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
* CREDIT: This code is made by a teacher at UCN.
* I used it as a code along session to get to know the code.
* 
* PersonEventArgs is a custom class used to carry additional data (specifically a Person object) when raising events.
* It inherits from EventArgs to be used in event-driven programming, where Person data can be passed to event handlers.
* This class is likely used in a GUI project to respond to updates or changes related to persons.
*/

namespace Exercise_DelegatesAndGui_UpdateList
{
    /* 
     * Custom event args for event handlers
     * EventArgs is a base class for all event data classes, and by extending it,
     * PersonEventArgs can carry custom information when an event is raised.
     */
    public class PersonEventArgs : EventArgs
    {
        /*
         * This property allows you to pass a Person object along with the event when it is triggered. 
         * For example, if an event is raised when a new person is added or updated, the PersonEventArgs 
         * can carry the specific Person object involved.
         */
        public Person Person { get; set; }

    }
}
