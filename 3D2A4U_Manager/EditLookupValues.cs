﻿using _3D2A4U_BusinessLayer;
using _3D2A4U_Manager.Properties;
using _3D2A4U_Model;
using JsonFlatFileDataStore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3D2A4U_Manager
{
    public partial class EditLookupValues : Form
    {
        private LookupValue? SelectedItem { get { return (LookupValue?)lstValues?.SelectedItem; } set { lstValues.SelectedItem = value; } }
        public Type ValueType { get; set; } = typeof(string);
        private _3D2A4UBusinessLayer biz = new _3D2A4UBusinessLayer(Settings.Default.LocalPath);

        public EditLookupValues(Type valueType)
        {
            InitializeComponent();
            ValueType = valueType;
        }

        public EditLookupValues(string valueTypeName) : this(Assembly.GetAssembly(typeof(LookupValue))?.GetType("_3D2A4U_Model." + valueTypeName) ?? typeof(object)) {}

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
            lstValues.SelectedIndex = -1;
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (SelectedItem != null)
            {
                //just update this selected item, all done for now
                SelectedItem.Id = int.Parse(txtID.Text);
                SelectedItem.Name = txtName.Text;
                SelectedItem.SortOrder = (int)nudSortOrder.Value;
            }
            else
            {
                //create a new instance of our specific LookupValue subtype
                var newVal = ValueType?.GetConstructors()?[0]?.Invoke(new object[] { txtName.Text, (int)nudSortOrder.Value });
                if (newVal != null)
                    lstValues.Items.Add(newVal);
            }
        }

        /// <summary>
        /// Populate the list with the existing values for this type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditLookupValues_Load(object sender, EventArgs e)
        {
            //lstValues.DataSource = biz.GetLookupValues(ValueType.Name);
            foreach (var item in biz.GetLookupValues(ValueType.Name))
                lstValues.Items.Add(item);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (var item in lstValues.Items)
            {
                biz.Save((LookupValue)item);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
