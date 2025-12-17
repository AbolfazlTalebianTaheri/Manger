using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mnager.FrmPerson;

namespace Mnager
{
    public partial class FrmStudent : Form
    {
        public Student student { get; set; }
        StudentManager StudentManager;
        public FrmStudent()
        {
            InitializeComponent();
            StudentManager = new StudentManager();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = AlertHelper.Question("آیا از خروج اطمینان دارید ؟");
            if (result == DialogResult.OK)
                this.Close();
        }
        bool isEdit = false;
        private void btnConf_Click(object sender, EventArgs e)
        {
            if (student == null)
                student = new Student();
            else
                isEdit = true;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            OperionResult operionResult = Student.IsValidinput(firstName, lastName);
            if (operionResult.IsSuccess)
            {
                student.FirstName = firstName;
                student.LastName = lastName;
                if (!isEdit)
                    StudentManager.Add(student);
                else
                    StudentManager.Edit(student);
                MessageBox.Show(operionResult.Message);
            }
            else
                MessageBox.Show(operionResult.Message);
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            if (student != null)
            {
                txtFirstName.Text = student.FirstName;
                txtLastName.Text = student.LastName;
                txtFirstName.Focus();
                if (student.Grade == "Elementary")
                    rdbElementary.Checked = true;
                else if (student.Grade == "Middle")
                    rdbGuidance.Checked = true;
                else if (student.Grade == "High")
                    rdbConservatory.Checked = true;
            }
            else rdbElementary.Checked = true;
        }
    }
}
