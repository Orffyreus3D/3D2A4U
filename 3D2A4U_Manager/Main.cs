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

		/// <summary>
		/// Allows the user to add new models to the repo (since we want to search more than add, usually)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void chkAddModels_CheckedChanged(object sender, EventArgs e)
		{
			btnNewFile.Visible = ((CheckBox)sender).Checked;
		}

		private void btnNewFile_Click(object sender, EventArgs e)
		{
			//show the form for edit
			NewFileForm newFile = new NewFileForm();
			newFile.vdb = vdb;
			DialogResult dr = newFile.ShowDialog();

			//save if we save
			if (dr == DialogResult.OK)
			{
				biz.SaveModel(newFile?.Model.AsModelWad());
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

		/// <summary>
		/// Toggles Dark Mode
		/// </summary>
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


		/// <summary>
		/// Perform search of the JSON repository 
		/// </summary>
		private void btnSearch_Click(object sender, EventArgs e)
		{
			//gather search criteria
			Dictionary<string, string> filters = new Dictionary<string, string>();
			foreach (FilterKvp kvp in tblFileFilters.Controls.OfType<FilterKvp>())
			{
				int? val = (int?)kvp.ComboBox.SelectedValue;
				if (val.HasValue && val.Value > 0)
					filters.Add(
						kvp.ComboBox.DataSource.GetType().GenericTypeArguments[0].Name,
						kvp.ComboBox.SelectedValue.ToString());
			}

			//load models and find matches
			List<Model> models = biz.GetModels(filters);
			//setup columns if we have results
			if (models != null && models.Count > 0)
			{
				//TODO: column matched to results
				//if (gvFileSearchResults.Columns.Count == 0) SetupResultColumns();
			}
			gvFileSearchResults.DataSource = models;
		}
		private void SetupResultColumns()
		{
			//set up the static properties
			DataGridViewColumn idCol = new DataGridViewColumn { Visible = false, Name = "Id", ValueType = typeof(Guid), DataPropertyName = "Id" };
			gvFileSearchResults.Columns.Add(idCol);
			gvFileSearchResults.Columns.Add("Name", "Name");
			DataGridViewLinkColumn urlCol = new DataGridViewLinkColumn { DataPropertyName = "Url", HeaderText = "Url" };
			gvFileSearchResults.Columns.Add(urlCol);
			gvFileSearchResults.Columns.Add("Description", "Description");

			//then iterate thru the rest of the LookupValues, so we can add more later
			foreach (var lv in typeof(Model).GetProperties().Where(p => p.PropertyType.IsAssignableTo(typeof(LookupValue))).ToList())
			{
				DataGridViewColumn column = new DataGridViewColumn();
				column.HeaderText = lv.Name;
				column.DataPropertyName = lv.Name;
			}
		}

		private void gvFileSearchResults_DoubleClick(object sender, EventArgs e)
		{
			DataGridView gv = (DataGridView)sender;
			int selectedRowIx = gv.SelectedCells[0].RowIndex;
			Guid selGuid = (Guid)gv.Rows[selectedRowIx].Cells["Id"].Value;

			//show the form for edit
			NewFileForm newFile = new NewFileForm();
			newFile.vdb = vdb;
			newFile.Model = biz.GetModel(selGuid);
			DialogResult dr = newFile.ShowDialog();

			//save if we save
			if (dr == DialogResult.OK)
			{
				biz.SaveModel(newFile?.Model.AsModelWad());
			}

			//run search again to refresh the row
			btnSearch_Click(btnSearch, new EventArgs());

		}
	}
}
