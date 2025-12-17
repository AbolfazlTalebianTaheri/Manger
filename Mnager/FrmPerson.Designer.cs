namespace Mnager
{
    partial class FrmPerson
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.grbGender = new System.Windows.Forms.GroupBox();
            this.rdbUnknown = new System.Windows.Forms.RadioButton();
            this.rdbWoMan = new System.Windows.Forms.RadioButton();
            this.rdbMan = new System.Windows.Forms.RadioButton();
            this.btnConf = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(26, 27);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(188, 33);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(21, 16);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "نام";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(26, 65);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 22);
            this.txtLastName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(132, 71);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(77, 16);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "نام خوانوادگی";
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Location = new System.Drawing.Point(26, 103);
            this.txtNationalCode.MaxLength = 10;
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(100, 22);
            this.txtNationalCode.TabIndex = 2;
            this.txtNationalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNationalCode_KeyPress);
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.Location = new System.Drawing.Point(170, 109);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.Size = new System.Drawing.Size(39, 16);
            this.lblNationalCode.TabIndex = 1;
            this.lblNationalCode.Text = "کدملی";
            // 
            // grbGender
            // 
            this.grbGender.Controls.Add(this.rdbUnknown);
            this.grbGender.Controls.Add(this.rdbWoMan);
            this.grbGender.Controls.Add(this.rdbMan);
            this.grbGender.Location = new System.Drawing.Point(26, 142);
            this.grbGender.Name = "grbGender";
            this.grbGender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbGender.Size = new System.Drawing.Size(158, 100);
            this.grbGender.TabIndex = 3;
            this.grbGender.TabStop = false;
            this.grbGender.Text = "جنسیت";
            // 
            // rdbUnknown
            // 
            this.rdbUnknown.AutoSize = true;
            this.rdbUnknown.Location = new System.Drawing.Point(52, 74);
            this.rdbUnknown.Name = "rdbUnknown";
            this.rdbUnknown.Size = new System.Drawing.Size(83, 20);
            this.rdbUnknown.TabIndex = 2;
            this.rdbUnknown.TabStop = true;
            this.rdbUnknown.Text = "Unknown";
            this.rdbUnknown.UseVisualStyleBackColor = true;
            // 
            // rdbWoMan
            // 
            this.rdbWoMan.AutoSize = true;
            this.rdbWoMan.Location = new System.Drawing.Point(60, 47);
            this.rdbWoMan.Name = "rdbWoMan";
            this.rdbWoMan.Size = new System.Drawing.Size(75, 20);
            this.rdbWoMan.TabIndex = 2;
            this.rdbWoMan.TabStop = true;
            this.rdbWoMan.Text = "WoMan";
            this.rdbWoMan.UseVisualStyleBackColor = true;
            // 
            // rdbMan
            // 
            this.rdbMan.AutoSize = true;
            this.rdbMan.Location = new System.Drawing.Point(81, 21);
            this.rdbMan.Name = "rdbMan";
            this.rdbMan.Size = new System.Drawing.Size(54, 20);
            this.rdbMan.TabIndex = 1;
            this.rdbMan.TabStop = true;
            this.rdbMan.Text = "Man";
            this.rdbMan.UseVisualStyleBackColor = true;
            // 
            // btnConf
            // 
            this.btnConf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConf.Location = new System.Drawing.Point(112, 257);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(75, 33);
            this.btnConf.TabIndex = 4;
            this.btnConf.Text = "تایید";
            this.btnConf.UseVisualStyleBackColor = true;
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            //
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(31, 257);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmPerson
            // 
            this.AcceptButton = this.btnConf;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(237, 303);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.grbGender);
            this.Controls.Add(this.lblNationalCode);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtNationalCode);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.MaximumSize = new System.Drawing.Size(255, 350);
            this.MinimumSize = new System.Drawing.Size(250, 350);
            this.Name = "FrmPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPerson";
            this.Load += new System.EventHandler(this.FrmPerson_Load);
            this.grbGender.ResumeLayout(false);
            this.grbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.GroupBox grbGender;
        private System.Windows.Forms.RadioButton rdbUnknown;
        private System.Windows.Forms.RadioButton rdbWoMan;
        private System.Windows.Forms.RadioButton rdbMan;
        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.Button btnCancel;
    }
}