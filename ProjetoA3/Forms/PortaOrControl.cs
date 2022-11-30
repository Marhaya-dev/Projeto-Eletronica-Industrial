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
    public partial class PortaOrControl : UserControl
    {
        public PortaOrControl()
        {
            InitializeComponent();
        }

        private void labelEntrada1_Click(object sender, EventArgs e)
        {
            if (labelEntrada1.Text == "0")
            {
                labelEntrada1.Text = "1";
            }
            else
            {
                labelEntrada1.Text = "0";
            }

            PortaOr();
        }

        private void PortaOr()
        {
            if (labelEntrada1.Text == "0" && labelEntrada2.Text == "0")
            {
                pictureLedGrey.Show();
                pictureLedGrey.BringToFront();
            }

            else
            {
                pictureLedRed.Show();
                pictureLedRed.BringToFront();
            }
        }

        private void labelEntrada2_Click(object sender, EventArgs e)
        {
            if (labelEntrada2.Text == "0")
            {
                labelEntrada2.Text = "1";
            }
            else
            {
                labelEntrada2.Text = "0";
            }

            PortaOr();
        }

        private void PortaOrControl_Load(object sender, EventArgs e)
        {
            PortaOr();
        }
    }
}
