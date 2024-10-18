using Demo_NotSoCoolShop.BusinessLogic;
using Demo_NotSoCoolShop.Domain;

namespace Demo_NotSoCoolShop.UserInterface
{
    public partial class Form1 : Form
    {
        // Needs to get a connection to the controller to use the create method
        private ProductController _productController = new ProductController();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Has the user put something in?
            // If my title and price is not null
            if (!string.IsNullOrEmpty(txtTitle.Text) && !string.IsNullOrEmpty(txtPrice.Text))
            {

                // Our price should be converted from a string to a decimal
                decimal price = -1; //No price is set right now

                // Checks if the user has put in a valid decimal. If it's valid we get into the 'if' statement. It puts the value into price.
                // It returns true if it can pass this. Then it puts the value in price. Otherwise it does something else.
                if (decimal.TryParse(txtPrice.Text, out price))
                {
                    // We put the value into the product and create the product.
                    Product newProduct = new Product { Price = price, Title = txtTitle.Text };
                    _productController.Create(newProduct);

                    // When we create a product, we can also update the listbox again.
                    UpdateProductListBox();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateProductListBox();
        }

        public void UpdateProductListBox() 
        {
            var allProducts = _productController.GetAll();

            // Clear the listBox before we update the list so we don't get a dublicated list.
            lbProducts.Items.Clear();

            // Should take the products and put it into the listbox
            foreach (Product product in allProducts)
            {
                lbProducts.Items.Add(product);
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
