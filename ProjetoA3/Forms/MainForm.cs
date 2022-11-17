using ProjetoA3.Domain.Settings;
using ProjetoA3.Domain.Utils;
using System.Windows.Forms;

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
                "NXOR"
            };

            comboBoxPortas.DataSource = new BindingSource(items, null);

            portaNotControl.Show();
            portaNotControl.BringToFront();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (SaveInput())
            {
                var form = new ResultadosP1Form();
                form.ShowDialog();
            }
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
            cBoxReceptor.SelectedItem = null;
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

        public bool ValidateInput()
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

            if (Convert.ToDouble(txtGerador.Text) < Convert.ToDouble(cBoxReceptor.SelectedValue))
            {
                Alert($"A tensão do gerador não pode ser menor que a tensão do receptor.");

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
            result.TensaoReceptor = Convert.ToDouble(cBoxReceptor.SelectedValue);

            return result;
        }

        public static DialogResult Alert(string message)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string caption = "Aviso";
            return MessageBox.Show(message, caption, buttons);
        }

        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            if (SaveInput2())
            {
                var form = new ResultadosP2Form();
                form.ShowDialog();
            }
        }

        public bool SaveInput2()
        {
            if (ValidateInput2())
            {
                var input = GetInput2();

                JsonUtils.SaveP2(input);

                return true;
            }

            return false;
        }

        public bool ValidateInput2()
        {
            if (string.IsNullOrWhiteSpace(txtTensaoSecundaria.Text))
            {
                Alert($"Por favor, informe a tensão secundária.");

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtResistenciaP2.Text))
            {
                Alert($"Por favor, informe o valor da Resistência 1.");

                return false;
            }

            if (!double.TryParse(txtTensaoSecundaria.Text, out double zero) || zero == 0)
            {
                Alert($"Tensão secundária inválida.");

                return false;
            }

            if (!double.TryParse(txtResistenciaP2.Text, out zero) || zero == 0)
            {
                Alert($"Resistência 1 inválida.");

                return false;
            }

            return true;
        }

        public DadosP2 GetInput2()
        {
            var result = new DadosP2();

            result.TensaoSecundaria = Convert.ToDouble(txtTensaoSecundaria.Text.Replace(".", ","));
            result.R1 = Convert.ToDouble(txtResistenciaP2.Text.Replace(".", ","));

            return result;
        }

        private void btnLimpar2_Click(object sender, EventArgs e)
        {
            txtTensaoSecundaria.Clear();
            txtResistenciaP2.Clear();
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

                case "NXOR":
                    portaNxorControl.Show();
                    portaNxorControl.BringToFront();
                    break;
            };
        }
    }
}
