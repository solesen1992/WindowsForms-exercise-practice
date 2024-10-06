// Import necessary namespaces from the .NET framework
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
* CREDIT: This code is made by a teacher at UCN.
* I used it as a code along session to get to know the code.
* 
* Form1 Constructor:
* The constructor initializes the form by calling InitializeComponent(), which is auto-generated 
* when designing the form in Visual Studio. It also populates the combo box with available calculation methods and sets the default selection.
* 
* ComboBox Event Handler:
* ComboBoxCalcMethod_SelectedIndexChanged is triggered whenever the user selects a different calculation method from the combo box.
* The raw input from text boxes is converted to decimal numbers with specific decimal places.
* Depending on the selected calculation method, one of the predefined calculation methods (Addition, Division, Multiplication) is executed.
* The result is displayed on the form, formatted to show thousands separators and three decimal places.
* 
* SetComboBoxValues Method:
* This method populates the combo box with available calculation methods (from CalcMethodEnum) when 
* the form is initialized. Each enum value is added to the combo box.
*/

namespace Demo_DelegatesUseful_CalcInflexible
{
    // Define the partial class Form1, which inherits from Form (a Windows Forms class)
    public partial class Form1 : Form
    {

        // Constructor for the Form1 class
        public Form1()
        {
            // Initialize the form and its components (auto-generated code in Windows Forms)
            InitializeComponent();

            // Set the available values in the combo box when the form loads
            SetComboBoxValues();

            // Set the default selected item in the combo box to the first item (index 0)
            comboBoxCalcMethod.SelectedIndex = 0;
        }

        // Event handler for when the user changes the selected item in the combo box
        private void ComboBoxCalcMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Retrieve the raw input from the first text box (Number 1)
            string rawNumber1 = textBoxNumber1.Text;

            // Retrieve the raw input from the second text box (Number 2)
            string rawNumber2 = textBoxNumber2.Text;

            // Convert the first number string into a decimal with 2 decimal places
            decimal fineNumber1 = NumberMethod.GetStringAsDecimal(rawNumber1, 2);

            // Convert the second number string into a decimal with 1 decimal place
            decimal fineNumber2 = NumberMethod.GetStringAsDecimal(rawNumber2, 1);

            // Get the selected calculation method from the combo box and cast it to the CalcMethodEnum type
            CalcMethodEnum selMethod = (CalcMethodEnum)comboBoxCalcMethod.SelectedItem;

            // Create an instance of the CalcMethod class, which contains the calculation methods
            CalcMethod cm = new CalcMethod();

            // Initialize a variable to store the result of the calculation
            decimal calcResult = 0;

            // Switch statement to determine which calculation method to use based on the selected enum
            switch (selMethod)
            {

                // If the selected method is Addition, call the CalcAddition method from CalcMethod class
                case CalcMethodEnum.Addition:
                    calcResult = cm.CalcAddition(fineNumber1, fineNumber2);
                    break;

                // If the selected method is Division, call the CalcDivision method from CalcMethod class
                case CalcMethodEnum.Division:
                    calcResult = cm.CalcDivision(fineNumber1, fineNumber2);
                    break;

                // If the selected method is Multiplication, call the CalcMultiplication method from CalcMethod class
                case CalcMethodEnum.Multiplication:
                    calcResult = cm.CalcMultiplication(fineNumber1, fineNumber2);
                    break;
            }

            // Update the label with the result of the calculation
            // Format the result with thousand separators and three decimal places (e.g., "1,234.567")
            labelCalcResult.Text = selMethod.ToString() + " result = " + string.Format("{0:#,0.000}", calcResult);

            // Explanation of formatting:
            // - {0:#,0.000} refers to the first variable (calcResult)
            // - #, applies the thousand separator according to locale (e.g., in Denmark, it's a dot)
            // - 0.000 ensures at least one integer (or zero) and exactly three decimal places
        }

        // Method to populate the combo box with available calculation methods
        private void SetComboBoxValues()
        {

            // Create an instance of the CalcMethod class
            CalcMethod calcMethod = new CalcMethod();

            // Loop through each calculation method (enum values) and add them to the combo box
            foreach (CalcMethodEnum cme in calcMethod.CalcMethods)
            {
                comboBoxCalcMethod.Items.Add(cme);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
