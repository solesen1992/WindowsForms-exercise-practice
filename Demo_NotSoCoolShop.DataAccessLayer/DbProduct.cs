using Demo_NotSoCoolShop.DataAccessLayer.Interfaces;
using Demo_NotSoCoolShop.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Should communicate with the database and make the CRUD functionality
 */

namespace Demo_NotSoCoolShop.DataAccessLayer
{
    public class DbProduct : ICRUD<Product>
    {
        // Can use classes from system.configuration to get something out of our configuration file.
        // Gets all the tags from the app.config connectionstring
        // Now we can re-use the connectionstring every time we use a sqlconnection in this class
        private string _connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString; 

        public void Create(Product entity)
        {
            // Database connection. Gets disposed / closed when we're done with it.
            using (SqlConnection connection = new SqlConnection(_connectionString)) 
            {
                // Communicate with the database
                // Open the connection
                connection.Open();
                // Command with using
                using (SqlCommand cmd = connection.CreateCommand()) 
                {
                    // Preventing sql injections
                    cmd.CommandText = "INSERT INTO Product (Title, Price) VALUES (@title, @price)";
                    // Add value from parameters. On the title space, input what's in the entity space. Prevents SQL injections.
                    cmd.Parameters.AddWithValue("title", entity.Title);
                    cmd.Parameters.AddWithValue("price", entity.Price);
                    // ExecuteNonQuery because we don't expect to get something back from the create method.
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            // List to store created objects
            List<Product> products = new List<Product>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand()) 
                {
                    cmd.CommandText = "SELECT Id, Title, Price FROM Product";
                    // DataReader returns a SQL data reader. Should save the datareader in a variable. The result is basically a table where you can read every line.
                    SqlDataReader reader = cmd.ExecuteReader();
                    // The reader returns a boolean.
                    reader.Read();
                    while (reader.Read()) 
                    {
                        // My one object - it makes it until there's no more rows
                        Product product = new Product();
                        // Get the id from product
                        // Reader get me the number that belongs to "Id"
                        product.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                        product.Title = reader.GetString(reader.GetOrdinal("Title"));
                        product.Price = reader.GetDecimal(reader.GetOrdinal("Price"));
                        //Add product to list
                        products.Add(product);
                    }
                }
            }
            return products;
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
