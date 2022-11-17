namespace ProjetoA3.Forms
{
    partial class ResultadosP2Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTensaoPico = new System.Windows.Forms.Label();
            this.labelTensaoRipple = new System.Windows.Forms.Label();
            this.labelTensaoMedia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tensão de pico no capacitor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tensão de ripple:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tensão média na carga:";
            // 
            // labelTensaoPico
            // 
            this.labelTensaoPico.BackColor = System.Drawing.SystemColors.Window;
            this.labelTensaoPico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTensaoPico.Location = new System.Drawing.Point(172, 18);
            this.labelTensaoPico.Name = "labelTensaoPico";
            this.labelTensaoPico.Size = new System.Drawing.Size(63, 23);
            this.labelTensaoPico.TabIndex = 1;
            this.labelTensaoPico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTensaoRipple
            // 
            this.labelTensaoRipple.BackColor = System.Drawing.SystemColors.Window;
            this.labelTensaoRipple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTensaoRipple.Location = new System.Drawing.Point(172, 57);
            this.labelTensaoRipple.Name = "labelTensaoRipple";
            this.labelTensaoRipple.Size = new System.Drawing.Size(63, 23);
            this.labelTensaoRipple.TabIndex = 3;
            this.labelTensaoRipple.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTensaoMedia
            // 
            this.labelTensaoMedia.BackColor = System.Drawing.SystemColors.Window;
            this.labelTensaoMedia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTensaoMedia.Location = new System.Drawing.Point(172, 96);
            this.labelTensaoMedia.Name = "labelTensaoMedia";
            this.labelTensaoMedia.Size = new System.Drawing.Size(63, 23);
            this.labelTensaoMedia.TabIndex = 5;
            this.labelTensaoMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ResultadosP2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 137);
            this.Controls.Add(this.labelTensaoMedia);
            this.Controls.Add(this.labelTensaoRipple);
            this.Controls.Add(this.labelTensaoPico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultadosP2Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.ResultadosP2Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelTensaoPico;
        private Label labelTensaoRipple;
        private Label labelTensaoMedia;
    }
}