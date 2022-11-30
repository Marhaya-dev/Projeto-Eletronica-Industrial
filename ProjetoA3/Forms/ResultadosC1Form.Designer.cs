namespace ProjetoA3.Forms
{
    partial class ResultadosC1Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgR1 = new System.Windows.Forms.DataGridView();
            this.labelPotenciaGerador = new System.Windows.Forms.Label();
            this.labelPotenciaReceptor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCorrenteTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgR1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(161, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Potência Gerador (W):";
            // 
            // dtgR1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgR1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgR1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtgR1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dtgR1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgR1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgR1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgR1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgR1.Location = new System.Drawing.Point(18, 14);
            this.dtgR1.Name = "dtgR1";
            this.dtgR1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgR1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgR1.RowHeadersWidth = 40;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3);
            this.dtgR1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgR1.RowTemplate.Height = 25;
            this.dtgR1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgR1.ShowEditingIcon = false;
            this.dtgR1.Size = new System.Drawing.Size(345, 182);
            this.dtgR1.TabIndex = 0;
            // 
            // labelPotenciaGerador
            // 
            this.labelPotenciaGerador.BackColor = System.Drawing.SystemColors.Window;
            this.labelPotenciaGerador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPotenciaGerador.Location = new System.Drawing.Point(300, 211);
            this.labelPotenciaGerador.Name = "labelPotenciaGerador";
            this.labelPotenciaGerador.Size = new System.Drawing.Size(63, 26);
            this.labelPotenciaGerador.TabIndex = 3;
            this.labelPotenciaGerador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPotenciaReceptor
            // 
            this.labelPotenciaReceptor.BackColor = System.Drawing.SystemColors.Window;
            this.labelPotenciaReceptor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPotenciaReceptor.Location = new System.Drawing.Point(300, 247);
            this.labelPotenciaReceptor.Name = "labelPotenciaReceptor";
            this.labelPotenciaReceptor.Size = new System.Drawing.Size(63, 26);
            this.labelPotenciaReceptor.TabIndex = 5;
            this.labelPotenciaReceptor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(138, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Potência no Receptor (W):";
            // 
            // labelCorrenteTotal
            // 
            this.labelCorrenteTotal.BackColor = System.Drawing.SystemColors.Window;
            this.labelCorrenteTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCorrenteTotal.Location = new System.Drawing.Point(300, 281);
            this.labelCorrenteTotal.Name = "labelCorrenteTotal";
            this.labelCorrenteTotal.Size = new System.Drawing.Size(63, 26);
            this.labelCorrenteTotal.TabIndex = 7;
            this.labelCorrenteTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(184, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Corrente Total (A):";
            // 
            // ResultadosC1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 323);
            this.Controls.Add(this.labelCorrenteTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelPotenciaReceptor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPotenciaGerador);
            this.Controls.Add(this.dtgR1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultadosC1Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.ResultadosP1Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgR1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private DataGridView dtgR1;
        private Label labelPotenciaGerador;
        private Label labelPotenciaReceptor;
        private Label label3;
        private Label labelCorrenteTotal;
        private Label label5;
    }
}