﻿namespace ProjetoA3.Forms
{
    partial class PortaNandControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortaNandControl));
            this.label1 = new System.Windows.Forms.Label();
            this.labelEntradaB = new System.Windows.Forms.Label();
            this.pictureLedGrey = new System.Windows.Forms.PictureBox();
            this.pictureLedGreen = new System.Windows.Forms.PictureBox();
            this.labelEntradaA = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLedGrey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLedGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(330, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "PORTA NAND";
            // 
            // labelEntradaB
            // 
            this.labelEntradaB.BackColor = System.Drawing.SystemColors.Window;
            this.labelEntradaB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEntradaB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEntradaB.Location = new System.Drawing.Point(94, 185);
            this.labelEntradaB.Name = "labelEntradaB";
            this.labelEntradaB.Size = new System.Drawing.Size(23, 30);
            this.labelEntradaB.TabIndex = 18;
            this.labelEntradaB.Text = "0";
            this.labelEntradaB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelEntradaB.Click += new System.EventHandler(this.labelEntradaB_Click);
            // 
            // pictureLedGrey
            // 
            this.pictureLedGrey.Image = ((System.Drawing.Image)(resources.GetObject("pictureLedGrey.Image")));
            this.pictureLedGrey.Location = new System.Drawing.Point(421, 121);
            this.pictureLedGrey.Name = "pictureLedGrey";
            this.pictureLedGrey.Size = new System.Drawing.Size(38, 61);
            this.pictureLedGrey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureLedGrey.TabIndex = 16;
            this.pictureLedGrey.TabStop = false;
            // 
            // pictureLedGreen
            // 
            this.pictureLedGreen.Image = ((System.Drawing.Image)(resources.GetObject("pictureLedGreen.Image")));
            this.pictureLedGreen.Location = new System.Drawing.Point(420, 122);
            this.pictureLedGreen.Name = "pictureLedGreen";
            this.pictureLedGreen.Size = new System.Drawing.Size(40, 60);
            this.pictureLedGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureLedGreen.TabIndex = 15;
            this.pictureLedGreen.TabStop = false;
            // 
            // labelEntradaA
            // 
            this.labelEntradaA.BackColor = System.Drawing.SystemColors.Window;
            this.labelEntradaA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEntradaA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEntradaA.Location = new System.Drawing.Point(94, 154);
            this.labelEntradaA.Name = "labelEntradaA";
            this.labelEntradaA.Size = new System.Drawing.Size(23, 30);
            this.labelEntradaA.TabIndex = 14;
            this.labelEntradaA.Text = "0";
            this.labelEntradaA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelEntradaA.Click += new System.EventHandler(this.labelEntradaA_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(109, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(507, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 367);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(608, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 72);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Legenda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Lâmpada ligada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Lâmpada desligada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(10, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "    ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(12)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(10, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "    ";
            // 
            // PortaNandControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelEntradaB);
            this.Controls.Add(this.pictureLedGreen);
            this.Controls.Add(this.labelEntradaA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureLedGrey);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "PortaNandControl";
            this.Size = new System.Drawing.Size(766, 365);
            this.Load += new System.EventHandler(this.PortaNandControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLedGrey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLedGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label labelEntradaB;
        private PictureBox pictureLedGrey;
        private PictureBox pictureLedGreen;
        private Label labelEntradaA;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
    }
}
