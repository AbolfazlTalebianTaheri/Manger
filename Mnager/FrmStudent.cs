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
        StudentManager studentManager;
        Action _action;
        public FrmStudent(Action action)
        {
            InitializeComponent();
            studentManager = new StudentManager();
            _action = action;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = AlertHelper.Question("آیا از خروج اطمینان دارید ؟");
            if (result == DialogResult.OK)
                this.Close();
        }
        bool isEdit = false;
        void AddStudent()
        {
            if (student == null)
                student = new Student();
            else
                isEdit = true;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string nationalCode = txtNationalCode.Text;
            OperionResult operionResult = Student.IsValidinput(firstName, lastName, nationalCode);
            if (operionResult.IsSuccess)
            {
                bool isFind = true;
                if (!isEdit)
                 isFind = studentManager.Duplicate(firstName, lastName);
                if (isFind)
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.NationalCode = nationalCode;
                    if (rdbElementary.Checked)
                        student.Grade = Grades.Elementary;
                    else if (rdbGuidance.Checked)
                        student.Grade = Grades.Guidance;
                    else if (rdbConservatory.Checked)
                        student.Grade = Grades.Conservatory;

                    if (!isEdit)
                    {
                        studentManager.Add(student);
                        txtFirstName.Clear();
                        txtLastName.Clear();
                        txtFirstName.Focus();
                    }
                    else
                    {
                        studentManager.Edit(student);
                        this.Close();
                    }
                    if (_action != null)
                        _action();
                    student = null;
                    MessageBox.Show(operionResult.Message);
                }
                else
                {
                    MessageBox.Show("این دانش آموزش قبلا در سامانه ثبت شده است !");
                    student = null;
                }
            }
            else
                MessageBox.Show(operionResult.Message);
        }
        private void btnConf_Click(object sender, EventArgs e)
        {
            AddStudent();
            this.Close();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            if (student != null)
            {
                txtFirstName.Text = student.FirstName;
                txtLastName.Text = student.LastName;
                txtFirstName.Focus();
                if (student.GetGrade == "ابتدایی")
                    rdbElementary.Checked = true;
                else if (student.GetGrade == "راهنمایی")
                    rdbGuidance.Checked = true;
                else if (student.GetGrade == "هنرستان")
                    rdbConservatory.Checked = true;
                isEdit = true;
                btnAddNewStudent.Enabled = false;
            }
            else rdbElementary.Checked = true;
        }

        private void btnConfAndNew_Click(object sender, EventArgs e)
        {
            AddStudent();
        }
    }
}
