using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_Exceptions.ModelLayer;
using System.Diagnostics;

namespace Exercise_Exceptions.DatabaseLayer
{
    public class ProductUpdate<T> : IManipulate<T> where T : IProduct
    {
        // Products are not saved. Instead the saving is simulated by this:
        public int Save(T someData)
        {
            int numProductsSaved = 0;
            Debug.WriteLine($"Saved: {someData}");
            char? letter1 = null;
            try
            {
                letter1 = someData.ProductName?.Trim()[0];
            }
            catch
            {
                throw new Exception("Bad input");
            }
            Debug.WriteLine($"First letter: {letter1}");
            numProductsSaved++;
            return numProductsSaved;
        }
    }
}
