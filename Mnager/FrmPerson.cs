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
    public partial class FrmPerson : Form
    {
        PersonManger personManger;
        public Person Person { get; set; }
        public FrmPerson()
        {
            InitializeComponent();
            personManger = new PersonManger();
        }

        private void FrmPerson_Load(object sender, EventArgs e)
        {
            if (Person != null)
            {
                txtFirstName.Text = Person.FirstName;
                txtLastName.Text = Person.LastName;
                txtNationalCode.Text= Person.NationalCode;
                if (Person.Gender == Genders.Man)
                    rdbMan.Checked = true;
                if (Person.Gender == Genders.WoMan)
                    rdbWoMan.Checked = true;
                else
                    rdbUnknown.Checked = true;
            }
            else
                rdbUnknown.Checked = true;
        }
        void TxtClear()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtNationalCode.Clear();
            rdbUnknown.Checked = true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult ca = AlertHelper.Question("از لغو تغیرات مطمِن هستید ؟");
            if (ca == DialogResult.Yes)
                this.Close();
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            bool isEdite = false;
            if (Person == null)
                Person = new Person();
            else
                isEdite = true;
            string FirestName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string nationalCode = txtNationalCode.Text;
            OperionResult operionResult = Person.IsValidinput(FirestName, lastName, nationalCode);
            if (operionResult.IsSuccess == true)
            {
                Person.FirstName = FirestName;
                Person.LastName = lastName;
                Person.NationalCode = nationalCode;
                if (rdbMan.Checked)
                    Person.Gender = Genders.Man;
                if (rdbWoMan.Checked)
                    Person.Gender = Genders.WoMan;
                else
                    Person.Gender = Genders.Unknown;
                if (!isEdite)
                    personManger.Add(Person);
                DialogResult = DialogResult.OK;
                MessageBox.Show(operionResult.Message);
                TxtClear();
            }
            else
                MessageBox.Show(operionResult.Message);
        }

        private void txtNationalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
