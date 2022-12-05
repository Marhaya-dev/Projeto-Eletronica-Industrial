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

        private void labelEntradaA_Click(object sender, EventArgs e)
        {
            if (labelEntradaA.Text == "0")
            {
                labelEntradaA.Text = "1";
            }
            else
            {
                labelEntradaA.Text = "0";
            }

            PortaNot();
        }

        private void PortaNot()
        {
            if (labelEntradaA.Text == "0")
            {
                pictureLedGreen.Show();
                pictureLedGreen.BringToFront();
            }
            else
            {
                pictureLedGrey.Show();
                pictureLedGrey.BringToFront();
            }
        }

        private void PortaNotControl_Load(object sender, EventArgs e)
        {
            PortaNot();
        }
    }
}
