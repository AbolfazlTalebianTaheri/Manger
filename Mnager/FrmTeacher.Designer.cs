namespace Mnager
{
    partial class FrmTeacher
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
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.ColFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhonNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocatioan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.dgvTeacher);
            this.splitContainer1.Size = new System.Drawing.Size(647, 447);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(22, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 58);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "اضافه کردن";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.AllowUserToAddRows = false;
            this.dgvTeacher.AllowUserToDeleteRows = false;
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColFirstName,
            this.Gender,
            this.GenderTxt,
            this.Id,
            this.NationalCode,
            this.ColLastName,
            this.ColStudent,
            this.colPhonNumber,
            this.colLocatioan,
            this.colStudy,
            this.ColEdit,
            this.ColDelete});
            this.dgvTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeacher.Location = new System.Drawing.Point(0, 0);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.ReadOnly = true;
            this.dgvTeacher.RowHeadersWidth = 51;
            this.dgvTeacher.RowTemplate.Height = 24;
            this.dgvTeacher.Size = new System.Drawing.Size(647, 343);
            this.dgvTeacher.TabIndex = 1;
            this.dgvTeacher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeacher_CellContentClick);
            // 
            // ColFirstName
            // 
            this.ColFirstName.DataPropertyName = "FirstName";
            this.ColFirstName.HeaderText = "نام";
            this.ColFirstName.MinimumWidth = 6;
            this.ColFirstName.Name = "ColFirstName";
            this.ColFirstName.ReadOnly = true;
            this.ColFirstName.Visible = false;
            this.ColFirstName.Width = 125;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Visible = false;
            this.Gender.Width = 125;
            // 
            // GenderTxt
            // 
            this.GenderTxt.DataPropertyName = "GenderTxt";
            this.GenderTxt.HeaderText = "GenderTxt";
            this.GenderTxt.MinimumWidth = 6;
            this.GenderTxt.Name = "GenderTxt";
            this.GenderTxt.ReadOnly = true;
            this.GenderTxt.Visible = false;
            this.GenderTxt.Width = 125;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // NationalCode
            // 
            this.NationalCode.DataPropertyName = "NationalCode";
            this.NationalCode.HeaderText = "NationalCode";
            this.NationalCode.MinimumWidth = 6;
            this.NationalCode.Name = "NationalCode";
            this.NationalCode.ReadOnly = true;
            this.NationalCode.Width = 125;
            // 
            // ColLastName
            // 
            this.ColLastName.DataPropertyName = "LastName";
            this.ColLastName.HeaderText = "نام خوانوادگی";
            this.ColLastName.MinimumWidth = 6;
            this.ColLastName.Name = "ColLastName";
            this.ColLastName.ReadOnly = true;
            this.ColLastName.Visible = false;
            this.ColLastName.Width = 125;
            // 
            // ColStudent
            // 
            this.ColStudent.DataPropertyName = "GetFullName";
            this.ColStudent.FillWeight = 140F;
            this.ColStudent.HeaderText = "نام معلم";
            this.ColStudent.MinimumWidth = 6;
            this.ColStudent.Name = "ColStudent";
            this.ColStudent.ReadOnly = true;
            this.ColStudent.Width = 110;
            // 
            // colPhonNumber
            // 
            this.colPhonNumber.DataPropertyName = "PhonNumber";
            this.colPhonNumber.HeaderText = "تلفن همراه";
            this.colPhonNumber.MinimumWidth = 6;
            this.colPhonNumber.Name = "colPhonNumber";
            this.colPhonNumber.ReadOnly = true;
            this.colPhonNumber.Width = 80;
            // 
            // colLocatioan
            // 
            this.colLocatioan.DataPropertyName = "Locatioan";
            this.colLocatioan.HeaderText = "آدرس";
            this.colLocatioan.MinimumWidth = 6;
            this.colLocatioan.Name = "colLocatioan";
            this.colLocatioan.ReadOnly = true;
            this.colLocatioan.Width = 90;
            // 
            // colStudy
            // 
            this.colStudy.DataPropertyName = "Study";
            this.colStudy.HeaderText = "رشته";
            this.colStudy.MinimumWidth = 6;
            this.colStudy.Name = "colStudy";
            this.colStudy.ReadOnly = true;
            this.colStudy.Width = 90;
            // 
            // ColEdit
            // 
            this.ColEdit.HeaderText = "ویرایش";
            this.ColEdit.MinimumWidth = 6;
            this.ColEdit.Name = "ColEdit";
            this.ColEdit.ReadOnly = true;
            this.ColEdit.Width = 45;
            // 
            // ColDelete
            // 
            this.ColDelete.HeaderText = "حذف";
            this.ColDelete.MinimumWidth = 6;
            this.ColDelete.Name = "ColDelete";
            this.ColDelete.ReadOnly = true;
            this.ColDelete.Width = 45;
            // 
            // FrmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 447);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTeacher";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhonNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocatioan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudy;
        private System.Windows.Forms.DataGridViewButtonColumn ColEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColDelete;
    }
}