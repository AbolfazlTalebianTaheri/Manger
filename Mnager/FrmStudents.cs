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
    public partial class FrmStudents : Form
    {
        StudentManager studentManager;
        public FrmStudents()
        {
            InitializeComponent();
            studentManager = new StudentManager();
        }

        private void FrmStudents_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result= AlertHelper.Question("آیا از خروج اطمینان دارید ؟");
            if(result == DialogResult.No)
                e.Cancel = true;
           DialogResult = DialogResult.OK;
        }
        void FillDgv() 
        {
            List<Student> students = studentManager.GetAll().ToList();
            int count = studentManager.Count();
            for (int i = 0; i < count; i++)
                students[i].StudentCode = i;
            dgvStudent.DataSource = students.ToList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmStudent = new FrmStudent(FillDgv)
            {
                Text = "Add Student"
            };
            frmStudent.ShowDialog();
        }


        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == dgvStudent.Columns[ColDelete.Name].Index)
            {
                var student = dgvStudent.Rows[e.RowIndex].DataBoundItem as Student;
                if (student != null)
                {
                    DialogResult msg = AlertHelper.Question("آیا از حذف مطمِن هستید");
                    if (msg == DialogResult.Yes)
                    {
                        studentManager.Remove(e.RowIndex);
                        FillDgv();
                    }
                }
            }
            else
                if (e.ColumnIndex == dgvStudent.Columns[ColEdit.Name].Index)
            {
                var student = dgvStudent.Rows[e.RowIndex].DataBoundItem as Student;
                if (student != null)
                {
                    var frmStudent = new FrmStudent(FillDgv)
                    {
                        Text = $"Edit Student {student.GetFullName}",
                        student = student
                    };
                    frmStudent.ShowDialog();
                }
            }
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmTeacher()
            {
                Text = "Teacher"
            }.ShowDialog();
            this.Show();
        }
    }
}
