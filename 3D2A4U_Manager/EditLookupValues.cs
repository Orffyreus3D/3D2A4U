using _3D2A4U;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3D2A4U_Manager
{
    public partial class EditLookupValues : Form
    {
        private LookupValue SelectedItem { get { return (LookupValue)lstValues?.SelectedItem; } set { lstValues.SelectedItem = value; } }
        public Type ValueType { get; set; }

        public EditLookupValues()
        {
            InitializeComponent();
        }

        private void btnRemoveValue_click(object sender, EventArgs e)
        {
            if (lstValues.SelectedItem != null)
                lstValues.Items.Remove(lstValues.SelectedItem);
        }

        private void btnAddValue_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            nudSortOrder.Value = 0;
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Populate the list with the existing values for this type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditLookupValues_Load(object sender, EventArgs e)
        {

        }
    }
}
