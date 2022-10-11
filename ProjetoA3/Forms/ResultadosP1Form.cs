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

        }
    }
}
