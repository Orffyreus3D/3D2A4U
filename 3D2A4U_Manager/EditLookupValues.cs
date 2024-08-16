using _3D2A4U_BusinessLayer;
using _3D2A4U_Manager.Properties;
using _3D2A4U_Model;
using JsonFlatFileDataStore;
using System;
using System.Collections.Generic;
using System.Collections;
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
		private readonly _3D2A4UBusinessLayer biz = new(Settings.Default.LocalPath);
		private readonly VirtualDatabase vdb = new(Settings.Default.LocalPath);

		public EditLookupValues(Type valueType)
		{
			InitializeComponent();
			ValueType = valueType;
		}

		public EditLookupValues(string valueTypeName) : this(Assembly.GetAssembly(typeof(LookupValue))?.GetType("_3D2A4U_Model." + valueTypeName) ?? typeof(object)) { }

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
				var newVal = Activator.CreateInstance(ValueType, [txtName.Text, (int)nudSortOrder.Value]);
				if (newVal != null)
					((System.Collections.IList)lstValues.DataSource).Add(newVal);
				//refresh the control so it shows the new guy
				var tmp = lstValues.DataSource;
				lstValues.DataSource = new List<LookupValue>(); //throw a dummy list in here so we don't lose our Display- and ValueMembers
				lstValues.DataSource = tmp;
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
			//foreach (var item in biz.GetLookupValues(ValueType.Name))
			//    lstValues.Items.Add(item);

			//var bob = typeof(VirtualDatabase).GetProperty(ValueType.Name + "s")?.GetValue(vdb);
			lstValues.DataSource = ((IEnumerable<LookupValue>)vdb.GetList(ValueType)).OrderBy(lv => lv.SortOrder).ToList();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			foreach (var item in (IList)lstValues.DataSource)
			{
				biz.Save((LookupValue)item);
			}
			lstValues.DataSource = vdb.GetList(ValueType); //reload our list
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void lstValues_SelectedIndexChanged(object sender, EventArgs e)
		{
			LookupValue si = (LookupValue)lstValues.SelectedItem;
			if (si != null)
			{
				txtID.Text = si.Id.ToString();
				txtName.Text = si.Name;
				nudSortOrder.Value = si.SortOrder;
			}
		}

		/// <summary>
		/// Performs alphabetical sort
		/// </summary>
		private void btnSort_Click(object sender, EventArgs e)
		{
			//sort the list by name values, then update the sort order
			List<LookupValue> list = ((IEnumerable<LookupValue>)lstValues.DataSource)?.OrderBy(lv => lv.Name.ToLower()).ToList();
			foreach (LookupValue item in list)
				item.SortOrder = list.IndexOf(item);
			lstValues.DataSource = list;
		}

		private void btnSortChange_Click(object sender, EventArgs e)
		{
			int selSort;
			int neighborSort;
			int sortShift;
			switch (sender == btnSortUp)
			{
				case true: 
					sortShift = -1;
					break;
				case false: 
					sortShift = 1;
					break;
			}
			int selIx = lstValues.SelectedIndex;
			int neighborIx = selIx + sortShift;

			//take the selected guy and the guy one dir away from him and swap sort values; if out of range, then we're done
			if (neighborIx >= 0 & neighborIx < ((List<LookupValue>)lstValues.DataSource).Count)
			{
				lstValues.BeginUpdate();

				selSort = ((List<LookupValue>)lstValues.DataSource)[selIx].SortOrder;
				neighborSort = ((List<LookupValue>)lstValues.DataSource)[neighborIx].SortOrder;
				((List<LookupValue>)lstValues.DataSource)[selIx].SortOrder = neighborSort;
				((List<LookupValue>)lstValues.DataSource)[neighborIx].SortOrder = selSort;

				//finish up by reloading the list
				lstValues.DataSource = ((IEnumerable<LookupValue>)lstValues.DataSource).OrderBy(lv => lv.SortOrder).ToList();

				lstValues.EndUpdate();
				lstValues.SelectedIndex = neighborIx;
			}

		}
	}
}
