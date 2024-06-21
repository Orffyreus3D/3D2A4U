using _3D2A4U_BusinessLayer;
using _3D2A4U_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3D2A4U_Manager
{
    public partial class NewFileForm : Form
    {
        public VirtualDatabase? vdb { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid();
        public new string Name { get { return txtName.Text; } set { txtName.Text = value; } }
        public Uri Url { get { return new Uri(txtULrl.Text); } set { txtULrl.Text = value.AbsoluteUri; } }
        public string Description { get { return txtDescription.Text; } set { txtDescription.Text = value; } }

        public Model Model { get; set; } = new Model();

        public NewFileForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //generate the Model from our inputs and the chosen filters
            Model.Id = Id;
            Model.Name = Name;
            Model.Url = Url.AbsoluteUri;
            Model.Description = Description;

            //iterate thru the tree to add more properties
            foreach (var dude in tvApplied.Nodes)
            {
                dude.ToString();
            }
        }

        private void NewFileForm_Load(object sender, EventArgs e)
        {
            Debug.Assert(vdb != null, "VirtualDB reference not given where required.");

            //build a list of LookupValues to load into the list
            foreach (Type t in typeof(Model).GetProperties().ToList().Where(lv => lv.PropertyType.IsSubclassOf(typeof(LookupValue))).Select(lv => lv.PropertyType))
            {
                lbxAttributes.Items.Add(t.Name);
            }

            //load the model if provided
            if (Model.Id == Guid.Empty)
            {
                //kleeborp
            }
            else
            {
                //borp
            }
        }

        private void lbxAttributes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load the next listbox over with the values for this guy
            string sv = (string)lbxAttributes.SelectedItem ?? string.Empty;
            if (!string.IsNullOrEmpty(sv))
                lbxValues.DataSource = vdb.GetList(sv);
            else
                lbxValues.DataSource = new List<LookupValue>();
            lbxValues.DisplayMember = "Name";
            lbxValues.ValueMember = "Id";
        }
    }
}
