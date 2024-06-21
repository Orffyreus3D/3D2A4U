namespace _3D2A4U_Manager
{
    partial class NewFileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtULrl = new TextBox();
            txtDescription = new TextBox();
            label3 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            lbxAttributes = new ListBox();
            tvApplied = new TreeView();
            lbxValues = new ListBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(95, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(600, 23);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "URL";
            // 
            // txtULrl
            // 
            txtULrl.Location = new Point(95, 35);
            txtULrl.Name = "txtULrl";
            txtULrl.Size = new Size(600, 23);
            txtULrl.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(95, 64);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(600, 147);
            txtDescription.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "Description";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(545, 544);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(626, 544);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lbxAttributes
            // 
            lbxAttributes.FormattingEnabled = true;
            lbxAttributes.ItemHeight = 15;
            lbxAttributes.Location = new Point(95, 232);
            lbxAttributes.Name = "lbxAttributes";
            lbxAttributes.Size = new Size(170, 304);
            lbxAttributes.TabIndex = 9;
            lbxAttributes.SelectedIndexChanged += lbxAttributes_SelectedIndexChanged;
            // 
            // tvApplied
            // 
            tvApplied.Location = new Point(450, 232);
            tvApplied.Name = "tvApplied";
            tvApplied.Size = new Size(245, 306);
            tvApplied.TabIndex = 10;
            // 
            // lbxValues
            // 
            lbxValues.DisplayMember = "Name";
            lbxValues.FormattingEnabled = true;
            lbxValues.ItemHeight = 15;
            lbxValues.Location = new Point(271, 232);
            lbxValues.Name = "lbxValues";
            lbxValues.SelectionMode = SelectionMode.MultiExtended;
            lbxValues.Size = new Size(170, 304);
            lbxValues.TabIndex = 11;
            lbxValues.ValueMember = "Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(271, 214);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 12;
            label4.Text = "Values";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 214);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 13;
            label5.Text = "Attributes";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(450, 214);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 14;
            label6.Text = "Applied";
            // 
            // NewFileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 579);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbxValues);
            Controls.Add(tvApplied);
            Controls.Add(lbxAttributes);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(txtDescription);
            Controls.Add(txtULrl);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "NewFileForm";
            Text = "File Editor";
            TopMost = true;
            Load += NewFileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtULrl;
        private TextBox txtDescription;
        private Label label3;
        private Button btnSave;
        private Button btnCancel;
        private ListBox lbxAttributes;
        private TreeView tvApplied;
        private ListBox lbxValues;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}