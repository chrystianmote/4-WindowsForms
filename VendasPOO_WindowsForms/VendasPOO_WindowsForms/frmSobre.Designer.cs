namespace VendasPOO_WindowsForms
{
    partial class frmSobre
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
            this.lblSobre = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblDireitos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSobre
            // 
            this.lblSobre.AutoSize = true;
            this.lblSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobre.Location = new System.Drawing.Point(8, 22);
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(344, 25);
            this.lblSobre.TabIndex = 0;
            this.lblSobre.Text = "SCV - Sistema de Cadastro e Vendas";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(147, 127);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(54, 57);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(263, 13);
            this.lblTexto.TabIndex = 2;
            this.lblTexto.Text = "Sistema para cadastro de clientes, produtos e vendas.";
            // 
            // lblDireitos
            // 
            this.lblDireitos.AutoSize = true;
            this.lblDireitos.Location = new System.Drawing.Point(89, 80);
            this.lblDireitos.Name = "lblDireitos";
            this.lblDireitos.Size = new System.Drawing.Size(184, 13);
            this.lblDireitos.TabIndex = 3;
            this.lblDireitos.Text = "2012 © Todos os direitos reservados.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Trabalho realizado por: Saulo e Chrystian";
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 162);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDireitos);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblSobre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSobre";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre o SCV";
            this.Load += new System.EventHandler(this.frmSobre_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSobre_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSobre;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblDireitos;
        private System.Windows.Forms.Label label1;
    }
}