namespace ProjetoA3.Forms
{
    partial class PortaNotControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortaNotControl));
            this.labelEntradaNot = new System.Windows.Forms.Label();
            this.pictureLedRed = new System.Windows.Forms.PictureBox();
            this.pictureLedGrey = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLedRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLedGrey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEntradaNot
            // 
            this.labelEntradaNot.BackColor = System.Drawing.SystemColors.Window;
            this.labelEntradaNot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEntradaNot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEntradaNot.Location = new System.Drawing.Point(196, 181);
            this.labelEntradaNot.Name = "labelEntradaNot";
            this.labelEntradaNot.Size = new System.Drawing.Size(23, 30);
            this.labelEntradaNot.TabIndex = 3;
            this.labelEntradaNot.Text = "0";
            this.labelEntradaNot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelEntradaNot.Click += new System.EventHandler(this.labelEntradaNot_Click);
            // 
            // pictureLedRed
            // 
            this.pictureLedRed.Image = ((System.Drawing.Image)(resources.GetObject("pictureLedRed.Image")));
            this.pictureLedRed.Location = new System.Drawing.Point(515, 128);
            this.pictureLedRed.Name = "pictureLedRed";
            this.pictureLedRed.Size = new System.Drawing.Size(64, 62);
            this.pictureLedRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureLedRed.TabIndex = 4;
            this.pictureLedRed.TabStop = false;
            // 
            // pictureLedGrey
            // 
            this.pictureLedGrey.Image = ((System.Drawing.Image)(resources.GetObject("pictureLedGrey.Image")));
            this.pictureLedGrey.Location = new System.Drawing.Point(515, 128);
            this.pictureLedGrey.Name = "pictureLedGrey";
            this.pictureLedGrey.Size = new System.Drawing.Size(64, 62);
            this.pictureLedGrey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureLedGrey.TabIndex = 5;
            this.pictureLedGrey.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(214, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(334, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "PORTA NOT";
            // 
            // PortaNotControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureLedGrey);
            this.Controls.Add(this.labelEntradaNot);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureLedRed);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "PortaNotControl";
            this.Size = new System.Drawing.Size(772, 397);
            this.Load += new System.EventHandler(this.PortaNotControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLedRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLedGrey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelEntradaNot;
        private PictureBox pictureLedRed;
        private PictureBox pictureLedGrey;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
