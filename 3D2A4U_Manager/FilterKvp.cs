using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3D2A4U;

namespace _3D2A4U_Manager
{
    public partial class FilterKvp : UserControl
    {
        #region Events
        public delegate List<LookupValue> ValueRequest(string Key);
        public event ValueRequest? ValueRequested;
        
        #endregion

        #region Properties
        public Label Label { get { return lbl; } }
        public string LabelText { get { return Label.Text; } set { Label.Text = value; } }
        public ComboBox ComboBox { get { return cbo; } }
        public object? ComboBoxDataSource { get { return ComboBox.DataSource; } set { ComboBox.DataSource = value; } }
        public bool EditEnabled { get { return btnEdit.Visible; } set { btnEdit.Visible = value; } }
        #endregion

        public FilterKvp()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditLookupValues editLookupValues = new EditLookupValues();
            DialogResult result = editLookupValues.ShowDialog();
        }
    }
}
