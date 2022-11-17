namespace ProjetoA3.Forms
{
    partial class PortaNorControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortaNorControl));
            this.label1 = new System.Windows.Forms.Label();
            this.labelEntrada2 = new System.Windows.Forms.Label();
            this.pictureLedGrey = new System.Windows.Forms.PictureBox();
            this.pictureLedRed = new System.Windows.Forms.PictureBox();
            this.labelEntrada1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLedGrey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLedRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(334, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "PORTA NOR";
            // 
            // labelEntrada2
            // 
            this.labelEntrada2.BackColor = System.Drawing.SystemColors.Window;
            this.labelEntrada2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEntrada2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEntrada2.Location = new System.Drawing.Point(210, 176);
            this.labelEntrada2.Name = "labelEntrada2";
            this.labelEntrada2.Size = new System.Drawing.Size(23, 27);
            this.labelEntrada2.TabIndex = 23;
            this.labelEntrada2.Text = "0";
            this.labelEntrada2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelEntrada2.Click += new System.EventHandler(this.labelEntrada2_Click);
            // 
            // pictureLedGrey
            // 
            this.pictureLedGrey.Image = ((System.Drawing.Image)(resources.GetObject("pictureLedGrey.Image")));
            this.pictureLedGrey.Location = new System.Drawing.Point(499, 103);
            this.pictureLedGrey.Name = "pictureLedGrey";
            this.pictureLedGrey.Size = new System.Drawing.Size(64, 62);
            this.pictureLedGrey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureLedGrey.TabIndex = 21;
            this.pictureLedGrey.TabStop = false;
            // 
            // pictureLedRed
            // 
            this.pictureLedRed.Image = ((System.Drawing.Image)(resources.GetObject("pictureLedRed.Image")));
            this.pictureLedRed.Location = new System.Drawing.Point(499, 103);
            this.pictureLedRed.Name = "pictureLedRed";
            this.pictureLedRed.Size = new System.Drawing.Size(64, 62);
            this.pictureLedRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureLedRed.TabIndex = 20;
            this.pictureLedRed.TabStop = false;
            // 
            // labelEntrada1
            // 
            this.labelEntrada1.BackColor = System.Drawing.SystemColors.Window;
            this.labelEntrada1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEntrada1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEntrada1.Location = new System.Drawing.Point(210, 146);
            this.labelEntrada1.Name = "labelEntrada1";
            this.labelEntrada1.Size = new System.Drawing.Size(23, 27);
            this.labelEntrada1.TabIndex = 19;
            this.labelEntrada1.Text = "0";
            this.labelEntrada1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelEntrada1.Click += new System.EventHandler(this.labelEntrada1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(232, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // PortaNorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelEntrada2);
            this.Controls.Add(this.pictureLedGrey);
            this.Controls.Add(this.pictureLedRed);
            this.Controls.Add(this.labelEntrada1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "PortaNorControl";
            this.Size = new System.Drawing.Size(772, 350);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLedGrey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLedRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label labelEntrada2;
        private PictureBox pictureLedGrey;
        private PictureBox pictureLedRed;
        private Label labelEntrada1;
        private PictureBox pictureBox1;
    }
}
