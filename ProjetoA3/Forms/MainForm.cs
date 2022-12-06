using ProjetoA3.Domain.Models;
using ProjetoA3.Domain.Utils;

namespace ProjetoA3.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadReceptores();
            LoadPortasLogicas();
        }

        private void LoadReceptores()
        {
            var items = new Dictionary<string, string>()
            {
                { "127", "Ventilador 127V" },
                { "220", "Liquidificador 220V" }
            };

            cBoxReceptor.ValueMember = "Key";
            cBoxReceptor.DisplayMember = "Value";
            cBoxReceptor.DataSource = new BindingSource(items, null);
        }

        private void LoadPortasLogicas()
        {
            var items = new List<string>
            {
                "NOT",
                "AND",
                "NAND",
                "OR",
                "NOR",
                "XOR",
                "XNOR"
            };

            comboBoxPortas.DataSource = new BindingSource(items, null);

            portaNotControl.Show();
            portaNotControl.BringToFront();
        }

        private void comboBoxPortas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxPortas.SelectedValue.ToString())
            {
                case "NOT":
                    portaNotControl.Show();
                    portaNotControl.BringToFront();
                    break;

                case "AND":
                    portaAndControl.Show();
                    portaAndControl.BringToFront();
                    break;

                case "NAND":
                    portaNandControl.Show();
                    portaNandControl.BringToFront();
                    break;

                case "OR":
                    portaOrControl.Show();
                    portaOrControl.BringToFront();
                    break;

                case "NOR":
                    portaNorControl.Show();
                    portaNorControl.BringToFront();
                    break;

                case "XOR":
                    portaXorControl.Show();
                    portaXorControl.BringToFront();
                    break;

                case "XNOR":
                    portaXnorControl.Show();
                    portaXnorControl.BringToFront();
                    break;
            };
        }

        public static DialogResult Alert(string message)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string caption = "Aviso";
            return MessageBox.Show(message, caption, buttons);
        }

        #region C1
        private void btnCalcularC1_Click(object sender, EventArgs e)
        {
            if (SaveInputC1())
            {
                var form = new ResultadosC1Form();
                form.ShowDialog();
            }
        }

        private void btnLimparC1_Click(object sender, EventArgs e)
        {
            txtGerador.Clear();
            txtR1.Clear();
            txtR2.Clear();
            txtR3.Clear();
            txtR4.Clear();
            txtR5.Clear();
            txtR6.Clear();
            cBoxReceptor.SelectedItem = null;
        }

        public bool SaveInputC1()
        {
            if (ValidateInputC1())
            {
                var input = GetInputC1();

                JsonUtils.SaveC1(input);

                return true;
            }

            return false;
        }

        public bool ValidateInputC1()
        {
            if (cBoxReceptor.SelectedValue == null)
            {
                Alert($"Por favor, informe a tensão do receptor.");

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGerador.Text))
            {
                Alert($"Por favor, informe a tensão do gerador.");

                return false;
            }

            if (!double.TryParse(txtGerador.Text, out double zero) || zero == 0)
            {
                Alert($"Tensão do gerador inválida.");

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtR1.Text))
            {
                Alert($"Por favor, informe o valor da Resistência 1.");

                return false;
            }

            if (!double.TryParse(txtR1.Text, out zero) || zero == 0)
            {
                Alert($"Resistência 1 inválida.");

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtR2.Text))
            {
                Alert($"Por favor, informe o valor da Resistência 2.");

                return false;
            }

            if (!double.TryParse(txtR2.Text, out zero) || zero == 0)
            {
                Alert($"Resistência 2 inválida.");

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtR3.Text))
            {
                Alert($"Por favor, informe o valor da Resistência 3.");

                return false;
            }

            if (!double.TryParse(txtR3.Text, out zero) || zero == 0)
            {
                Alert($"Resistência 3 inválida.");

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtR4.Text))
            {
                Alert($"Por favor, informe o valor da Resistência 4.");

                return false;
            }

            if (!double.TryParse(txtR4.Text, out zero) || zero == 0)
            {
                Alert($"Resistência 4 inválida.");

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtR5.Text))
            {
                Alert($"Por favor, informe o valor da Resistência 5.");

                return false;
            }

            if (!double.TryParse(txtR5.Text, out zero) || zero == 0)
            {
                Alert($"Resistência 5 inválida.");

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtR6.Text))
            {
                Alert($"Por favor, informe o valor da Resistência 6.");

                return false;
            }

            if (!double.TryParse(txtR6.Text, out zero) || zero == 0)
            {
                Alert($"Resistência 6 inválida.");

                return false;
            }

            if (Convert.ToDouble(txtGerador.Text) < Convert.ToDouble(cBoxReceptor.SelectedValue))
            {
                Alert($"A tensão do gerador não pode ser menor que a tensão do receptor.");

                return false;
            }

            return true;
        }

        public DadosC1 GetInputC1()
        {
            var result = new DadosC1();

            result.TensaoGerador = Convert.ToDouble(txtGerador.Text.Replace(".", ","));
            result.R1 = Convert.ToDouble(txtR1.Text.Replace(".", ","));
            result.R2 = Convert.ToDouble(txtR2.Text.Replace(".", ","));
            result.R3 = Convert.ToDouble(txtR3.Text.Replace(".", ","));
            result.R4 = Convert.ToDouble(txtR4.Text.Replace(".", ","));
            result.R5 = Convert.ToDouble(txtR5.Text.Replace(".", ","));
            result.R6 = Convert.ToDouble(txtR6.Text.Replace(".", ","));
            result.TensaoReceptor = Convert.ToDouble(cBoxReceptor.SelectedValue);

            return result;
        }

        #endregion

        #region C2
        private void btnCalcularC2_Click(object sender, EventArgs e)
        {
            if (SaveInputC2())
            {
                var form = new ResultadosC2Form();
                form.ShowDialog();
            }
        }

        private void btnLimparC2_Click(object sender, EventArgs e)
        {
            txtTensaoC2.Clear();
            txtResistenciaC2.Clear();
            txtN1C2.Clear();
            txtN2C2.Clear();
            txtCapacitorC2.Clear();
        }

        public bool SaveInputC2()
        {
            if (ValidateInputC2())
            {
                var input = GetInputC2();

                JsonUtils.Save(input, "DadosC2");

                return true;
            }

            return false;
        }

        public bool ValidateInputC2()
        {
            if (string.IsNullOrWhiteSpace(txtTensaoC2.Text))
            {
                Alert($"Por favor, informe a tensão primária.");

                return false;
            }

            if (!double.TryParse(txtTensaoC2.Text, out double zero) || zero == 0)
            {
                Alert($"Tensão primária inválida.");

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtResistenciaC2.Text))
            {
                Alert($"Por favor, informe o valor da Resistência 1.");

                return false;
            }

            if (!double.TryParse(txtResistenciaC2.Text, out zero) || zero == 0)
            {
                Alert($"Resistência 1 inválida.");

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtN1C2.Text))
            {
                Alert($"Por favor, informe o valor de N1.");

                return false;
            }

            if (!double.TryParse(txtN1C2.Text, out zero) || zero == 0)
            {
                Alert($"N1 inválida.");

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtN2C2.Text))
            {
                Alert($"Por favor, informe o valor de N2.");

                return false;
            }

            if (!double.TryParse(txtN2C2.Text, out zero) || zero == 0)
            {
                Alert($"N2 inválida.");

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCapacitorC2.Text))
            {
                Alert($"Por favor, informe o valor do Capacitor.");

                return false;
            }

            if (!double.TryParse(txtCapacitorC2.Text, out zero) || zero == 0)
            {
                Alert($"Capacitor inválido.");

                return false;
            }

            return true;
        }

        public DadosCRetificadores GetInputC2()
        {
            var result = new DadosCRetificadores();

            result.TensaoPrimaria = Convert.ToDouble(txtTensaoC2.Text.Replace(".", ","));
            result.R1 = Convert.ToDouble(txtResistenciaC2.Text.Replace(".", ","));
            result.N1 = Convert.ToDouble(txtN1C2.Text.Replace(".", ","));
            result.N2 = Convert.ToDouble(txtN2C2.Text.Replace(".", ","));
            result.Capacitor = Convert.ToDouble(txtCapacitorC2.Text.Replace(".", ","));

            return result;
        }

        #endregion

        #region C3

        private void btnCalcularC3_Click(object sender, EventArgs e)
        {
            if (SaveInputC3())
            {
                var form = new ResultadosC3Form();
                form.ShowDialog();
            }
        }

        private void btnLimparC3_Click(object sender, EventArgs e)
        {
            txtTensaoC3.Clear();
            txtResistenciaC3.Clear();
            txtN1C3.Clear();
            txtN2C3.Clear();
            txtCapacitorC3.Clear();
        }

        public bool SaveInputC3()
        {
            if (ValidateInputC3())
            {
                var input = GetInputC3();

                JsonUtils.Save(input, "DadosC3");

                return true;
            }

            return false;
        }

        public bool ValidateInputC3()
        {
            if (string.IsNullOrWhiteSpace(txtTensaoC3.Text))
            {
                Alert($"Por favor, informe a tensão primária.");

                return false;
            }

            if (!double.TryParse(txtTensaoC3.Text, out double zero) || zero == 0)
            {
                Alert($"Tensão primária inválida.");

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtResistenciaC3.Text))
            {
                Alert($"Por favor, informe o valor da Resistência 1.");

                return false;
            }

            if (!double.TryParse(txtResistenciaC3.Text, out zero) || zero == 0)
            {
                Alert($"Resistência 1 inválida.");

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtN1C3.Text))
            {
                Alert($"Por favor, informe o valor de N1.");

                return false;
            }

            if (!double.TryParse(txtN1C3.Text, out zero) || zero == 0)
            {
                Alert($"N1 inválida.");

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtN2C3.Text))
            {
                Alert($"Por favor, informe o valor de N2.");

                return false;
            }

            if (!double.TryParse(txtN2C3.Text, out zero) || zero == 0)
            {
                Alert($"N2 inválida.");

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCapacitorC3.Text))
            {
                Alert($"Por favor, informe o valor do Capacitor.");

                return false;
            }

            if (!double.TryParse(txtCapacitorC3.Text, out zero) || zero == 0)
            {
                Alert($"Capacitor inválido.");

                return false;
            }

            return true;
        }

        public DadosCRetificadores GetInputC3()
        {
            var result = new DadosCRetificadores();

            result.TensaoPrimaria = Convert.ToDouble(txtTensaoC3.Text.Replace(".", ","));
            result.R1 = Convert.ToDouble(txtResistenciaC3.Text.Replace(".", ","));
            result.N1 = Convert.ToDouble(txtN1C3.Text.Replace(".", ","));
            result.N2 = Convert.ToDouble(txtN2C3.Text.Replace(".", ","));
            result.Capacitor = Convert.ToDouble(txtCapacitorC3.Text.Replace(".", ","));

            return result;
        }

        #endregion

        #region C4

        private void btnCalcularC4_Click(object sender, EventArgs e)
        {
            if (SaveInputC4())
            {
                var form = new ResultadosC4Form();
                form.ShowDialog();
            }
        }

        private void btnLimparC4_Click(object sender, EventArgs e)
        {
            txtTensaoC4.Clear();
            txtResistenciaC4.Clear();
            txtN1C4.Clear();
            txtN2C4.Clear();
            txtCapacitorC4.Clear();
        }

        public bool SaveInputC4()
        {
            if (ValidateInputC4())
            {
                var input = GetInputC4();

                JsonUtils.Save(input, "DadosC4");

                return true;
            }

            return false;
        }

        public bool ValidateInputC4()
        {
            if (string.IsNullOrWhiteSpace(txtTensaoC4.Text))
            {
                Alert($"Por favor, informe a tensão primária.");

                return false;
            }

            if (!double.TryParse(txtTensaoC4.Text, out double zero) || zero == 0)
            {
                Alert($"Tensão primária inválida.");

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtResistenciaC4.Text))
            {
                Alert($"Por favor, informe o valor da Resistência 1.");

                return false;
            }

            if (!double.TryParse(txtResistenciaC4.Text, out zero) || zero == 0)
            {
                Alert($"Resistência 1 inválida.");

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtN1C4.Text))
            {
                Alert($"Por favor, informe o valor de N1.");

                return false;
            }

            if (!double.TryParse(txtN1C4.Text, out zero) || zero == 0)
            {
                Alert($"N1 inválida.");

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtN2C4.Text))
            {
                Alert($"Por favor, informe o valor de N2.");

                return false;
            }

            if (!double.TryParse(txtN2C4.Text, out zero) || zero == 0)
            {
                Alert($"N2 inválida.");

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCapacitorC4.Text))
            {
                Alert($"Por favor, informe o valor do Capacitor.");

                return false;
            }

            if (!double.TryParse(txtCapacitorC4.Text, out zero) || zero == 0)
            {
                Alert($"Capacitor inválido.");

                return false;
            }

            return true;
        }

        public DadosCRetificadores GetInputC4()
        {
            var result = new DadosCRetificadores();

            result.TensaoPrimaria = Convert.ToDouble(txtTensaoC4.Text.Replace(".", ","));
            result.R1 = Convert.ToDouble(txtResistenciaC4.Text.Replace(".", ","));
            result.N1 = Convert.ToDouble(txtN1C4.Text.Replace(".", ","));
            result.N2 = Convert.ToDouble(txtN2C4.Text.Replace(".", ","));
            result.Capacitor = Convert.ToDouble(txtCapacitorC4.Text.Replace(".", ","));

            return result;
        }

        #endregion
    }
}
