using Exercise_Delegates_Sort_in_Gui.Data;
using Exercise_Delegates_Sort_in_Gui.Model;

namespace Exercise_Delegates_Sort_in_Gui
{
    public partial class GamerSort : Form
    {
        // Declares a private nullable list of Gamer objects, to store the gamers fetched from the data source.
        List<Gamer>? _foundGamers; 

        /*
         * Constructor for the GamerSort class.
         */
        public GamerSort()
        {
        // Initializes the components of the form (UI elements).
            InitializeComponent(); 
        }

        /* 
         * Event handler for when the form loads.
         */
        private void GamerSort_Load(object sender, EventArgs e) 
        {
            // Creates an instance of the GamerData class to access data-related methods.
            GamerData gd = new GamerData(); 
            // Fetches a list of gamers from the data source and assigns it to _foundGamers.
            _foundGamers = gd.FetchGamers(); 

            // Calls the method to update the list box with the fetched gamers.
            UpdateGamerListBox(); 
        }

        /*
         * Event handler for when the "Sort by Name" button is clicked.
         */
        private void BtnByName_Click(object sender, EventArgs e)
        {
            // Toggles the order of sorting for names (ascending/descending).
            GamerOrder.ToogleCurrentNameOrderIsAscending(); 
            // Checks if _foundGamers is not null.
            if (_foundGamers != null) 
            {
                // Sorts the _foundGamers list by name using the OrderByName delegate.
                _foundGamers.Sort(GamerOrder.OrderByName); 
            }
            //// Possibly use: null-conditional operator
            //_foundGamers?.Sort(GamerOrder.OrderByName); // Commented-out code that uses the null-conditional operator to sort only if _foundGamers is not null.
            
            // Updates the list box to reflect the newly sorted list of gamers.
            UpdateGamerListBox(); 
        }

        /*
         * Event handler for when the "Sort by High Score" button is clicked.
         */
        private void BtnByHighScore_Click(object sender, EventArgs e)
        {
            // Toggles the order of sorting for high scores (ascending/descending).
            GamerOrder.ToogleCurrentHighScoreOrderIsAscending();
            // Checks if _foundGamers is not null.
            if (_foundGamers != null) 
            {
                // Sorts the _foundGamers list by high score using the OrderByHighScore delegate.
                _foundGamers.Sort(GamerOrder.OrderByHighScore); 
            }
            //_foundGamers?.Sort(GamerOrder.OrderByHighScore); // Commented-out code that uses the null-conditional operator to sort only if _foundGamers is not null.
            
            // Updates the list box to reflect the newly sorted list of gamers.
            UpdateGamerListBox(); 
        }

        /*
         * Method to update the list box with the current gamers.
         */
        private void UpdateGamerListBox()
        {
            // Clears the current items in the list box.
            lbGamers.Items.Clear(); 
            // Checks if _foundGamers is not null.
            if (_foundGamers != null) 
            {
                // Iterates through each Gamer in the _foundGamers list.
                foreach (Gamer gmr in _foundGamers) 
                {
                    // Adds each Gamer object to the list box.
                    lbGamers.Items.Add(gmr); 
                }
            }
        }

        /*
         * Event handler for when the selected index in the list box changes.
         */
        private void lbGamers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Currently, this method is empty and could be used to handle selection changes.
        }
    }
}
