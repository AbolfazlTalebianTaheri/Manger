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
    public partial class FrmPersons : Form
    {
        PersonManger personManger;
        public FrmPersons()
        {
            InitializeComponent();
            if (personManger == null)
                personManger = new PersonManger();
        }
        void FillDgV()
        {
            dgvPerson.DataSource = personManger.GetPerson().ToList();
        }
        private void FrmPersons_Load(object sender, EventArgs e)
        {
            FillDgV();
        }

        private void FrmPersons_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult checkExit = AlertHelper.Question("آیا از خروج مطمِن هستید");
            if (checkExit == DialogResult.Yes)
                Application.Exit();
            else
                e.Cancel = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmPerson frmPerson = new FrmPerson{
                Text = "Add Person"
            };
            if (frmPerson.ShowDialog() == DialogResult.OK)
                FillDgV();
        }
        private void dgvPerson_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == dgvPerson.Columns[colDelete.Name].Index)
            {
                var person = dgvPerson.Rows[e.RowIndex].DataBoundItem as Person;
                if (person != null)
                {
                    DialogResult msg = AlertHelper.Question("آیا از حذف مطمِن هستید");
                    if (msg == DialogResult.Yes)
                    {
                        personManger.RemovePerson(person);
                        FillDgV();
                    }
                 }
            }
            else
            if (e.ColumnIndex == dgvPerson.Columns[colEdite.Name].Index)
            {
                var person = dgvPerson.Rows[e.RowIndex].DataBoundItem as Person;
                FrmPerson frmPerson = new FrmPerson
                {
                    Text = $"Edite {person.GetFullName}",
                    Person = person
                };
                if(frmPerson.ShowDialog() == DialogResult.OK)
                    FillDgV();
            }
        }
    }
}
