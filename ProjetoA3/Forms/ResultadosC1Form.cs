using ProjetoA3.Domain.Settings;
using ProjetoA3.Domain.Utils;

namespace ProjetoA3.Forms
{
    public partial class ResultadosC1Form : Form
    {
        public ResultadosC1Form()
        {
            InitializeComponent();
        }

        private void ResultadosP1Form_Load(object sender, EventArgs e)
        {
            var resultados = Calcular();

            LoadDtg(resultados);
        }

        private static ResultadosC1 Calcular()
        {
            var dados = JsonUtils.ReadC1();
            var resultadosP1 = new ResultadosC1();

            var multiplicacao = (dados.R1 + dados.R2 + dados.R6 + dados.R5) / dados.R6;
            var corrente3 = (- dados.TensaoGerador + (dados.TensaoReceptor * multiplicacao)) / ( - ((dados.R6 + dados.R3 + dados.R4)*multiplicacao) + dados.R6);
            var corrente1 = (- dados.TensaoGerador - (corrente3 * dados.R6)) / (- dados.R1 - dados.R2 - dados.R6 - dados.R5);
            var corrente2 = corrente1 - corrente3;

            resultadosP1.CorrenteR1 = corrente1;
            resultadosP1.CorrenteR2 = corrente1;
            resultadosP1.CorrenteR3 = corrente3;
            resultadosP1.CorrenteR4 = corrente3;
            resultadosP1.CorrenteR5 = corrente1;
            resultadosP1.CorrenteR6 = corrente2;

            resultadosP1.CorrenteTotal = corrente2;

            resultadosP1.PotenciaR1 = dados.R1 * (Math.Pow(corrente1, 2));
            resultadosP1.PotenciaR2 = dados.R2 * (Math.Pow(corrente1, 2));
            resultadosP1.PotenciaR3 = dados.R3 * (Math.Pow(corrente3, 2));
            resultadosP1.PotenciaR4 = dados.R4 * (Math.Pow(corrente3, 2));
            resultadosP1.PotenciaR5 = dados.R5 * (Math.Pow(corrente1, 2));
            resultadosP1.PotenciaR6 = dados.R6 * (Math.Pow(corrente2, 2));

            resultadosP1.PotenciaGerador = dados.TensaoGerador * corrente1;
            resultadosP1.PotenciaReceptor = dados.TensaoReceptor * Math.Abs(corrente3);

            return resultadosP1;
        }

        private void LoadDtg(ResultadosC1 resultados)
        {
            dtgR1.Columns.Add("resistor", "Resistor");
            dtgR1.Columns.Add("corrente", "Corrente (A)");
            dtgR1.Columns.Add("potencia", "Potência (W)");

            dtgR1.Rows.Add(new object[] { "R1", $"{resultados.CorrenteR1:N2}", $"{resultados.PotenciaR1:N2}" });
            dtgR1.Rows.Add(new object[] { "R2", $"{resultados.CorrenteR2:N2}", $"{resultados.PotenciaR2:N2}" });
            dtgR1.Rows.Add(new object[] { "R3", $"{resultados.CorrenteR3:N2}", $"{resultados.PotenciaR3:N2}" });
            dtgR1.Rows.Add(new object[] { "R4", $"{resultados.CorrenteR4:N2}", $"{resultados.PotenciaR4:N2}" });
            dtgR1.Rows.Add(new object[] { "R5", $"{resultados.CorrenteR5:N2}", $"{resultados.PotenciaR5:N2}" });
            dtgR1.Rows.Add(new object[] { "R6", $"{resultados.CorrenteR6:N2}", $"{resultados.PotenciaR6:N2}" });

            dtgR1.ClearSelection();

            labelPotenciaGerador.Text = resultados.PotenciaGerador.ToString("N2");
            labelPotenciaReceptor.Text = resultados.PotenciaReceptor.ToString("N2");
            labelCorrenteTotal.Text = resultados.CorrenteTotal.ToString("N2");
        }
    }
}
