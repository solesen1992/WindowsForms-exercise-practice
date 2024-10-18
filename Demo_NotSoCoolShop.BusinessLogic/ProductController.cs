using Demo_NotSoCoolShop.BusinessLogic.Interfaces;
using Demo_NotSoCoolShop.DataAccessLayer;
using Demo_NotSoCoolShop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ProductController should be able to made CRUD and searching for things based on an ID for example.
 */

namespace Demo_NotSoCoolShop.BusinessLogic
{
    public class ProductController : ICRUD<Product>
    {
        // Reference to dbproducts
        private DbProduct _dbProduct = new DbProduct();

        // Should take a product and send it to the data access layer
        public void Create(Product entity)
        {
            // TODO: When we call the controller, we'll validate the business logic. Check the parameters before it gets into the database. No need for the database to do that.

            _dbProduct.Create(entity);
        }

        public void Delete(int id)
        {
            // Returnerer ikke nødvendigvis et resultatset
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        //IEnumerable functions as an interface on a list
        public IEnumerable<Product> GetAll()
        {
            return _dbProduct.GetAll();
        }

        public void Update(Product entity)
        {
            // Returnerer ikke nødvendigvis et resultatset
            throw new NotImplementedException();
        }
    }
}
