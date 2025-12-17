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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConf = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.rdbElementary = new System.Windows.Forms.RadioButton();
            this.rdbGuidance = new System.Windows.Forms.RadioButton();
            this.rdbConservatory = new System.Windows.Forms.RadioButton();
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
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(54, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConf
            // 
            this.btnConf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConf.Location = new System.Drawing.Point(149, 296);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(75, 33);
            this.btnConf.TabIndex = 6;
            this.btnConf.Text = "تایید";
            this.btnConf.UseVisualStyleBackColor = true;
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(160, 116);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(77, 16);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "نام خوانوادگی";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(216, 78);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(21, 16);
            this.lblFirstName.TabIndex = 10;
            this.lblFirstName.Text = "نام";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(54, 110);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 22);
            this.txtLastName.TabIndex = 11;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(54, 72);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtFirstName.TabIndex = 8;
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
            // rdbGuidance
            // 
            this.rdbGuidance.AutoSize = true;
            this.rdbGuidance.Location = new System.Drawing.Point(99, 47);
            this.rdbGuidance.Name = "rdbGuidance";
            this.rdbGuidance.Size = new System.Drawing.Size(74, 20);
            this.rdbGuidance.TabIndex = 0;
            this.rdbGuidance.TabStop = true;
            this.rdbGuidance.Text = "راهنمایی";
            this.rdbGuidance.UseVisualStyleBackColor = true;
            // 
            // rdbConservatory
            // 
            this.rdbConservatory.AutoSize = true;
            this.rdbConservatory.Location = new System.Drawing.Point(51, 73);
            this.rdbConservatory.Name = "rdbConservatory";
            this.rdbConservatory.Size = new System.Drawing.Size(122, 20);
            this.rdbConservatory.TabIndex = 0;
            this.rdbConservatory.TabStop = true;
            this.rdbConservatory.Text = "دبیرستان /هنرستان";
            this.rdbConservatory.UseVisualStyleBackColor = true;
            // 
            // FrmStudent
            // 
            this.AcceptButton = this.btnConf;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(267, 351);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.grbGrade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmStudent";
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
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
    }
}