using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exercise_DelegatesAndGui_UpdateList.Model;

/* 
* CREDIT: This code is made by a teacher at UCN.
* I used it as a code along session to get to know the code.
* 
* The class ListPage acts as a subscriber in a publish-subscribe pattern. 
* It interacts with DetailPage, a form that collects user input (first name, last name, and ID). 
* The ListPage class subscribes to the NameInput event raised by DetailPage and updates a list of persons when a new entry is added.
*/

namespace Exercise_DelegatesAndGui_UpdateList
{
    public partial class ListPage : Form
    {
        /*
         * _inputPage: 
         * This stores a reference to the DetailPage form, which serves as the publisher that collects user input.
         * 
         * _persons: 
         * This is a list of Person objects that will store the persons created when the NameInput event is triggered.
         */
        DetailPage _inputPage;
        List<Person> _persons;

        /*
         * The constructor initializes the form with InitializeComponent(), setting up all controls and events.
         * 
         * It also ensures that _persons is initialized as an empty list if it hasn’t been initialized yet. 
         * This list will hold all the Person objects received via the event.
         */
        public ListPage()
        {
            InitializeComponent();

            if (_persons == null)
            {
                _persons = new List<Person>();
            }
        }

        /*
         * Purpose: This method is triggered when the user clicks a button ("Go to Name Page") to open the DetailPage form.
         * GetIdleIds(): The method GetIdleIds() generates a list of available IDs and passes it to DetailPage.
         * 
         * Event Subscription:
         * DetailPage is instantiated with this as the parent form and the available IDs.
         * The ListPage subscribes to the NameInput event of DetailPage by adding the OnNameWasEntered method as an event handler.
         * Show Input Page: The _inputPage (an instance of DetailPage) is shown.
         */
        private void BtnGotoNamePage_Click(object sender, EventArgs e)
        {
            List<int> idleIds = GetIdleIds();

            _inputPage = new DetailPage(this, idleIds);        // Publisher
            _inputPage.NameInput += this.OnNameWasEntered;     // Subscribe to event

            _inputPage.Show();
        }

        /*
         * Purpose: This method is triggered when the NameInput event is raised by DetailPage.
         * Event Data: The PersonEventArgs (pE) object passed to this method contains the Person object created in DetailPage.
         * Add Person to List: The received Person object is added to the _persons list.
         * 
         * Update ListView:
         * A new ListViewItem (which represents a person in the UI) is created using the ToString() method of the Person object.
         * This item is added to a ListView control (lvPersons), allowing the user to see the new entry.
         * The Tag property of the item is set to store the PersonEventArgs object, which can be useful for later referencing when selecting or editing a person.
         * Update Header: The label (lblHeadline) is updated to reflect the current count of persons in the list, using a pluralized form of "person" if there is more than one.
         */
        
        /* 
         * This method is the event handler that is triggered when the NameInput event is raised.
         * 'source' refers to the object that raised the event (the event publisher).
         * 'pE' is the event data, which contains the 'Person' object (via PersonEventArgs).
        */

        public void OnNameWasEntered(object source, PersonEventArgs pE)
        {
            // The 'Person' object from the event data (pE) is added to the '_persons' list.
            // This list holds all the person entries collected so far.
            _persons.Add(pE.Person);

            // A new 'ListViewItem' is created to represent the person in the ListView.
            ListViewItem personItem = new ListViewItem
            {
                // The 'Text' property is set to the string representation of the 'Person' object (via the ToString() method).
                Text = pE.Person.ToString(),
                // The 'Tag' property is used to store the event data ('pE'), allowing access to the 'PersonEventArgs' later.
                Tag = pE
            };
            
            // The newly created 'ListViewItem' is added to the 'lvPersons' ListView control.
            // This allows the person to be visually represented in the user interface.
            lvPersons.Items.Add(personItem);
            
            // Conditional operator is used to choose between "persons" (plural) and "person" (singular),
            // depending on whether the count of persons in the list is greater than 1.
            string personText = _persons.Count > 1 ? "persons" : "person";
            
            // The 'lblHeadline' label is updated to show the current number of persons in the list,
            // displaying the text "List of X person(s)", where 'X' is the count of persons.
            lblHeadline.Text = $"List of {_persons.Count} {personText}";
        }

        /*
         * Purpose: This method ensures that when ListPage is visible, DetailPage (i.e., _inputPage) is hidden.
         * Use Case: This prevents both forms from being displayed at the same time when switching between them.
         */
        private void OnVisible(object sender, EventArgs e)
        {
            if (this.Visible && _inputPage != null)
            {
                _inputPage.Hide();
            }
        }

        /*
         * Purpose: This method is triggered when a person is selected from the ListView (lvPersons).
         * Tag Usage: The Tag property, which stores the PersonEventArgs object, is retrieved and cast back to PersonEventArgs.
         * Display Selection: The selected person’s first and last name is displayed in a label (lblNote).
         */
        private void LvPersons_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            PersonEventArgs selPerson = e.Item.Tag as PersonEventArgs;
            Person selectedPerson = selPerson.Person;
            lblNote.Text = $"{selPerson.Person.FirstName} {selectedPerson.LastName} was selected!";
        }

        /*
         * Purpose: This method generates a list of IDs that are not currently used by any person in the _persons list.
         * 
         * Logic:
         * It iterates through numbers (starting from 1) and checks whether each ID is already in use by any person in _persons.
         * If the ID is not in use, it is considered "idle" and added to the foundIds list.
         * The process continues until the required number of IDs (wantedNumberOfIds, set to 10) is found.
         */
        private List<int> GetIdleIds()
        {
            // Defines how many "idle" IDs are needed (10 in this case).
            int wantedNumberOfIds = 10;
            
            // Initializes an empty list to store the found idle IDs.
            List<int> foundIds = new List<int>();
            
            // Starts testing for unused IDs beginning with 1.
            int testId = 1;
            
            // Continue the loop until the number of found idle IDs exceeds or equals the desired number (10).
            while (foundIds.Count <= wantedNumberOfIds)
            {               
                // Assume that the current testId is idle (unused).
                bool isIdle = true;
                
                // Iterate over each 'Person' object in the '_persons' list.
                // This checks if the testId is already being used by an existing 'Person'.
                foreach (Person per in _persons)
                {
                    
                    // If the 'Person' object's Id matches the current testId, it means this ID is already in use.
                    if (per.Id == testId)
                    {
                        // Set 'isIdle' to false, meaning the testId is not idle and should not be added to the foundIds list.
                        isIdle = false; 
                    }
                }

                // If the current testId is confirmed as idle (unused by any Person object),
                if (isIdle)
                {
                    // Add the testId to the list of found idle IDs.
                    foundIds.Add(testId);
                    
                }
                // Move on to the next ID number (increment testId by 1) to check if it's idle in the next loop iteration.
                testId++;
            }
            // Once the desired number of idle IDs is found, return the list of found IDs.
            return foundIds;
        }
    }
}
