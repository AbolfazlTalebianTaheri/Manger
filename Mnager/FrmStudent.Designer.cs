namespace Mnager
{
    partial class FrmStudent
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
            this.grbGrade = new System.Windows.Forms.GroupBox();
            this.rdbConservatory = new System.Windows.Forms.RadioButton();
            this.rdbGuidance = new System.Windows.Forms.RadioButton();
            this.rdbElementary = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConf = new System.Windows.Forms.Button();
            this.btnAddNewStudent = new System.Windows.Forms.Button();
            this.txtNationalCode = new Mnager.txt();
            this.txtLastName = new Mnager.txt();
            this.txtFirstName = new Mnager.txt();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.grbGrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbGrade
            // 
            this.grbGrade.Controls.Add(this.rdbConservatory);
            this.grbGrade.Controls.Add(this.rdbGuidance);
            this.grbGrade.Controls.Add(this.rdbElementary);
            this.grbGrade.Location = new System.Drawing.Point(37, 164);
            this.grbGrade.Name = "grbGrade";
            this.grbGrade.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbGrade.Size = new System.Drawing.Size(200, 106);
            this.grbGrade.TabIndex = 2;
            this.grbGrade.TabStop = false;
            this.grbGrade.Text = "مقطع تحصیلی";
            // 
            // rdbConservatory
            // 
            this.rdbConservatory.AutoSize = true;
            this.rdbConservatory.Location = new System.Drawing.Point(102, 73);
            this.rdbConservatory.Name = "rdbConservatory";
            this.rdbConservatory.Size = new System.Drawing.Size(71, 20);
            this.rdbConservatory.TabIndex = 2;
            this.rdbConservatory.TabStop = true;
            this.rdbConservatory.Text = "هنرستان";
            this.rdbConservatory.UseVisualStyleBackColor = true;
            // 
            // rdbGuidance
            // 
            this.rdbGuidance.AutoSize = true;
            this.rdbGuidance.Location = new System.Drawing.Point(99, 47);
            this.rdbGuidance.Name = "rdbGuidance";
            this.rdbGuidance.Size = new System.Drawing.Size(74, 20);
            this.rdbGuidance.TabIndex = 1;
            this.rdbGuidance.TabStop = true;
            this.rdbGuidance.Text = "راهنمایی";
            this.rdbGuidance.UseVisualStyleBackColor = true;
            // 
            // rdbElementary
            // 
            this.rdbElementary.AutoSize = true;
            this.rdbElementary.Location = new System.Drawing.Point(112, 21);
            this.rdbElementary.Name = "rdbElementary";
            this.rdbElementary.Size = new System.Drawing.Size(61, 20);
            this.rdbElementary.TabIndex = 0;
            this.rdbElementary.TabStop = true;
            this.rdbElementary.Text = "ابتدایی";
            this.rdbElementary.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(12, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 43);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConf
            // 
            this.btnConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConf.Location = new System.Drawing.Point(93, 296);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(75, 43);
            this.btnConf.TabIndex = 4;
            this.btnConf.Text = "ذخیره و بازگشت";
            this.btnConf.UseVisualStyleBackColor = true;
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            // 
            // btnAddNewStudent
            // 
            this.btnAddNewStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddNewStudent.Location = new System.Drawing.Point(174, 296);
            this.btnAddNewStudent.Name = "btnAddNewStudent";
            this.btnAddNewStudent.Size = new System.Drawing.Size(81, 43);
            this.btnAddNewStudent.TabIndex = 3;
            this.btnAddNewStudent.Text = "ذخیره و ثبت جدید";
            this.btnAddNewStudent.UseVisualStyleBackColor = true;
            this.btnAddNewStudent.Click += new System.EventHandler(this.btnConfAndNew_Click);
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Location = new System.Drawing.Point(37, 124);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(100, 22);
            this.txtNationalCode.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(37, 83);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 22);
            this.txtLastName.TabIndex = 8;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(37, 45);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtFirstName.TabIndex = 7;
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.Location = new System.Drawing.Point(181, 127);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.Size = new System.Drawing.Size(39, 16);
            this.lblNationalCode.TabIndex = 10;
            this.lblNationalCode.Text = "کدملی";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(143, 89);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(77, 16);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "نام خوانوادگی";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(199, 51);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(21, 16);
            this.lblFirstName.TabIndex = 12;
            this.lblFirstName.Text = "نام";
            // 
            // FrmStudent
            // 
            this.AcceptButton = this.btnAddNewStudent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(267, 351);
            this.Controls.Add(this.txtNationalCode);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblNationalCode);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddNewStudent);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.grbGrade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStudent";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            this.grbGrade.ResumeLayout(false);
            this.grbGrade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbGrade;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.RadioButton rdbConservatory;
        private System.Windows.Forms.RadioButton rdbGuidance;
        private System.Windows.Forms.RadioButton rdbElementary;
        private System.Windows.Forms.Button btnAddNewStudent;
        private txt txtNationalCode;
        private txt txtLastName;
        private txt txtFirstName;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
    }
}