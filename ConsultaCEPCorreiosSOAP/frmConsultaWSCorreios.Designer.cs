
namespace ConsultaCEPCorreiosSOAP
{
    partial class frmConsultaWSCorreios
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxtEndereco = new System.Windows.Forms.RichTextBox();
            this.lblAguarde = new System.Windows.Forms.Label();
            this.lblAguarde2 = new System.Windows.Forms.Label();
            this.rtxtCliente = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConsulta2 = new System.Windows.Forms.Button();
            this.lblAguarde3 = new System.Windows.Forms.Label();
            this.rtxtPostagem = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConsultar3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdContrato = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCartaoPostagem = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultar.Location = new System.Drawing.Point(226, 49);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(150, 22);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(15, 49);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(150, 20);
            this.txtCEP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o CEP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Consulta CEP Correios SOAP ";
            // 
            // rtxtEndereco
            // 
            this.rtxtEndereco.Location = new System.Drawing.Point(16, 110);
            this.rtxtEndereco.Name = "rtxtEndereco";
            this.rtxtEndereco.ReadOnly = true;
            this.rtxtEndereco.Size = new System.Drawing.Size(360, 83);
            this.rtxtEndereco.TabIndex = 5;
            this.rtxtEndereco.Text = "";
            this.rtxtEndereco.Visible = false;
            // 
            // lblAguarde
            // 
            this.lblAguarde.AutoSize = true;
            this.lblAguarde.Location = new System.Drawing.Point(135, 84);
            this.lblAguarde.Name = "lblAguarde";
            this.lblAguarde.Size = new System.Drawing.Size(130, 13);
            this.lblAguarde.TabIndex = 6;
            this.lblAguarde.Text = "Consulta em andamento...";
            this.lblAguarde.Visible = false;
            // 
            // lblAguarde2
            // 
            this.lblAguarde2.AutoSize = true;
            this.lblAguarde2.Location = new System.Drawing.Point(135, 283);
            this.lblAguarde2.Name = "lblAguarde2";
            this.lblAguarde2.Size = new System.Drawing.Size(130, 13);
            this.lblAguarde2.TabIndex = 12;
            this.lblAguarde2.Text = "Consulta em andamento...";
            this.lblAguarde2.Visible = false;
            // 
            // rtxtCliente
            // 
            this.rtxtCliente.Location = new System.Drawing.Point(16, 300);
            this.rtxtCliente.Name = "rtxtCliente";
            this.rtxtCliente.ReadOnly = true;
            this.rtxtCliente.Size = new System.Drawing.Size(360, 83);
            this.rtxtCliente.TabIndex = 11;
            this.rtxtCliente.Text = "";
            this.rtxtCliente.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(12, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Consulta dados Cliente Correios";
            // 
            // btnConsulta2
            // 
            this.btnConsulta2.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConsulta2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsulta2.Location = new System.Drawing.Point(226, 259);
            this.btnConsulta2.Name = "btnConsulta2";
            this.btnConsulta2.Size = new System.Drawing.Size(150, 22);
            this.btnConsulta2.TabIndex = 7;
            this.btnConsulta2.Text = "Consultar";
            this.btnConsulta2.UseVisualStyleBackColor = false;
            this.btnConsulta2.Click += new System.EventHandler(this.btnConsulta2_Click);
            // 
            // lblAguarde3
            // 
            this.lblAguarde3.AutoSize = true;
            this.lblAguarde3.Location = new System.Drawing.Point(135, 479);
            this.lblAguarde3.Name = "lblAguarde3";
            this.lblAguarde3.Size = new System.Drawing.Size(130, 13);
            this.lblAguarde3.TabIndex = 16;
            this.lblAguarde3.Text = "Consulta em andamento...";
            this.lblAguarde3.Visible = false;
            // 
            // rtxtPostagem
            // 
            this.rtxtPostagem.Location = new System.Drawing.Point(16, 495);
            this.rtxtPostagem.Name = "rtxtPostagem";
            this.rtxtPostagem.ReadOnly = true;
            this.rtxtPostagem.Size = new System.Drawing.Size(360, 83);
            this.rtxtPostagem.TabIndex = 15;
            this.rtxtPostagem.Text = "";
            this.rtxtPostagem.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(12, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Consulta status da postagem";
            // 
            // btnConsultar3
            // 
            this.btnConsultar3.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConsultar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultar3.Location = new System.Drawing.Point(226, 451);
            this.btnConsultar3.Name = "btnConsultar3";
            this.btnConsultar3.Size = new System.Drawing.Size(150, 22);
            this.btnConsultar3.TabIndex = 13;
            this.btnConsultar3.Text = "Consultar";
            this.btnConsultar3.UseVisualStyleBackColor = false;
            this.btnConsultar3.Click += new System.EventHandler(this.btnConsultar3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Digite o id do contrato:";
            // 
            // txtIdContrato
            // 
            this.txtIdContrato.Location = new System.Drawing.Point(15, 259);
            this.txtIdContrato.Name = "txtIdContrato";
            this.txtIdContrato.Size = new System.Drawing.Size(150, 20);
            this.txtIdContrato.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Digite o nº do cartão de postagem:";
            // 
            // txtCartaoPostagem
            // 
            this.txtCartaoPostagem.Location = new System.Drawing.Point(16, 451);
            this.txtCartaoPostagem.Name = "txtCartaoPostagem";
            this.txtCartaoPostagem.Size = new System.Drawing.Size(150, 20);
            this.txtCartaoPostagem.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConsultaCEPCorreiosSOAP.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(475, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // frmConsultaWSCorreios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(587, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCartaoPostagem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdContrato);
            this.Controls.Add(this.lblAguarde3);
            this.Controls.Add(this.rtxtPostagem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnConsultar3);
            this.Controls.Add(this.lblAguarde2);
            this.Controls.Add(this.rtxtCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConsulta2);
            this.Controls.Add(this.lblAguarde);
            this.Controls.Add(this.rtxtEndereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.btnConsultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsultaWSCorreios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PUC Minas - AWS - Exercicio 1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtEndereco;
        private System.Windows.Forms.Label lblAguarde;
        private System.Windows.Forms.Label lblAguarde2;
        private System.Windows.Forms.RichTextBox rtxtCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConsulta2;
        private System.Windows.Forms.Label lblAguarde3;
        private System.Windows.Forms.RichTextBox rtxtPostagem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConsultar3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdContrato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCartaoPostagem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

