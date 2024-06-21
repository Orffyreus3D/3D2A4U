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

        private IList<dynamic> Values { get; set; } = new List<object>();

        public NewFileForm()
        {
            InitializeComponent();
            //clear the filter when these events occur
            btnAdd.Click += ClearFilter_Handler;
            lbxAttributes.SelectedIndexChanged += ClearFilter_Handler;
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

            //build a list of LookupValues child types to load into the list
            foreach (Type t in typeof(Model).GetProperties().ToList().Where(lv => lv.PropertyType.IsSubclassOf(typeof(LookupValue))).Select(lv => lv.PropertyType))
            {
                lbxAttributes.Items.Add(t.Name);
            }

            //load the model if provided
            if (Model.Id != Guid.Empty)
            {
                //kleeborp
            }
        }

        private void lbxAttributes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load the next listbox over with the values for this guy
            string sv = (string)lbxAttributes.SelectedItem ?? string.Empty;
            if (!string.IsNullOrEmpty(sv))
                Values = (List<object>)vdb.GetList(sv);
            else
                Values = (new List<object>());
            lbxValues.DataSource = Values;
            lbxValues.DisplayMember = "Name";
            lbxValues.ValueMember = "Id";
        }

        private void ClearFilter_Handler(object? sender, EventArgs e)
        {
            txtValueFilter.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //find type node
            string parentNodeName = (string)lbxAttributes.SelectedItem ?? string.Empty;
            TreeNode parentNode = tvApplied.Nodes.Find(parentNodeName, false).FirstOrDefault();
            if (parentNode == null) //add node
            {
                tvApplied.Nodes.Add(parentNodeName, parentNodeName);
                parentNode = tvApplied.Nodes.Find(parentNodeName, false).FirstOrDefault();
            }

            //add value
            foreach (var guy in lbxValues.SelectedItems)
            {
                string name = ((LookupValue)guy).Name.ToString();
                parentNode.Nodes.Add(name,name);
            }
        }

        /// <summary>
        /// Filter the Values list when stuff is typed here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtValueFilter_TextChanged(object sender, EventArgs e)
        {
            lbxValues.DataSource = Values.Where(v => ((string)v.Name).Contains(txtValueFilter.Text)).ToList();
            lbxValues.DisplayMember = "Name";
            lbxValues.ValueMember = "Id";
        }

        private void lbxValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = lbxValues.SelectedItems.Count > 0;
        }

        private void tvApplied_AfterSelect(object sender, TreeViewEventArgs e)
        {
            btnRemoveApplied.Enabled = tvApplied.SelectedNode != null;
        }

        private void btnRemoveApplied_Click(object sender, EventArgs e)
        {
            if (tvApplied.SelectedNode != null)
            {
                //find the parent, then find the child, as we don't wanna remove the wrong one (or parent = self if root)
                TreeNode parentNode = tvApplied.SelectedNode.Parent ?? tvApplied.SelectedNode;
                string selectedNodeName = tvApplied.SelectedNode.Text;
                TreeNode rm;
                if (parentNode.Text == selectedNodeName)
                    rm = parentNode;
                else
                    rm = parentNode.Nodes.Find(selectedNodeName, true).FirstOrDefault();

                //remove (assuming we found it)
                if (rm != null)
                    tvApplied.Nodes.Remove(rm);

                //if it's a root node with no children, remove it as well (if it's still there)
                if (parentNode?.Nodes.Count == 0)
                    tvApplied.Nodes.Remove(parentNode);
            }

        }
    }
}
