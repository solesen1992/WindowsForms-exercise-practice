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
* It follows the publish-subscribe pattern, where the SubscriberForm subscribes to an event (NameInput) raised by PublisherForm.
* 
* When the user clicks the button (BtnGotoNamePage), a PublisherForm is opened, and SubscriberForm subscribes to the NameInput event.
* 
* The NameInputEventHandler method updates the label with the user's first and last name when PublisherForm raises the event.
* 
* The OnVisible method hides the PublisherForm when the SubscriberForm becomes visible again.
* 
* This pattern facilitates communication between the forms using an event-driven approach, where 
* SubscriberForm listens for updates (name input) from PublisherForm.
*/

namespace Exercise_DelegatesAndGui
{
    public partial class SubscriberForm : Form
    {
        // It holds a reference to the PublisherForm that will be created when the user clicks a button.
        PublisherForm inputPage;

        public SubscriberForm()
        {
            InitializeComponent();
        }

        /*
         * Button Click: 
         * This method is triggered when the user clicks a button.
         * 
         * Create PublisherForm: 
         * A new instance of PublisherForm is created, passing this (the current SubscriberForm) 
         * as a parameter to its constructor.
         * 
         * Event Subscription: 
         * The NameInputEventHandler method is subscribed to the NameInput event from PublisherForm. 
         * This means that when PublisherForm raises the NameInput event, the SubscriberForm will 
         * handle it by invoking the NameInputEventHandler method.
         * 
         * Show PublisherForm: 
         * The PublisherForm is made visible using the Show() method.
         */
        private void BtnGotoNamePage_Click(object sender, EventArgs e)
        {
            inputPage = new PublisherForm(this);
            // Subscribe - add event handler to event NameInput invocation list
            inputPage.NameInput += NameInputEventHandler;
            inputPage.Show();
        }

        /* 
         * Event handles complys with delegate EventHandler<NameChangedEventArgs>
         * 
         * Purpose: This method is called when the NameInput event is raised by PublisherForm.
         * 
         * Event Parameters:
         * sender: The object that raised the event (in this case, the PublisherForm).
         * nameChangedData: An instance of NameChangedEventArgs, which contains the user's first name and last name.
         * Update Label: The method updates a label (lblName) on the SubscriberForm to display the first name 
         * and last name provided by the PublisherForm.
         */
        void NameInputEventHandler(object sender, NameChangedEventArgs nameChangedData)
        {
            lblName.Text = $"{nameChangedData.FirstName} {nameChangedData.LastName}";
        }

        /*
         * Purpose: This method hides the PublisherForm when the SubscriberForm becomes visible.
         * Logic: If inputPage (i.e., the PublisherForm) has been initialized, it will be hidden using the Hide() method.
         */
        private void OnVisible(object sender, EventArgs e)
        {
            if (inputPage != null)
            {
                inputPage.Hide();
            }
        }

        private void SubscriberForm_Load(object sender, EventArgs e)
        {

        }
    }
}
