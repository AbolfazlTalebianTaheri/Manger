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
            dgvStudent.DataSource= studentManager.GetAll().ToList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmStudent = new FrmStudent
            {
                Text = "Add Student"
            };
            frmStudent.ShowDialog();
            FillDgv();
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
                    var frmStudent = new FrmStudent()
                    {
                        Text = "Edit Student",
                        student = student
                    };
                    frmStudent.ShowDialog();
                    FillDgv();
                }
            }
        }
    }
}
