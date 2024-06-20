namespace _3D2A4U_Manager
{
    partial class FilterKvp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbo = new ComboBox();
            lbl = new Label();
            btnEdit = new Button();
            SuspendLayout();
            // 
            // cbo
            // 
            cbo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbo.DisplayMember = "Name";
            cbo.FormattingEnabled = true;
            cbo.Location = new Point(139, 3);
            cbo.Name = "cbo";
            cbo.Size = new Size(196, 23);
            cbo.TabIndex = 0;
            cbo.ValueMember = "Id";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(3, 6);
            lbl.Name = "lbl";
            lbl.Size = new Size(38, 15);
            lbl.TabIndex = 1;
            lbl.Text = "label1";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(108, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(25, 23);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Δ";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Visible = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // FilterKvp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnEdit);
            Controls.Add(lbl);
            Controls.Add(cbo);
            MinimumSize = new Size(338, 30);
            Name = "FilterKvp";
            Size = new Size(338, 30);
            Load += FilterKvp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbo;
        private Label lbl;
        private Button btnEdit;
    }
}
