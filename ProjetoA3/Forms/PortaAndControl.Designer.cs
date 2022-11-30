namespace ProjetoA3.Forms
{
    partial class PortaAndControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortaAndControl));
            this.pictureLedGrey = new System.Windows.Forms.PictureBox();
            this.pictureLedRed = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEntrada1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelEntrada2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLedGrey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLedRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureLedGrey
            // 
            this.pictureLedGrey.Image = ((System.Drawing.Image)(resources.GetObject("pictureLedGrey.Image")));
            this.pictureLedGrey.Location = new System.Drawing.Point(515, 128);
            this.pictureLedGrey.Name = "pictureLedGrey";
            this.pictureLedGrey.Size = new System.Drawing.Size(64, 62);
            this.pictureLedGrey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureLedGrey.TabIndex = 10;
            this.pictureLedGrey.TabStop = false;
            // 
            // pictureLedRed
            // 
            this.pictureLedRed.Image = ((System.Drawing.Image)(resources.GetObject("pictureLedRed.Image")));
            this.pictureLedRed.Location = new System.Drawing.Point(515, 128);
            this.pictureLedRed.Name = "pictureLedRed";
            this.pictureLedRed.Size = new System.Drawing.Size(64, 62);
            this.pictureLedRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureLedRed.TabIndex = 9;
            this.pictureLedRed.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(334, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "PORTA AND";
            // 
            // labelEntrada1
            // 
            this.labelEntrada1.BackColor = System.Drawing.SystemColors.Window;
            this.labelEntrada1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEntrada1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEntrada1.Location = new System.Drawing.Point(227, 166);
            this.labelEntrada1.Name = "labelEntrada1";
            this.labelEntrada1.Size = new System.Drawing.Size(23, 30);
            this.labelEntrada1.TabIndex = 8;
            this.labelEntrada1.Text = "0";
            this.labelEntrada1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelEntrada1.Click += new System.EventHandler(this.labelEntrada1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(247, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // labelEntrada2
            // 
            this.labelEntrada2.BackColor = System.Drawing.SystemColors.Window;
            this.labelEntrada2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEntrada2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEntrada2.Location = new System.Drawing.Point(227, 197);
            this.labelEntrada2.Name = "labelEntrada2";
            this.labelEntrada2.Size = new System.Drawing.Size(23, 30);
            this.labelEntrada2.TabIndex = 13;
            this.labelEntrada2.Text = "0";
            this.labelEntrada2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelEntrada2.Click += new System.EventHandler(this.labelEntrada2_Click);
            // 
            // PortaAndControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelEntrada2);
            this.Controls.Add(this.pictureLedRed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEntrada1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureLedGrey);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "PortaAndControl";
            this.Size = new System.Drawing.Size(772, 397);
            this.Load += new System.EventHandler(this.PortaAndControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLedGrey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLedRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureLedGrey;
        private PictureBox pictureLedRed;
        private Label label1;
        private Label labelEntrada1;
        private PictureBox pictureBox1;
        private Label labelEntrada2;
    }
}
