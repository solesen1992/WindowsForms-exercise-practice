using Exercise_Exceptions.AppGeneral;
using Exercise_Exceptions.DatabaseLayer;
using Exercise_Exceptions.ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Exceptions.ControlLayer
{
    /*
     * The class manages the interaction between the application's user interface or business logic 
     * and the data layer where products are stored.
     * 
     * It provides a method (SaveProduct) that attempts to save a product by its name and returns 
     * a message indicating whether the operation was successful or not.
     */
    public class ProductInsert
    {
        // Declaring a private readonly field to handle product saving operations
        private readonly IManipulate<IProduct> _saveProd;
        
        /* 
         * Constructor
         */
        public ProductInsert()
        {   
            // Initializing the _saveProd field with an instance of ProductUpdate implementing IManipulate<IProduct>
            _saveProd = new ProductUpdate<IProduct>();
        }

        /* 
         * Method to save a product by its name and return a status message
         */
        public string SaveProduct(string prodName)
        {   
            // Declaring a variable to hold the result message
            string saveText;   

            // Creating a new product object
            IProduct newProd = new Product
            {   
                // Setting the ProductName property with the passed product name
                ProductName = prodName   
            };

            // Declaring an integer to store the number of affected rows (indicating save success or failure)
            int rowsAffected;

            // Starting a try block to attempt the product save operation
            try
            {   
                // Attempting to save the product using the Save method from _saveProd
                rowsAffected = _saveProd.Save(newProd);   

                // Using a ternary operator to check if rowsAffected > 0 (successful save) or not (failure)
                saveText = (rowsAffected > 0) ? $"Product {prodName} was saved" : "Failure - not saved!";
            }
            // Catch block to handle InvalidSaveInDbException specifically
            catch (InvalidSaveInDbException invalidSaveEx)
            {   
            // Assigning the exception's message to saveText if an exception occurs
                saveText = invalidSaveEx.Message;   
            }

            // Returning the result message (either success or failure)
            return saveText;   
        }
    }
}
