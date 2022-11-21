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

            //Tensão de pico no secundário
            var v2Pico = dados.TensaoSecundaria * Math.Sqrt(2);

            //Tensão de pico no capacitor
            var vd = 2 * 0.7;
            var vcPico = v2Pico - vd; 

            var correnteMedia = vcPico / dados.R1;

            //Tensão de Ripple
            var vRipple = vcPico / 10;

            //Tensão média da carga
            var vMin = vcPico - vRipple;
            var vMediaCarga = (vcPico + vMin) / 2;

            resultadosP2.TensaoPicoCapacitor = vcPico;
            resultadosP2.TensaoRipple = vRipple;
            resultadosP2.TensaoMediaCarga = vMediaCarga;

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
