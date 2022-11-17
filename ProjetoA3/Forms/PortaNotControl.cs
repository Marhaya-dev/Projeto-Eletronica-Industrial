using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoA3.Forms
{
    public partial class PortaNotControl : UserControl
    {
        public PortaNotControl()
        {
            InitializeComponent();
        }

        private void labelEntradaNot_Click(object sender, EventArgs e)
        {
            if (labelEntradaNot.Text == "0")
            {
                labelEntradaNot.Text = "1";

                pictureLedGrey.Show();
                pictureLedGrey.BringToFront();
            }
            else
            {
                labelEntradaNot.Text = "0";

                pictureLedRed.Show();
                pictureLedRed.BringToFront();
            }
        }

        private void PortaNotControl_Load(object sender, EventArgs e)
        {
            pictureLedRed.Show();
            pictureLedRed.BringToFront();
        }
    }
}
