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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            var frmPersons = new FrmPersons();
            this.Hide();
            if (frmPersons.ShowDialog() == DialogResult.OK)
                Application.Exit();
        }
        

        private void btnStudent_Click(object sender, EventArgs e)
        {
            var frmStudent = new FrmStudents();
            this.Hide();
            if (frmStudent.ShowDialog() == DialogResult.OK)
                Application.Exit();
        }
    }
}
