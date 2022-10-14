﻿using ProjetoA3.Domain.Settings;
using ProjetoA3.Domain.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            if (!double.TryParse(txtGerador.Text, out double zero) || zero == 0)
            {
                Alert($"Tensão do gerador inválida.");

                return false;
            }

            if (!double.TryParse(txtFrequencia.Text, out zero) || zero == 0)
            {
                Alert($"Frequência do gerador inválida.");

                return false;
            }

            if (!double.TryParse(txtR1.Text, out zero) || zero == 0)
            {
                Alert($"Resistência 1 inválida.");

                return false;
            }

            if (!double.TryParse(txtR2.Text, out zero) || zero == 0)
            {
                Alert($"Resistência 2 inválida.");

                return false;
            }

            if (!double.TryParse(txtR3.Text, out zero) || zero == 0)
            {
                Alert($"Resistência 3 inválida.");

                return false;
            }

            if (!double.TryParse(txtR4.Text, out zero) || zero == 0)
            {
                Alert($"Resistência 4 inválida.");

                return false;
            }

            if (!double.TryParse(txtR5.Text, out zero) || zero == 0)
            {
                Alert($"Resistência 5 inválida.");

                return false;
            }

            if (!double.TryParse(txtR6.Text, out zero) || zero == 0)
            {
                Alert($"Resistência 6 inválida.");

                return false;
            }

            return true;
        }

        public DadosP1 GetInput()
        {
            var result = new DadosP1();

            result.TensaoGerador = Convert.ToDouble(txtGerador.Text.Replace(".", ","));
            result.Frequencia = Convert.ToDouble(txtFrequencia.Text.Replace(".", ","));
            result.R1 = Convert.ToDouble(txtR1.Text.Replace(".", ","));
            result.R2 = Convert.ToDouble(txtR2.Text.Replace(".", ","));
            result.R3 = Convert.ToDouble(txtR3.Text.Replace(".", ","));
            result.R4 = Convert.ToDouble(txtR4.Text.Replace(".", ","));
            result.R5 = Convert.ToDouble(txtR5.Text.Replace(".", ","));
            result.R6 = Convert.ToDouble(txtR6.Text.Replace(".", ","));

            return result;
        }

        public bool SaveInput()
        {
            if (ValidateInput())
            {
                var input = GetInput();

                JsonUtils.SaveP1(input);

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

        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            var form = new ResultadosP2Form();
            form.ShowDialog();
        }

        private void btnLimpar2_Click(object sender, EventArgs e)
        {

        }
    }
}
