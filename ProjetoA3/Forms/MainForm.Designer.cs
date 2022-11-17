namespace ProjetoA3.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cBoxReceptor = new System.Windows.Forms.ComboBox();
            this.txtFrequencia = new System.Windows.Forms.TextBox();
            this.txtGerador = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtR6 = new System.Windows.Forms.TextBox();
            this.txtR5 = new System.Windows.Forms.TextBox();
            this.txtR4 = new System.Windows.Forms.TextBox();
            this.txtR3 = new System.Windows.Forms.TextBox();
            this.txtR2 = new System.Windows.Forms.TextBox();
            this.txtR1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTensaoSecundaria = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtResistenciaP2 = new System.Windows.Forms.TextBox();
            this.btnLimpar2 = new System.Windows.Forms.Button();
            this.btnCalcular2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.portaNxorControl = new ProjetoA3.Forms.PortaNxorControl();
            this.portaXorControl = new ProjetoA3.Forms.PortaXorControl();
            this.portaNorControl = new ProjetoA3.Forms.PortaNorControl();
            this.portaOrControl = new ProjetoA3.Forms.PortaOrControl();
            this.portaNandControl = new ProjetoA3.Forms.PortaNandControl();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxPortas = new System.Windows.Forms.ComboBox();
            this.portaNotControl = new ProjetoA3.Forms.PortaNotControl();
            this.portaAndControl = new ProjetoA3.Forms.PortaAndControl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(812, 452);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnLimpar);
            this.tabPage1.Controls.Add(this.btnCalcular);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(804, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Parte 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(251, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 371);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Circuito";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(524, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(702, 388);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(85, 28);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(611, 388);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(85, 28);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cBoxReceptor);
            this.groupBox1.Controls.Add(this.txtFrequencia);
            this.groupBox1.Controls.Add(this.txtGerador);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtR6);
            this.groupBox1.Controls.Add(this.txtR5);
            this.groupBox1.Controls.Add(this.txtR4);
            this.groupBox1.Controls.Add(this.txtR3);
            this.groupBox1.Controls.Add(this.txtR2);
            this.groupBox1.Controls.Add(this.txtR1);
            this.groupBox1.Location = new System.Drawing.Point(16, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 371);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Receptor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Frequência (Hz):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tensão do Gerador (V):";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cBoxReceptor
            // 
            this.cBoxReceptor.AutoCompleteCustomSource.AddRange(new string[] {
            "Ventilador"});
            this.cBoxReceptor.FormattingEnabled = true;
            this.cBoxReceptor.Location = new System.Drawing.Point(74, 23);
            this.cBoxReceptor.Name = "cBoxReceptor";
            this.cBoxReceptor.Size = new System.Drawing.Size(130, 23);
            this.cBoxReceptor.TabIndex = 15;
            // 
            // txtFrequencia
            // 
            this.txtFrequencia.Location = new System.Drawing.Point(141, 102);
            this.txtFrequencia.Name = "txtFrequencia";
            this.txtFrequencia.Size = new System.Drawing.Size(63, 23);
            this.txtFrequencia.TabIndex = 1;
            // 
            // txtGerador
            // 
            this.txtGerador.Location = new System.Drawing.Point(141, 64);
            this.txtGerador.Name = "txtGerador";
            this.txtGerador.Size = new System.Drawing.Size(63, 23);
            this.txtGerador.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "R6 (Ω):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "R5 (Ω):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "R4 (Ω):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "R3 (Ω):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "R2 (Ω):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "R1 (Ω):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtR6
            // 
            this.txtR6.Location = new System.Drawing.Point(141, 333);
            this.txtR6.Name = "txtR6";
            this.txtR6.Size = new System.Drawing.Size(63, 23);
            this.txtR6.TabIndex = 7;
            // 
            // txtR5
            // 
            this.txtR5.Location = new System.Drawing.Point(141, 295);
            this.txtR5.Name = "txtR5";
            this.txtR5.Size = new System.Drawing.Size(63, 23);
            this.txtR5.TabIndex = 6;
            // 
            // txtR4
            // 
            this.txtR4.Location = new System.Drawing.Point(141, 257);
            this.txtR4.Name = "txtR4";
            this.txtR4.Size = new System.Drawing.Size(63, 23);
            this.txtR4.TabIndex = 5;
            // 
            // txtR3
            // 
            this.txtR3.Location = new System.Drawing.Point(141, 219);
            this.txtR3.Name = "txtR3";
            this.txtR3.Size = new System.Drawing.Size(63, 23);
            this.txtR3.TabIndex = 4;
            // 
            // txtR2
            // 
            this.txtR2.Location = new System.Drawing.Point(141, 181);
            this.txtR2.Name = "txtR2";
            this.txtR2.Size = new System.Drawing.Size(63, 23);
            this.txtR2.TabIndex = 3;
            // 
            // txtR1
            // 
            this.txtR1.Location = new System.Drawing.Point(141, 141);
            this.txtR1.Name = "txtR1";
            this.txtR1.Size = new System.Drawing.Size(63, 23);
            this.txtR1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.btnLimpar2);
            this.tabPage2.Controls.Add(this.btnCalcular2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(804, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Parte 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(251, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(536, 371);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Circuito";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTensaoSecundaria);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtResistenciaP2);
            this.groupBox3.Location = new System.Drawing.Point(16, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 121);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados:";
            // 
            // txtTensaoSecundaria
            // 
            this.txtTensaoSecundaria.Location = new System.Drawing.Point(141, 34);
            this.txtTensaoSecundaria.Name = "txtTensaoSecundaria";
            this.txtTensaoSecundaria.Size = new System.Drawing.Size(63, 23);
            this.txtTensaoSecundaria.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Tensão Secundária (V):";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(96, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "R1 (Ω):";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtResistenciaP2
            // 
            this.txtResistenciaP2.Location = new System.Drawing.Point(141, 72);
            this.txtResistenciaP2.Name = "txtResistenciaP2";
            this.txtResistenciaP2.Size = new System.Drawing.Size(63, 23);
            this.txtResistenciaP2.TabIndex = 16;
            // 
            // btnLimpar2
            // 
            this.btnLimpar2.Location = new System.Drawing.Point(702, 388);
            this.btnLimpar2.Name = "btnLimpar2";
            this.btnLimpar2.Size = new System.Drawing.Size(85, 28);
            this.btnLimpar2.TabIndex = 11;
            this.btnLimpar2.Text = "Limpar";
            this.btnLimpar2.UseVisualStyleBackColor = true;
            this.btnLimpar2.Click += new System.EventHandler(this.btnLimpar2_Click);
            // 
            // btnCalcular2
            // 
            this.btnCalcular2.Location = new System.Drawing.Point(611, 388);
            this.btnCalcular2.Name = "btnCalcular2";
            this.btnCalcular2.Size = new System.Drawing.Size(85, 28);
            this.btnCalcular2.TabIndex = 10;
            this.btnCalcular2.Text = "Calcular";
            this.btnCalcular2.UseVisualStyleBackColor = true;
            this.btnCalcular2.Click += new System.EventHandler(this.btnCalcular2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.portaNxorControl);
            this.tabPage3.Controls.Add(this.portaXorControl);
            this.tabPage3.Controls.Add(this.portaNorControl);
            this.tabPage3.Controls.Add(this.portaOrControl);
            this.tabPage3.Controls.Add(this.portaNandControl);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.comboBoxPortas);
            this.tabPage3.Controls.Add(this.portaNotControl);
            this.tabPage3.Controls.Add(this.portaAndControl);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(804, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Simulação de Circuitos Digitais";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // portaNxorControl
            // 
            this.portaNxorControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portaNxorControl.Location = new System.Drawing.Point(15, 57);
            this.portaNxorControl.Name = "portaNxorControl";
            this.portaNxorControl.Size = new System.Drawing.Size(774, 352);
            this.portaNxorControl.TabIndex = 8;
            // 
            // portaXorControl
            // 
            this.portaXorControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portaXorControl.Location = new System.Drawing.Point(15, 57);
            this.portaXorControl.Name = "portaXorControl";
            this.portaXorControl.Size = new System.Drawing.Size(774, 352);
            this.portaXorControl.TabIndex = 7;
            // 
            // portaNorControl
            // 
            this.portaNorControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portaNorControl.Location = new System.Drawing.Point(15, 57);
            this.portaNorControl.Name = "portaNorControl";
            this.portaNorControl.Size = new System.Drawing.Size(774, 352);
            this.portaNorControl.TabIndex = 6;
            // 
            // portaOrControl
            // 
            this.portaOrControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portaOrControl.Location = new System.Drawing.Point(15, 57);
            this.portaOrControl.Name = "portaOrControl";
            this.portaOrControl.Size = new System.Drawing.Size(774, 352);
            this.portaOrControl.TabIndex = 5;
            // 
            // portaNandControl
            // 
            this.portaNandControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portaNandControl.Location = new System.Drawing.Point(15, 57);
            this.portaNandControl.Name = "portaNandControl";
            this.portaNandControl.Size = new System.Drawing.Size(774, 352);
            this.portaNandControl.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Portas Lógicas:";
            // 
            // comboBoxPortas
            // 
            this.comboBoxPortas.FormattingEnabled = true;
            this.comboBoxPortas.Location = new System.Drawing.Point(108, 17);
            this.comboBoxPortas.Name = "comboBoxPortas";
            this.comboBoxPortas.Size = new System.Drawing.Size(69, 23);
            this.comboBoxPortas.TabIndex = 1;
            this.comboBoxPortas.SelectedIndexChanged += new System.EventHandler(this.comboBoxPortas_SelectedIndexChanged);
            // 
            // portaNotControl
            // 
            this.portaNotControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portaNotControl.Location = new System.Drawing.Point(15, 57);
            this.portaNotControl.Name = "portaNotControl";
            this.portaNotControl.Size = new System.Drawing.Size(774, 352);
            this.portaNotControl.TabIndex = 0;
            // 
            // portaAndControl
            // 
            this.portaAndControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portaAndControl.Location = new System.Drawing.Point(15, 57);
            this.portaAndControl.Name = "portaAndControl";
            this.portaAndControl.Size = new System.Drawing.Size(774, 352);
            this.portaAndControl.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(836, 474);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto A3";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private PictureBox pictureBox1;
        private Button btnLimpar;
        private Button btnCalcular;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtR6;
        private TextBox txtR5;
        private TextBox txtR4;
        private TextBox txtR3;
        private TextBox txtR2;
        private TextBox txtR1;
        private TabPage tabPage2;
        private Label label7;
        private Label label8;
        private TextBox txtFrequencia;
        private TextBox txtGerador;
        private Button btnLimpar2;
        private Button btnCalcular2;
        private GroupBox groupBox2;
        private Label label9;
        private ComboBox cBoxReceptor;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private TextBox txtTensaoSecundaria;
        private Label label11;
        private Label label12;
        private TextBox txtResistenciaP2;
        private TabPage tabPage3;
        private PortaNotControl portaNotControl;
        private ComboBox comboBoxPortas;
        private Label label10;
        private PortaAndControl portaAndControl;
        private PortaNandControl portaNandControl;
        private PortaOrControl portaOrControl;
        private PortaNorControl portaNorControl;
        private PortaXorControl portaXorControl;
        private PortaNxorControl portaNxorControl;
    }
}