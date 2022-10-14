﻿using ProjetoA3.Domain.Settings;
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
            var resultados = Calcular();

            LoadDtg(resultados);
        }

        private static ResultadosP1 Calcular()
        {
            var dados = JsonUtils.ReadP1();
            var resultadosP1 = new ResultadosP1();

            var paraleloR1 = 1 / (1 / dados.R1);
            var paraleloR6 = 1 / (1 / dados.R6);

            List<double> listaResistores = new()
            {
                paraleloR1,
                paraleloR6,
                dados.R2,
                dados.R3,
                dados.R4,
                dados.R5,
            };

            resultadosP1.CorrenteTotal = dados.TensaoGerador / listaResistores.Sum();

            resultadosP1.CorrenteR1 = dados.TensaoGerador / (paraleloR1 + paraleloR6);
            resultadosP1.CorrenteR6 = dados.TensaoGerador / (paraleloR1 + paraleloR6);

            resultadosP1.CorrenteR2 = resultadosP1.CorrenteTotal;
            resultadosP1.CorrenteR3 = resultadosP1.CorrenteTotal;
            resultadosP1.CorrenteR4 = resultadosP1.CorrenteTotal;
            resultadosP1.CorrenteR5 = resultadosP1.CorrenteTotal;

            resultadosP1.PotenciaR1 = dados.TensaoGerador * resultadosP1.CorrenteR1;
            resultadosP1.PotenciaR2 = dados.TensaoGerador * resultadosP1.CorrenteR2;
            resultadosP1.PotenciaR3 = dados.TensaoGerador * resultadosP1.CorrenteR3;
            resultadosP1.PotenciaR4 = dados.TensaoGerador * resultadosP1.CorrenteR4;
            resultadosP1.PotenciaR5 = dados.TensaoGerador * resultadosP1.CorrenteR5;
            resultadosP1.PotenciaR6 = dados.TensaoGerador * resultadosP1.CorrenteR6;

            return resultadosP1;
        }

        private void LoadDtg(ResultadosP1 resultados)
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

            labelCorrenteTotal.Text = resultados.CorrenteTotal.ToString("N2");
        }
    }
}
