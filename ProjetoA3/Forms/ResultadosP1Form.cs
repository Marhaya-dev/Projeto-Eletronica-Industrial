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
    public partial class ResultadosP1Form : Form
    {
        public ResultadosP1Form()
        {
            InitializeComponent();
        }

        private void ResultadosP1Form_Load(object sender, EventArgs e)
        {
            var dados = JsonUtils.Read();

            LoadDtg();
        }

        private void LoadDtg()
        {
            dtgR1.Columns.Add("resistor", "Resistor");
            dtgR1.Columns.Add("corrente", "Corrente");
            dtgR1.Columns.Add("potencia", "Potência");

            dtgR1.Rows.Add(new object[] { "R1", $"corrente R1", $"Potência R1" });
            dtgR1.Rows.Add(new object[] { "R2", $"corrente R2", $"Potência R2" });
            dtgR1.Rows.Add(new object[] { "R3", $"corrente R3", $"Potência R3" });
            dtgR1.Rows.Add(new object[] { "R4", $"corrente R4", $"Potência R4" });
            dtgR1.Rows.Add(new object[] { "R5", $"corrente R5", $"Potência R5" });
            dtgR1.Rows.Add(new object[] { "R6", $"corrente R6", $"Potência R6" });
        }
    }
}
