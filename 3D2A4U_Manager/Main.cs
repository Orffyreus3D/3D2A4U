using _3D2A4U_BusinessLayer;
using _3D2A4U_Manager.Properties;
using _3D2A4U_Model;
using System.Diagnostics;
using System.Reflection;

namespace _3D2A4U_Manager
{
    public partial class Main : Form
    {
        private _3D2A4UBusinessLayer biz;
        private readonly VirtualDatabase vdb = new(Settings.Default.LocalPath);
        public Main()
        {
            InitializeComponent();
            biz = new _3D2A4UBusinessLayer(Settings.Default.LocalPath);

            //UI management
            chkDarkMode_CheckedChanged(chkDarkMode, null);
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
            foreach (FilterKvp fk in tblFileFilters.Controls.OfType<FilterKvp>())
            {
                fk.EditEnabled = ((CheckBox)sender).Checked;
            }
        }

        private void btnNewFile_Click(object sender, EventArgs e)
        {
            //show the form for edit54
            NewFileForm newFile = new NewFileForm();
            newFile.vdb = vdb;
            //TEST STUB
            DialogResult dr = DialogResult.Cancel;
            newFile.Show();
            //DialogResult dr = newFile.ShowDialog(); //TODO: ShowDialog instead

            //save if we save
            if (dr == DialogResult.OK)
            {
                biz.SaveModel(newFile?.Model);
                //TODO
                MessageBox.Show("Not yet implemented :(");
            }
        }

        private void f_ValueRequested(object sender, string Key, bool BumpDataStore)
        {
            Type keyType = Assembly.GetAssembly(typeof(LookupValue))?.GetType("_3D2A4U_Model." + Key);
            Debug.Assert(keyType != null, string.Format("keyType is null for {0}!", ((Control)sender).Name));
            if (BumpDataStore)
                vdb.BumpDS();
            ((FilterKvp)sender).ComboBoxDataSource = vdb.GetList(keyType);
        }

        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDarkMode.Checked)
            {
                this.ForeColor = Color.DarkGray;
                this.BackColor = Color.Black;
            }
            else
            {
                this.ForeColor = default;
                this.BackColor = default;
            }

            ChangeColorMode(this.Controls);
        }

        private void ChangeColorMode(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (chkDarkMode.Checked)
                {
                    control.BackColor = Color.DarkGray;
                    control.ForeColor = Color.Black;
                }
                else
                {
                    control.ForeColor = default;
                    control.BackColor = default;
                }
                if (control.HasChildren)
                    ChangeColorMode(control.Controls);
            }
        }

        private void gvFileSearchResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
