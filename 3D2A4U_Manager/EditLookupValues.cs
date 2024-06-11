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
        public EditLookupValues()
        {
            InitializeComponent();
        }

        private void btnRemoveValue_click(object sender, EventArgs e)
        {
            if (lstValues.SelectedItem != null)
                lstValues.Items.Remove(lstValues.SelectedItem);
        }
    }
}
