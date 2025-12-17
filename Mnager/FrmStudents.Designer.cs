namespace Mnager
{
    partial class FrmStudents
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
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ColFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStudentCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.dgvStudent);
            this.splitContainer1.Size = new System.Drawing.Size(570, 442);
            this.splitContainer1.SplitterDistance = 113;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColFirstName,
            this.ColLastName,
            this.ColStudent,
            this.ColStudentCode,
            this.ColGrade,
            this.ColEdit,
            this.ColDelete});
            this.dgvStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudent.Location = new System.Drawing.Point(0, 0);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.Size = new System.Drawing.Size(570, 325);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(22, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 58);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.ColStudent.HeaderText = "نام دانش آموزش";
            this.ColStudent.MinimumWidth = 6;
            this.ColStudent.Name = "ColStudent";
            this.ColStudent.ReadOnly = true;
            this.ColStudent.Width = 110;
            // 
            // ColStudentCode
            // 
            this.ColStudentCode.DataPropertyName = "StudentCode";
            this.ColStudentCode.HeaderText = "کد دانش آموزی";
            this.ColStudentCode.MinimumWidth = 6;
            this.ColStudentCode.Name = "ColStudentCode";
            this.ColStudentCode.ReadOnly = true;
            this.ColStudentCode.Width = 90;
            // 
            // ColGrade
            // 
            this.ColGrade.DataPropertyName = "Grade";
            this.ColGrade.HeaderText = "مقطع تحصیلی";
            this.ColGrade.MinimumWidth = 6;
            this.ColGrade.Name = "ColGrade";
            this.ColGrade.ReadOnly = true;
            this.ColGrade.Width = 70;
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
            // FrmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 442);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(580, 480);
            this.Name = "FrmStudents";
            this.Text = "FrmStudents";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStudents_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStudentCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGrade;
        private System.Windows.Forms.DataGridViewButtonColumn ColEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColDelete;
    }
}