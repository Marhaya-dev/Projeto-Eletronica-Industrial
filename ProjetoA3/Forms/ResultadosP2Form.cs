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
    public partial class ResultadosP2Form : Form
    {
        public ResultadosP2Form()
        {
            InitializeComponent();
        }

        private void ResultadosP2Form_Load(object sender, EventArgs e)
        {
            var resultados = Calcular();

            LoadResultados(resultados);
        }        

        private static ResultadosP2 Calcular()
        {
            var dados = JsonUtils.ReadP2();
            var resultadosP2 = new ResultadosP2();

            var v2Pico = dados.TensaoSecundaria * Math.Sqrt(2);
            var vd = 2 * 0.7;
            var vcPico = (v2Pico - 0.7) / 2; //Verificar essa divisão por 2
            var correnteMedia = vcPico / dados.R1;
            var c = 100 * Math.Pow(10, -6);
            var vRippleKelly = correnteMedia / (c * 120);
            var vRipple = vcPico / 10;
            var vMin = vcPico - vRippleKelly;
            var vMediaCarga = (vcPico + vMin) / 2;
            var vMediaCarga2 = vcPico * 0.636;

            resultadosP2.TensaoPicoCapacitor = vcPico;
            resultadosP2.TensaoRipple = vRippleKelly;
            resultadosP2.TensaoMediaCarga = vMediaCarga2;

            return resultadosP2;
        }

        private void LoadResultados(ResultadosP2 resultados)
        {
            labelTensaoPico.Text = resultados.TensaoPicoCapacitor.ToString("N2");
            labelTensaoRipple.Text = resultados.TensaoRipple.ToString("N2");
            labelTensaoMedia.Text = resultados.TensaoMediaCarga.ToString("N2");
        }
    }
}
