using Exercise_DelegatesAndGui_UpdateList.Model;

/* 
* CREDIT: This code is made by a teacher at UCN.
* I used it as a code along session to get to know the code.
* 
* DetailPage allows users to input their first name, last name, and select an ID from a dropdown list.
* Once valid input is provided, the OnNameInput method raises an event (NameInput) that sends the Person object to any subscribers.
* The form follows the publish-subscribe pattern where DetailPage is the publisher and another form (like ListPage) 
* can subscribe to handle the event when a new person is added.
* The dropdown is populated with a list of available IDs from the IdleIds list.
* After submission or form closure, the subscriber form (ListPage) is displayed again.
*/

namespace Exercise_DelegatesAndGui_UpdateList
{
    public partial class DetailPage : Form
    {
        /*
         * NameInput: This is an event of type EventHandler<PersonEventArgs>. 
         * It allows subscribers (other classes like ListPage) to handle the event and receive the Person object when raised.
         * 
         * _subscriberForm: This holds a reference to the ListPage, which is another form. 
         * It will be shown after data input is complete.
         * 
         * IdleIds: This is a list of integers representing available IDs. 
         * It is used to populate a dropdown list (likely a combo box) where the user can select an ID.
         */
        public EventHandler<PersonEventArgs> NameInput;
        ListPage _subscriberForm;

        public List<int> IdleIds { get; set; }

        
         /* DetailPage constructor: 
         * This takes two arguments: a reference to the previous ListPage form and a list of available IDs.
         * 
         * InitializeComponent(): 
         * This initializes the form and its controls (e.g., text boxes, buttons).
         * 
         * _subscriberForm = prevPage: 
         * It stores the reference to the previous page and hides it until the current form (DetailPage) is closed or completed.
         * 
         * IdleIds = ids: 
         * The list of available IDs is assigned to IdleIds.
         * 
         * PopulateIdControl(): 
         * This method is called to populate a dropdown with the list of available IDs.
         */
        public DetailPage(ListPage prevPage, List<int> ids)
        {
            InitializeComponent();

            _subscriberForm = prevPage;
            prevPage.Hide();

            IdleIds = ids;
            PopulateIdControl();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            string firstName = tbFirst.Text;
            string lastName = tbLast.Text;
            if (!string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName) && (dropdownIds.SelectedItem != null || dropdownIds.Text != null))
            {
                int foundId;
                bool isInt = int.TryParse(dropdownIds.Text, out foundId);
                if (isInt)
                {
                    Person aPerson = new Person(foundId, firstName, lastName);
                    OnNameInput(aPerson);
                    _subscriberForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Input is missing!", "Sorry, but ..");
            }
        }

        /*
         * Purpose: 
         * This method raises the NameInput event, passing a PersonEventArgs object that contains 
         * the Person object created with the input data.
         * 
         * NameInput?.Invoke: 
         * This is a shorthand for invoking the event only if there are subscribers. 
         * It passes the current instance (this) as the sender and a new PersonEventArgs object with the Person data.
         * 
         * If any class has subscribed to this event (e.g., ListPage), it will handle the event and act on the data.
         */
        protected virtual void OnNameInput(Person inPerson)
        {
            NameInput?.Invoke(this, new PersonEventArgs() { 
                Person = inPerson 
            });
        }

        /*
         * Purpose: 
         * This method populates a dropdown list with available IDs from the IdleIds list.
         * 
         * For Each Loop: It iterates over the list of IDs and adds them as items in the dropdown control (dropdownIds).
         */
        private void PopulateIdControl()
        {
            foreach (int id in IdleIds)
            {
                dropdownIds.Items.Add(id);
            }
        }

        /*
         * Purpose: This method is executed when the DetailPage is closed. 
         * It ensures that the ListPage (stored in _subscriberForm) is made visible again when the current form is closed.
         */
        private void OnClose(object sender, FormClosedEventArgs e)
        {
            _subscriberForm.Show();
        }
    }
}