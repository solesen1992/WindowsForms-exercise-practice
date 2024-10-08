// Importing necessary namespaces for various functionalities
using System; // Basic system utilities like string formatting, conversions, etc.
using System.Collections.Generic; // Enables the use of generic collections like List<T>
using System.ComponentModel; // Provides functionality for runtime and design-time behavior of components
using System.Data; // Provides access to data from databases or other sources
using System.Drawing; // Provides access to drawing methods, color, fonts, etc.
using System.Linq; // Provides LINQ (Language-Integrated Query) functionality for collections
using System.Text; // Provides encoding and string manipulation functionalities
using System.Threading.Tasks; // Provides support for asynchronous programming
using System.Windows.Forms; // Provides access to Windows Forms elements like buttons, labels, textboxes
using static Demo_DelegatesUseful_CalcFlexible.CalcMethod; // Imports the static members of CalcMethod directly into the current scope

/*
* CREDIT: This code is made by a teacher at UCN.
* I used it as a code along session to get to know the code.
* 
* The code defines a GUI that allows users to input two numbers, select a calculation method from 
* a drop-down menu, and see the result. The program dynamically chooses the appropriate calculation based on user input.
*/

namespace Demo_DelegatesUseful_CalcFlexible
{
    // The Form1 class inherits from the Form class (for Windows Forms UI)
    public partial class Form1 : Form
    {

        // Constructor for the Form1 class
        public Form1()
        {
            InitializeComponent(); // Initialize the form components (auto-generated by the Windows Forms designer)

            SetComboBoxValues(); // Populate comboBox with available calculation methods
            comboBoxCalcMethod.SelectedIndex = 0; // Set the default selected index of the comboBox to the first item
        }

        // Event handler for when the selected index of comboBoxCalcMethod changes
        private void ComboBoxCalcMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the text from textBoxNumber1 and textBoxNumber2
            string rawNumber1 = textBoxNumber1.Text; // Retrieve the input from the first textbox as a string
            string rawNumber2 = textBoxNumber2.Text; // Retrieve the input from the second textbox as a string

            // Convert the input strings into decimal values, specifying a fallback value if the conversion fails
            decimal fineNumber1 = NumberMethod.GetStringAsDecimal(rawNumber1, 2); // Convert rawNumber1 to decimal, defaulting to 2 if invalid
            decimal fineNumber2 = NumberMethod.GetStringAsDecimal(rawNumber2, 1); // Convert rawNumber2 to decimal, defaulting to 1 if invalid

            // Cast the selected item in the comboBox to the CalcMethodEnum type
            CalcMethodEnum selMethod = (CalcMethodEnum)comboBoxCalcMethod.SelectedItem; // Retrieve the selected calculation method from the comboBox

            // Initialize a decimal variable to hold the result of the calculation
            decimal calcResult = 0;

            // Create an instance of CalcMethod to access calculation logic
            CalcMethod cm = new CalcMethod();

            // Check if a valid calculation method has been selected
            if (selMethod != CalcMethodEnum.NotSet)
            {
                // Retrieve the delegate corresponding to the selected calculation method
                SomeCalculation methodToUse = cm.GetCalcDel(selMethod);

                // Perform the calculation using the selected method and the two decimal numbers
                calcResult = cm.Calculation(methodToUse, fineNumber1, fineNumber2);

                // Display the result in the label, formatted as a string with 3 decimal places
                labelCalcResult.Text = selMethod.ToString() + " result = " + String.Format("{0:#,0.000}", calcResult);
            }
            else
            {
                // If no valid method is selected, display a message prompting the user to select one
                labelCalcResult.Text = "Select calculation method";
            }
        }

        // Method to populate the comboBox with available calculation methods
        private void SetComboBoxValues()
        {
            // Create an instance of CalcMethod to access the list of methods
            CalcMethod calcMethod = new CalcMethod();

            // Loop through each CalcMethodEnum value and add it to the comboBox items
            foreach (CalcMethodEnum cme in calcMethod.CalcMethods)
            {
                comboBoxCalcMethod.Items.Add(cme); // Add each calculation method to the comboBox
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
