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
            List<Person> persons = personManger.GetPerson().ToList();
            int count = personManger.Count();
            for (int i = 0; i < count; i++)
                persons[i].Id = i;
            dgvPerson.DataSource = persons.ToList();
        }
        private void FrmPersons_Load(object sender, EventArgs e)
        {
            FillDgV();
        }

        private void FrmPersons_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult checkExit = AlertHelper.Question("آیا از خروج مطمِن هستید");
            if (checkExit == DialogResult.No)
                e.Cancel = true;
            DialogResult = DialogResult.OK;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmPerson frmPerson = new FrmPerson(FillDgV){
                Text = "Add Person"
            };
            frmPerson.OnFillDgv += FrmPerson_OnFillDgv;
            frmPerson.ShowDialog();
                FillDgV();
        }

        private void FrmPerson_OnFillDgv()
        {
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
                FrmPerson frmPerson = new FrmPerson(FillDgV)
                {
                    Text = $"Edite {person.GetFullName}",
                    Person = person
                };
                frmPerson.OnFillDgv += FrmPerson_OnFillDgv;
                if(frmPerson.ShowDialog() == DialogResult.OK)
                    FillDgV();
            }
        }
    }
}
