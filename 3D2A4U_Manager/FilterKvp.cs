using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3D2A4U_Model;

namespace _3D2A4U_Manager
{
    public partial class FilterKvp : UserControl
    {
        #region Events
        public delegate void ValueRequest(object sender, string Key);
        public event ValueRequest? ValueRequested;

        #endregion

        #region Properties
        public Label Label { get { return lbl; } }
        public string LabelText { get { return Label.Text; } set { Label.Text = value; } }
        public ComboBox ComboBox { get { return cbo; } }
        public object? ComboBoxDataSource { 
            get { return ComboBox.DataSource; } 
            set {
                //add a dummy blank to the top here
                if (value != null && ((IList<dynamic>)value).Count > 0)
                {
                    var dummy = Activator.CreateInstance(((IList<dynamic>)value)?.First().GetType(), new dynamic[] { string.Empty, (int)-1 });
                    dummy.Id = -1;
                    ((IList<dynamic>)value)?.Insert(0, dummy);

                    //assign the value
                    ComboBox.DataSource = value;
                }
            } 
        }
        public bool EditEnabled { get { return btnEdit.Visible; } set { btnEdit.Visible = value; } }
        public string LookupKeyTypeName { get; set; } = string.Empty;
        #endregion

        public FilterKvp()
        {
            InitializeComponent();
            //ValueRequested?.Invoke(this, LookupKeyTypeName); //causes us to load the dropdown
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditLookupValues editLookupValues = new(LookupKeyTypeName);
            DialogResult result = editLookupValues.ShowDialog();
            if (result == DialogResult.OK)
                ValueRequested?.Invoke(this, LookupKeyTypeName);
        }

        private void FilterKvp_Load(object sender, EventArgs e)
        {
            ValueRequested?.Invoke(this, LookupKeyTypeName);
        }
    }
}
