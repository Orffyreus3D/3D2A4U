namespace _3D2A4U_Manager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clears the results and all search inputs
        /// </summary>
        private void btnClearResults_Click(object sender, EventArgs e)
        {
            gvFileSearchResults.DataSource = null;
            foreach (FilterKvp filter in tblFileFilters.Controls.OfType<FilterKvp>())
            {
                filter.ComboBox.SelectedIndex = -1;
                filter.ComboBox.Text = string.Empty;
            }
        }

        private void spcFileSearch_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnCheckForUpdates_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented :(");
        }

        /// <summary>
        /// Allows the user to click a button to edit values in dropdown lists
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkAllowLookupEdit_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
