using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public new string Name { get { return txtName.Text; } set { txtName.Text = value; } }
        public Uri Url { get { return new Uri(txtULrl.Text); } set { txtULrl.Text = value.AbsoluteUri; } }
        public string Description { get { return txtDescription.Text; }  set { txtDescription.Text = value; } }

        public NewFileForm()
        {
            InitializeComponent();
        }
    }
}
