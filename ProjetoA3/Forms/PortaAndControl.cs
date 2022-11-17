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
    public partial class PortaAndControl : UserControl
    {
        public PortaAndControl()
        {
            InitializeComponent();
        }

        private void labelEntrada1_Click(object sender, EventArgs e)
        {
            if (labelEntrada1.Text == "0" )
            {
                labelEntrada1.Text = "1";
            }
            else
            {
                labelEntrada1.Text = "0";
            }

            PortaAnd();
        }

        private void PortaAnd()
        {
            if (labelEntrada1.Text == "1" && labelEntrada2.Text == "1")
            {
                pictureLedRed.Show();
                pictureLedRed.BringToFront();
            }

            else
            {
                pictureLedGrey.Show();
                pictureLedGrey.BringToFront();
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

            PortaAnd();
        }
    }
}
