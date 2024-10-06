/* 
* CREDIT: This code is made by a teacher at UCN.
* I used it as a code along session to get to know the code.
* 
* The purpose of this class is to capture user input (first name and last name) and raise an event when the input is valid.
* 
* This form is used to capture first name and last name inputs from the user.
* If both inputs are valid, it raises the NameInput event and switches to another form (_subscriberForm).
* The event uses the custom NameChangedEventArgs class to pass the name data to any event subscribers.
*/

namespace Exercise_DelegatesAndGui
{
    public partial class PublisherForm : Form
    {
        /* Methods with parameters(object sender, NameChangedEventArgs ncEventArgs) can be associated to the event
         * 
         * NameInput is an event of type EventHandler<NameChangedEventArgs>, meaning it can hold references 
         * to methods that match the signature (object sender, NameChangedEventArgs args). 
         * This event will be triggered when the user's name input is validated.
         */
        public event EventHandler<NameChangedEventArgs> NameInput;

        SubscriberForm _subscriberForm;

        /*
         * Constructor
         * 
         * SubscriberForm Parameter: The constructor takes a SubscriberForm object
         * and stores it in the private field _subscriberForm. It then hides the SubscriberForm.
         * 
         * InitializeComponent(): This method initializes the form components (e.g., buttons, text boxes).
         */
        public PublisherForm(SubscriberForm previousPage)
        {
            InitializeComponent();

            _subscriberForm = previousPage;
            previousPage.Hide();
        }

        /*
         * This method is triggered when a button (BtnOk) is clicked. It reads the first name and last name input 
         * from text boxes (tbFirstname and tbLastname).
         * 
         * If both the first and last names are provided, the OnNameInput() method is called to raise the event. 
         * If not, an error message is displayed.
         */
        private void BtnOk_Click(object sender, EventArgs e)
        {
            string firstName = null, lastName = null;
            if (!string.IsNullOrEmpty(this.tbFirstname.Text))
            {
                firstName = this.tbFirstname.Text;
            }
            if (!string.IsNullOrEmpty(this.tbLastname.Text))
            {
                lastName = this.tbLastname.Text;
            }
            if (firstName != null && lastName != null)
            {
                // Call OnNameInput to raise event
                OnNameInput(firstName, lastName);
                _subscriberForm.Show();
            }
            else
            {
                MessageBox.Show("Input is missing!", "Sorry, but..");
            }
        }

        /*
         * OnNameInput(): This method is responsible for raising the NameInput event when both the 
         * first name and last name are provided. It creates a NameChangedEventArgs object containing 
         * the names and checks if there are any subscribers to the event (NameInput != null). 
         * 
         * If there are, it invokes the event, passing the current form (this) as the sender and the 
         * name data encapsulated in NameChangedEventArgs.
         */
        protected virtual void OnNameInput(string fName, string lName)
        {
            NameChangedEventArgs nameChangedEventArgs = new NameChangedEventArgs(fName, lName);
            /* Three syntaxes for calling the associated eventhandlers */
            //if (NameInput != null && NameInput.GetInvocationList().Count() > 0) {
            //    NameInput.Invoke(this, nameChangedEventArgs);
            //}
            if (NameInput != null)
            {
                NameInput(this, nameChangedEventArgs);
            }
            //NameInput?.Invoke(this, nameChangedEventArgs);
        }

        /*
         * OnClose() and PublisherForm_Load(): These are event handlers for when the form is closed or loaded.
         */
        private void OnClose(object sender, FormClosedEventArgs e)
        {

        }

        private void PublisherForm_Load(object sender, EventArgs e)
        {

        }

        private void PublisherForm_Load_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
