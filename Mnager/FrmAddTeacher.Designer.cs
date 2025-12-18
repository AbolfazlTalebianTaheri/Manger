namespace Mnager
{
    partial class FrmAddTeacher
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
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConf = new System.Windows.Forms.Button();
            this.lblPhonNumber = new System.Windows.Forms.Label();
            this.lblLocatioan = new System.Windows.Forms.Label();
            this.grbStudy = new System.Windows.Forms.GroupBox();
            this.rdbExperimental = new System.Windows.Forms.RadioButton();
            this.rdbMath = new System.Windows.Forms.RadioButton();
            this.rdbComputer = new System.Windows.Forms.RadioButton();
            this.txtLocation = new Mnager.txt();
            this.txtPhoneNumber = new Mnager.txt();
            this.txtNationalCode = new Mnager.txt();
            this.txtLastName = new Mnager.txt();
            this.txtFirstName = new Mnager.txt();
            this.grbStudy.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.Location = new System.Drawing.Point(200, 130);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.Size = new System.Drawing.Size(39, 16);
            this.lblNationalCode.TabIndex = 4;
            this.lblNationalCode.Text = "کدملی";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(162, 92);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(77, 16);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "نام خوانوادگی";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(218, 54);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(21, 16);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "نام";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(56, 366);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConf
            // 
            this.btnConf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConf.Location = new System.Drawing.Point(137, 366);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(75, 33);
            this.btnConf.TabIndex = 6;
            this.btnConf.Text = "تایید";
            this.btnConf.UseVisualStyleBackColor = true;
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            // 
            // lblPhonNumber
            // 
            this.lblPhonNumber.AutoSize = true;
            this.lblPhonNumber.Location = new System.Drawing.Point(165, 164);
            this.lblPhonNumber.Name = "lblPhonNumber";
            this.lblPhonNumber.Size = new System.Drawing.Size(74, 16);
            this.lblPhonNumber.TabIndex = 5;
            this.lblPhonNumber.Text = "شماره موبایل";
            // 
            // lblLocatioan
            // 
            this.lblLocatioan.AutoSize = true;
            this.lblLocatioan.Location = new System.Drawing.Point(200, 202);
            this.lblLocatioan.Name = "lblLocatioan";
            this.lblLocatioan.Size = new System.Drawing.Size(37, 16);
            this.lblLocatioan.TabIndex = 4;
            this.lblLocatioan.Text = "آدرس";
            // 
            // grbStudy
            // 
            this.grbStudy.Controls.Add(this.rdbExperimental);
            this.grbStudy.Controls.Add(this.rdbMath);
            this.grbStudy.Controls.Add(this.rdbComputer);
            this.grbStudy.Location = new System.Drawing.Point(48, 236);
            this.grbStudy.Name = "grbStudy";
            this.grbStudy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbStudy.Size = new System.Drawing.Size(189, 100);
            this.grbStudy.TabIndex = 5;
            this.grbStudy.TabStop = false;
            this.grbStudy.Text = "رشته";
            // 
            // rdbExperimental
            // 
            this.rdbExperimental.AutoSize = true;
            this.rdbExperimental.Location = new System.Drawing.Point(104, 74);
            this.rdbExperimental.Name = "rdbExperimental";
            this.rdbExperimental.Size = new System.Drawing.Size(60, 20);
            this.rdbExperimental.TabIndex = 2;
            this.rdbExperimental.TabStop = true;
            this.rdbExperimental.Text = "تجربی";
            this.rdbExperimental.UseVisualStyleBackColor = true;
            // 
            // rdbMath
            // 
            this.rdbMath.AutoSize = true;
            this.rdbMath.Location = new System.Drawing.Point(101, 47);
            this.rdbMath.Name = "rdbMath";
            this.rdbMath.Size = new System.Drawing.Size(63, 20);
            this.rdbMath.TabIndex = 1;
            this.rdbMath.TabStop = true;
            this.rdbMath.Text = "ریاضی";
            this.rdbMath.UseVisualStyleBackColor = true;
            // 
            // rdbComputer
            // 
            this.rdbComputer.AutoSize = true;
            this.rdbComputer.Location = new System.Drawing.Point(93, 21);
            this.rdbComputer.Name = "rdbComputer";
            this.rdbComputer.Size = new System.Drawing.Size(71, 20);
            this.rdbComputer.TabIndex = 0;
            this.rdbComputer.TabStop = true;
            this.rdbComputer.Text = "کامپیوتر";
            this.rdbComputer.UseVisualStyleBackColor = true;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(56, 196);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 22);
            this.txtLocation.TabIndex = 4;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(56, 158);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 22);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Location = new System.Drawing.Point(56, 127);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(100, 22);
            this.txtNationalCode.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(56, 86);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 22);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(56, 48);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtFirstName.TabIndex = 0;
            // 
            // FrmAddTeacher
            // 
            this.AcceptButton = this.btnConf;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(277, 442);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtNationalCode);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.grbStudy);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.lblLocatioan);
            this.Controls.Add(this.lblNationalCode);
            this.Controls.Add(this.lblPhonNumber);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "FrmAddTeacher";
            this.Text = "FrmAddTeacher";
            this.Load += new System.EventHandler(this.FrmAddTeacher_Load);
            this.grbStudy.ResumeLayout(false);
            this.grbStudy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.Label lblPhonNumber;
        private System.Windows.Forms.Label lblLocatioan;
        private System.Windows.Forms.GroupBox grbStudy;
        private System.Windows.Forms.RadioButton rdbExperimental;
        private System.Windows.Forms.RadioButton rdbMath;
        private System.Windows.Forms.RadioButton rdbComputer;
        private txt txtFirstName;
        private txt txtLastName;
        private txt txtNationalCode;
        private txt txtPhoneNumber;
        private txt txtLocation;
    }
}