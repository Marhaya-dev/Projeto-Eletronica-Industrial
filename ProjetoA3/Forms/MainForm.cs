using ProjetoA3.Domain.Settings;
using ProjetoA3.Domain.Utils;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (SaveInput())
            {
                var form = new ResultadosP1Form();
                form.ShowDialog();
            }
        }

        public bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtGerador.Text))
            {
                Alert($"Por favor, informe a tensão do gerador.");

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFrequencia.Text))
            {
                Alert($"Por favor, informe a frequência do gerador.");

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtR1.Text))
            {
                Alert($"Por favor, informe o valor da Resistência 1.");

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtR2.Text))
            {
                Alert($"Por favor, informe o valor da Resistência 2.");

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtR3.Text))
            {
                Alert($"Por favor, informe o valor da Resistência 3.");

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtR4.Text))
            {
                Alert($"Por favor, informe o valor da Resistência 4.");

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtR5.Text))
            {
                Alert($"Por favor, informe o valor da Resistência 5.");

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtR6.Text))
            {
                Alert($"Por favor, informe o valor da Resistência 6.");

                return false;
            }

            return true;
        }

        public Dados GetInput()
        {
            var result = new Dados();

            result.TensaoGerador = txtGerador.Text;
            result.Frequencia = txtFrequencia.Text;
            result.R1 = txtR1.Text;
            result.R2 = txtR2.Text;
            result.R3 = txtR3.Text;
            result.R4 = txtR4.Text;
            result.R5 = txtR5.Text;
            result.R6 = txtR6.Text;

            return result;
        }

        public bool SaveInput()
        {
            if (ValidateInput())
            {
                var input = GetInput();

                JsonUtils.Save(input);

                return true;
            }

            return false;
        }

        public static DialogResult Alert(string message)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string caption = "Aviso";
            return MessageBox.Show(message, caption, buttons);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtGerador.Clear();
            txtFrequencia.Clear();
            txtR1.Clear();
            txtR2.Clear();
            txtR3.Clear();
            txtR4.Clear();
            txtR5.Clear();
            txtR6.Clear();
        }
    }
}
