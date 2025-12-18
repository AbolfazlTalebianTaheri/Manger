using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mnager
{
    public partial class FrmAddTeacher : Form
    {
        Teacher teacher;
        TeacherManger teacherManger;
        Action _action;
        public Teacher teacherEdit { get; set; }

        public FrmAddTeacher(Action action)
        {
            InitializeComponent();
            teacher = new Teacher();
            teacherManger = new TeacherManger();
            _action = action;
        }
        bool isEdit = false;
        private void btnConf_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string nationalCode = txtNationalCode.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string location = txtLocation.Text;
            OperionResult isValidInput = Teacher.IsValidinput(firstName, lastName, location, phoneNumber, nationalCode);
            if (isValidInput.IsSuccess)
            {
                OpertianResualtTeacher opertianResualt = teacherManger.Duplicate(phoneNumber, nationalCode);
                teacher.FirstName = firstName;
                teacher.LastName = lastName;
                teacher.NationalCode = nationalCode;
                teacher.PhonNumber = phoneNumber;
                teacher.Locatioan = location;
                if (rdbComputer.Checked)
                    teacher.Study = Field_Of_Study.Computer;
                else if (rdbMath.Checked)
                    teacher.Study = Field_Of_Study.Math;
                else if (rdbExperimental.Checked)
                    teacher.Study = Field_Of_Study.Experimental;
                if (!isEdit)
                {
                    if (!opertianResualt.IsSuccess)
                    {
                        teacherManger.Add(teacher);

                        txtFirstName.Clear();
                        txtLastName.Clear();
                        txtLocation.Clear();
                        txtNationalCode.Clear();
                        txtPhoneNumber.Clear();
                        rdbComputer.Checked = true;

                        txtFirstName.Focus();
                    }
                    else
                    {
                        MessageBox.Show(" قبلا این معلم ثبت شده است ");
                        teacher = null;
                    }
                }
                else
                {
                    teacherManger.Edit(teacherEdit.PhonNumber, teacherEdit.Locatioan, teacher);
                    teacherEdit = null;
                    teacher = null;
                }

                if (_action != null)
                    _action();
            }
            else
                MessageBox.Show(isValidInput.Message);
        }

        private void FrmAddTeacher_Load(object sender, EventArgs e)
        {
            if (teacherEdit != null)
            {
                txtFirstName.Text = teacherEdit.FirstName;
                txtLastName.Text = teacherEdit.LastName;
                txtLocation.Text = teacherEdit.Locatioan;
                txtNationalCode.Text = teacherEdit.NationalCode;
                txtPhoneNumber.Text = teacherEdit.PhonNumber;
                if (teacherEdit.Study == Field_Of_Study.Computer)
                    rdbComputer.Checked = true;
                else if (teacherEdit.Study == Field_Of_Study.Math)
                    rdbMath.Checked = true;
                else if (teacherEdit.Study == Field_Of_Study.Experimental)
                    rdbExperimental.Checked = true;
                isEdit = true;
            }
            else rdbComputer.Checked = true;
        }
    }
}
