namespace _3D2A4U_Manager
{
    partial class EditLookupValues
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
            tblStats = new TableLayoutPanel();
            lstValues = new ListBox();
            btnSave = new Button();
            btnCancel = new Button();
            btnAddValue = new Button();
            btnRemoveValue = new Button();
            btnSortUp = new Button();
            btnSortDown = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            btnCommit = new Button();
            tblStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // tblStats
            // 
            tblStats.ColumnCount = 2;
            tblStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.93296F));
            tblStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.06704F));
            tblStats.Controls.Add(label3, 0, 2);
            tblStats.Controls.Add(textBox2, 1, 1);
            tblStats.Controls.Add(label2, 0, 1);
            tblStats.Controls.Add(textBox1, 1, 0);
            tblStats.Controls.Add(numericUpDown1, 1, 2);
            tblStats.Controls.Add(label1, 0, 0);
            tblStats.Controls.Add(btnCommit, 1, 3);
            tblStats.Location = new Point(251, 12);
            tblStats.Name = "tblStats";
            tblStats.RowCount = 4;
            tblStats.RowStyles.Add(new RowStyle());
            tblStats.RowStyles.Add(new RowStyle());
            tblStats.RowStyles.Add(new RowStyle());
            tblStats.RowStyles.Add(new RowStyle());
            tblStats.Size = new Size(537, 113);
            tblStats.TabIndex = 0;
            // 
            // lstValues
            // 
            lstValues.FormattingEnabled = true;
            lstValues.ItemHeight = 15;
            lstValues.Location = new Point(12, 12);
            lstValues.Name = "lstValues";
            lstValues.Size = new Size(233, 394);
            lstValues.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(632, 409);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(713, 409);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddValue
            // 
            btnAddValue.Location = new Point(12, 409);
            btnAddValue.Name = "btnAddValue";
            btnAddValue.Size = new Size(75, 23);
            btnAddValue.TabIndex = 3;
            btnAddValue.Text = "Add";
            btnAddValue.UseVisualStyleBackColor = true;
            // 
            // btnRemoveValue
            // 
            btnRemoveValue.Location = new Point(93, 409);
            btnRemoveValue.Name = "btnRemoveValue";
            btnRemoveValue.Size = new Size(75, 23);
            btnRemoveValue.TabIndex = 4;
            btnRemoveValue.Text = "Remove";
            btnRemoveValue.UseVisualStyleBackColor = true;
            btnRemoveValue.Click += btnRemoveValue_click;
            // 
            // btnSortUp
            // 
            btnSortUp.Location = new Point(174, 409);
            btnSortUp.Name = "btnSortUp";
            btnSortUp.Size = new Size(32, 23);
            btnSortUp.TabIndex = 5;
            btnSortUp.Text = "↑";
            btnSortUp.UseVisualStyleBackColor = true;
            // 
            // btnSortDown
            // 
            btnSortDown.Location = new Point(212, 409);
            btnSortDown.Name = "btnSortDown";
            btnSortDown.Size = new Size(32, 23);
            btnSortDown.TabIndex = 6;
            btnSortDown.Text = "↓";
            btnSortDown.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(153, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(153, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(381, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 58);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 4;
            label3.Text = "Sort Order";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(153, 61);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // btnCommit
            // 
            btnCommit.Location = new Point(153, 90);
            btnCommit.Name = "btnCommit";
            btnCommit.Size = new Size(75, 23);
            btnCommit.TabIndex = 6;
            btnCommit.Text = "Commit";
            btnCommit.UseVisualStyleBackColor = true;
            // 
            // EditLookupValues
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 444);
            Controls.Add(btnSortDown);
            Controls.Add(btnSortUp);
            Controls.Add(btnRemoveValue);
            Controls.Add(btnAddValue);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lstValues);
            Controls.Add(tblStats);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "EditLookupValues";
            Text = "EditLookupValues";
            tblStats.ResumeLayout(false);
            tblStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblStats;
        private ListBox lstValues;
        private Button btnSave;
        private Button btnCancel;
        private Button btnAddValue;
        private Button btnRemoveValue;
        private Button btnSortUp;
        private Button btnSortDown;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Button btnCommit;
    }
}