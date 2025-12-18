using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mnager
{
    public class txt : TextBox
    {
        Color _originalBackColor;

        public txt()
        {
            this.KeyDown += EnterTextBox_KeyDown;
            this.GotFocus += EnterTextBox_GotFocus;
            this.LostFocus += EnterTextBox_LostFocus;
        }

        private void EnterTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.Parent.SelectNextControl(this, true, true, true, true);
            }
        }

        private void EnterTextBox_GotFocus(object sender, EventArgs e)
        {
            _originalBackColor = this.BackColor;
            this.BackColor = Color.LightYellow;
        }

        private void EnterTextBox_LostFocus(object sender, EventArgs e)
        {
            this.BackColor = _originalBackColor;
        }
    }
}
