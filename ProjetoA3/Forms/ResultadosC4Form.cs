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
    public partial class ResultadosC4Form : Form
    {
        public ResultadosC4Form()
        {
            InitializeComponent();
        }

        private void ResultadosC4Form_Load(object sender, EventArgs e)
        {
            var resultados = Calcular();

            LoadResultados(resultados);
        }

        private static ResultadosCRetificadores Calcular()
        {
            var dados = JsonUtils.Read("DadosC4");
            var resultadosC3 = new ResultadosCRetificadores();

            //Tensão de pico no secundário
            var tensaoEficaz = dados.TensaoPrimaria * dados.N2 / dados.N1;
            var v2Pico = tensaoEficaz * Math.Sqrt(2);

            //Tensão de pico no capacitor
            var vcPico = v2Pico - 1.4; //2x o diodo

            //Tensão de Ripple
            var f = 120; // 2x a frequência
            var c = dados.Capacitor * Math.Pow(10, -6);
            var i = vcPico / dados.R1;
            var vRipple = i / (f * c);

            //Tensão média da carga
            var vMin = vcPico - vRipple;
            var vMediaCarga = (vcPico + vMin) / 2;

            resultadosC3.TensaoPicoCapacitor = vcPico;
            resultadosC3.TensaoRipple = vRipple;
            resultadosC3.TensaoMediaCarga = vMediaCarga;

            return resultadosC3;
        }

        private void LoadResultados(ResultadosCRetificadores resultados)
        {
            labelTensaoPico.Text = resultados.TensaoPicoCapacitor.ToString("N2") + " V";
            labelTensaoRipple.Text = resultados.TensaoRipple.ToString("N2") + " V";
            labelTensaoMedia.Text = resultados.TensaoMediaCarga.ToString("N2") + " V";
        }
    }
}
