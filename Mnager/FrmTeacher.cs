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
    public partial class FrmTeacher : Form
    {
        TeacherManger teacherManger;
        public FrmTeacher()
        {
            InitializeComponent();
            teacherManger = new TeacherManger();
        }
        void FillDgv()
        {
            List<Teacher> teachers = teacherManger.GetAll().ToList();
            int count = teacherManger.Count();
            for (int i = 0; i < count; i++)
                teachers[i].Id = i;
            dgvTeacher.DataSource = teachers.ToList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FrmAddTeacher(FillDgv)
            {
                Text = "Add Teacher"
            }.ShowDialog();
        }

        private void dgvTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == dgvTeacher.Columns[ColDelete.Name].Index)
            {
                var student = dgvTeacher.Rows[e.RowIndex].DataBoundItem as Student;
                if (student != null)
                {
                    DialogResult msg = AlertHelper.Question("آیا از حذف مطمِن هستید");
                    if (msg == DialogResult.Yes)
                    {
                        teacherManger.Remove(e.RowIndex);
                        FillDgv();
                    }
                }
            }
            else
                if (e.ColumnIndex == dgvTeacher.Columns[ColEdit.Name].Index)
            {
                var teacher = dgvTeacher.Rows[e.RowIndex].DataBoundItem as Teacher;
                if (teacher != null)
                {
                    var frmAddTeacher = new FrmAddTeacher(FillDgv)
                    {
                        Text = $"Edit Teacher {teacher.GetFullName}",
                        teacherEdit = teacher
                    };
                    frmAddTeacher.ShowDialog();
                }
            }
        }
    }
}
