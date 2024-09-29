using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Exceptions.AppGeneral
{
    /*
     * The main purpose of this class is to provide a custom error type that makes it easier to identify 
     * and handle errors related specifically to saving data in a database. By using a custom exception, 
     * the application can provide more detailed error messages or handle these errors differently 
     * than other general exceptions.
     */

    // Marks the class as Serializable, allowing it to be serialized and deserialized (important for exception handling across application domains)
    [Serializable]   
    // Defines a custom exception class 'InvalidSaveInDbException' that extends the base 'Exception' class
    public class InvalidSaveInDbException : Exception
    {   
        /* 
         * Default constructor: Initializes a new instance of InvalidSaveInDbException without any message
         */
        public InvalidSaveInDbException() { }   

        /* 
         * Constructor that takes a string message and passes it to the base 'Exception' class
         */
        public InvalidSaveInDbException(string message) : base(message) { }   

        /* 
         * Constructor that takes a message and an inner exception.
         * 
         * The inner exception represents the original exception that led to this exception.
         * This is useful for maintaining the stack trace of exceptions.
         */
        public InvalidSaveInDbException(string message, Exception inner) : base(message, inner) { }

        /* 
         * Constructor for deserializing the exception, allowing it to be properly re-created after being serialized
         * 
         * This constructor allows the exception to be serialized/deserialized during application domain communication, 
         * especially for remote handling or persistence.
        */
        protected InvalidSaveInDbException(
          System.Runtime.Serialization.SerializationInfo info,   
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
