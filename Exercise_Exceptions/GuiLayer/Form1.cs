using Exercise_Exceptions.ControlLayer;

namespace Exercise_Exceptions
{
    /*
     * Form1 is a graphical user interface (GUI) class in a Windows Forms application.
     * 
     * It handles user input through a text box where the user enters a product name, and provides feedback 
     * through a label showing whether the product was saved successfully.
     * 
     * The class communicates with the control layer to handle the business logic of saving a product to 
     * the database (or simulating this operation), and then displays the result to the user.
     */
    public partial class Form1 : Form
    {
        // Declares a private field of type ProductInsert, which handles product-related operations
        private ProductInsert _productUpdate;   
        
        // Constructor for Form1
        public Form1()
        {   
            // Calls the method that initializes the graphical components of the form (generated by the designer)
            InitializeComponent();   

            // Initializes the _productUpdate field with a new instance of ProductInsert
            _productUpdate = new ProductInsert();   
        }

        /*
         * Event handler for the button click event, triggered when the "Save" button is clicked
         */
        private void BtnSave_Click(object sender, EventArgs e)
        {   
            // Retrieves the text entered by the user in the textBoxProduct field (presumed to be a text input box)
            string prodRaw = textBoxProduct.Text;

            // Input "sanity check" deliberately avoided
            // The comment suggests no validation is performed on the input (e.g., checking for empty strings or invalid characters)

            // Calls the SaveProduct method from _productUpdate to save the product
            // Passes the product name entered by the user, and stores the result message in saveText
            string saveText = _productUpdate.SaveProduct(prodRaw);   
                         
            // Displays the result of the save operation in the lblResult label (presumed to be a label element in the form)
            lblResult.Text = saveText;
        }
    }
}
