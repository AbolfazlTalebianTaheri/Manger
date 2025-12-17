namespace Mnager
{
    partial class FrmPersons
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFeistName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEdite = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvPerson);
            this.splitContainer1.Size = new System.Drawing.Size(484, 366);
            this.splitContainer1.SplitterDistance = 96;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 43);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = " Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvPerson
            // 
            this.dgvPerson.AllowUserToAddRows = false;
            this.dgvPerson.AllowUserToDeleteRows = false;
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.ColFeistName,
            this.colLastName,
            this.colFullName,
            this.colNationalCode,
            this.colGender,
            this.colDelete,
            this.colEdite,
            this.gnd});
            this.dgvPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPerson.Location = new System.Drawing.Point(0, 0);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.ReadOnly = true;
            this.dgvPerson.RowHeadersWidth = 51;
            this.dgvPerson.RowTemplate.Height = 24;
            this.dgvPerson.Size = new System.Drawing.Size(484, 266);
            this.dgvPerson.TabIndex = 0;
            this.dgvPerson.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellContentClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 25;
            // 
            // ColFeistName
            // 
            this.ColFeistName.DataPropertyName = "FirstName";
            this.ColFeistName.HeaderText = "FierstName";
            this.ColFeistName.MinimumWidth = 6;
            this.ColFeistName.Name = "ColFeistName";
            this.ColFeistName.ReadOnly = true;
            this.ColFeistName.Visible = false;
            this.ColFeistName.Width = 125;
            // 
            // colLastName
            // 
            this.colLastName.DataPropertyName = "LastName";
            this.colLastName.HeaderText = "LastName";
            this.colLastName.MinimumWidth = 6;
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            this.colLastName.Visible = false;
            this.colLastName.Width = 125;
            // 
            // colFullName
            // 
            this.colFullName.DataPropertyName = "GetFullName";
            this.colFullName.HeaderText = "نام شخص";
            this.colFullName.MinimumWidth = 6;
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            this.colFullName.Width = 90;
            // 
            // colNationalCode
            // 
            this.colNationalCode.DataPropertyName = "NationalCode";
            this.colNationalCode.HeaderText = "کدملی";
            this.colNationalCode.MinimumWidth = 6;
            this.colNationalCode.Name = "colNationalCode";
            this.colNationalCode.ReadOnly = true;
            this.colNationalCode.Width = 80;
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "Gendertxt";
            this.colGender.HeaderText = "جنسیت";
            this.colGender.MinimumWidth = 6;
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            this.colGender.Width = 50;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "حذف";
            this.colDelete.MinimumWidth = 6;
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Width = 35;
            // 
            // colEdite
            // 
            this.colEdite.HeaderText = "ویرایش";
            this.colEdite.MinimumWidth = 6;
            this.colEdite.Name = "colEdite";
            this.colEdite.ReadOnly = true;
            this.colEdite.Width = 45;
            // 
            // gnd
            // 
            this.gnd.DataPropertyName = "Gender";
            this.gnd.HeaderText = "gnd";
            this.gnd.MinimumWidth = 6;
            this.gnd.Name = "gnd";
            this.gnd.ReadOnly = true;
            this.gnd.Visible = false;
            this.gnd.Width = 125;
            // 
            // FrmPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 366);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(505, 415);
            this.MinimumSize = new System.Drawing.Size(500, 410);
            this.Name = "FrmPersons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPersons";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPersons_FormClosing);
            this.Load += new System.EventHandler(this.FrmPersons_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFeistName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.DataGridViewButtonColumn colEdite;
        private System.Windows.Forms.DataGridViewTextBoxColumn gnd;
    }
}