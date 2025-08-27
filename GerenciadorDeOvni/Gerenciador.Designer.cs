namespace GerenciadorDeOvni
{
    partial class Gerenciador
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
            this.glbInformacoes = new System.Windows.Forms.GroupBox();
            this.lblplaneta = new System.Windows.Forms.Label();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btnLigar = new System.Windows.Forms.Button();
            this.lblAbiduzidos = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblTripulacao = new System.Windows.Forms.Label();
            this.grbtripulantes = new System.Windows.Forms.GroupBox();
            this.btnremover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.grbAbduzidos = new System.Windows.Forms.GroupBox();
            this.btndDezabiduzir = new System.Windows.Forms.Button();
            this.btnAbduzir = new System.Windows.Forms.Button();
            this.grbPlaneta = new System.Windows.Forms.GroupBox();
            this.btnMudarplaneta = new System.Windows.Forms.Button();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.btnretornar = new System.Windows.Forms.Button();
            this.pibTerra = new System.Windows.Forms.PictureBox();
            this.glbInformacoes.SuspendLayout();
            this.grbtripulantes.SuspendLayout();
            this.grbAbduzidos.SuspendLayout();
            this.grbPlaneta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibTerra)).BeginInit();
            this.SuspendLayout();
            // 
            // glbInformacoes
            // 
            this.glbInformacoes.Controls.Add(this.lblplaneta);
            this.glbInformacoes.Controls.Add(this.btnDesligar);
            this.glbInformacoes.Controls.Add(this.btnLigar);
            this.glbInformacoes.Controls.Add(this.lblAbiduzidos);
            this.glbInformacoes.Controls.Add(this.lblSituacao);
            this.glbInformacoes.Controls.Add(this.lblTripulacao);
            this.glbInformacoes.Location = new System.Drawing.Point(17, 7);
            this.glbInformacoes.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.glbInformacoes.Name = "glbInformacoes";
            this.glbInformacoes.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.glbInformacoes.Size = new System.Drawing.Size(287, 411);
            this.glbInformacoes.TabIndex = 0;
            this.glbInformacoes.TabStop = false;
            this.glbInformacoes.Text = "Informações";
            // 
            // lblplaneta
            // 
            this.lblplaneta.AutoSize = true;
            this.lblplaneta.Location = new System.Drawing.Point(12, 203);
            this.lblplaneta.Name = "lblplaneta";
            this.lblplaneta.Size = new System.Drawing.Size(175, 31);
            this.lblplaneta.TabIndex = 5;
            this.lblplaneta.Text = "Planeta Atual";
            // 
            // btnDesligar
            // 
            this.btnDesligar.Location = new System.Drawing.Point(0, 346);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(187, 55);
            this.btnDesligar.TabIndex = 1;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // btnLigar
            // 
            this.btnLigar.Location = new System.Drawing.Point(0, 282);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(187, 49);
            this.btnLigar.TabIndex = 4;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // lblAbiduzidos
            // 
            this.lblAbiduzidos.AutoSize = true;
            this.lblAbiduzidos.Location = new System.Drawing.Point(12, 155);
            this.lblAbiduzidos.Name = "lblAbiduzidos";
            this.lblAbiduzidos.Size = new System.Drawing.Size(147, 31);
            this.lblAbiduzidos.TabIndex = 3;
            this.lblAbiduzidos.Text = "Abiduzidos";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(12, 52);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(129, 31);
            this.lblSituacao.TabIndex = 1;
            this.lblSituacao.Text = "Sutuação";
            // 
            // lblTripulacao
            // 
            this.lblTripulacao.AutoSize = true;
            this.lblTripulacao.Location = new System.Drawing.Point(12, 104);
            this.lblTripulacao.Name = "lblTripulacao";
            this.lblTripulacao.Size = new System.Drawing.Size(141, 31);
            this.lblTripulacao.TabIndex = 2;
            this.lblTripulacao.Text = "Tripulação";
            // 
            // grbtripulantes
            // 
            this.grbtripulantes.Controls.Add(this.btnremover);
            this.grbtripulantes.Controls.Add(this.btnAdicionar);
            this.grbtripulantes.Location = new System.Drawing.Point(17, 448);
            this.grbtripulantes.Name = "grbtripulantes";
            this.grbtripulantes.Size = new System.Drawing.Size(287, 191);
            this.grbtripulantes.TabIndex = 1;
            this.grbtripulantes.TabStop = false;
            this.grbtripulantes.Text = "tripulantes ";
            // 
            // btnremover
            // 
            this.btnremover.Location = new System.Drawing.Point(6, 132);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(147, 44);
            this.btnremover.TabIndex = 1;
            this.btnremover.Text = "Remover =]";
            this.btnremover.UseVisualStyleBackColor = true;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(7, 68);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(146, 42);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // grbAbduzidos
            // 
            this.grbAbduzidos.Controls.Add(this.btndDezabiduzir);
            this.grbAbduzidos.Controls.Add(this.btnAbduzir);
            this.grbAbduzidos.Location = new System.Drawing.Point(315, 24);
            this.grbAbduzidos.Name = "grbAbduzidos";
            this.grbAbduzidos.Size = new System.Drawing.Size(287, 191);
            this.grbAbduzidos.TabIndex = 2;
            this.grbAbduzidos.TabStop = false;
            this.grbAbduzidos.Text = "abduzidos";
            // 
            // btndDezabiduzir
            // 
            this.btndDezabiduzir.Location = new System.Drawing.Point(6, 132);
            this.btndDezabiduzir.Name = "btndDezabiduzir";
            this.btndDezabiduzir.Size = new System.Drawing.Size(147, 44);
            this.btndDezabiduzir.TabIndex = 1;
            this.btndDezabiduzir.Text = "Remover =]";
            this.btndDezabiduzir.UseVisualStyleBackColor = true;
            this.btndDezabiduzir.Click += new System.EventHandler(this.btndDezabiduzir_Click);
            // 
            // btnAbduzir
            // 
            this.btnAbduzir.Location = new System.Drawing.Point(7, 68);
            this.btnAbduzir.Name = "btnAbduzir";
            this.btnAbduzir.Size = new System.Drawing.Size(146, 42);
            this.btnAbduzir.TabIndex = 0;
            this.btnAbduzir.Text = "Adicionar ";
            this.btnAbduzir.UseVisualStyleBackColor = true;
            this.btnAbduzir.Click += new System.EventHandler(this.btnAbduzir_Click);
            // 
            // grbPlaneta
            // 
            this.grbPlaneta.Controls.Add(this.btnMudarplaneta);
            this.grbPlaneta.Controls.Add(this.cmbPlanetas);
            this.grbPlaneta.Location = new System.Drawing.Point(310, 238);
            this.grbPlaneta.Name = "grbPlaneta";
            this.grbPlaneta.Size = new System.Drawing.Size(287, 203);
            this.grbPlaneta.TabIndex = 3;
            this.grbPlaneta.TabStop = false;
            this.grbPlaneta.Text = "planeta";
            // 
            // btnMudarplaneta
            // 
            this.btnMudarplaneta.Location = new System.Drawing.Point(32, 133);
            this.btnMudarplaneta.Name = "btnMudarplaneta";
            this.btnMudarplaneta.Size = new System.Drawing.Size(215, 47);
            this.btnMudarplaneta.TabIndex = 1;
            this.btnMudarplaneta.Text = "Mudar Planeta";
            this.btnMudarplaneta.UseVisualStyleBackColor = true;
            this.btnMudarplaneta.Click += new System.EventHandler(this.btnMudarplaneta_Click);
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(11, 51);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(241, 39);
            this.cmbPlanetas.TabIndex = 0;
            // 
            // btnretornar
            // 
            this.btnretornar.Location = new System.Drawing.Point(342, 424);
            this.btnretornar.Name = "btnretornar";
            this.btnretornar.Size = new System.Drawing.Size(215, 48);
            this.btnretornar.TabIndex = 4;
            this.btnretornar.Text = "Retornar";
            this.btnretornar.UseVisualStyleBackColor = true;
            // 
            // pibTerra
            // 
            this.pibTerra.Image = global::GerenciadorDeOvni.Properties.Resources.terra;
            this.pibTerra.Location = new System.Drawing.Point(680, 546);
            this.pibTerra.Name = "pibTerra";
            this.pibTerra.Size = new System.Drawing.Size(131, 103);
            this.pibTerra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibTerra.TabIndex = 5;
            this.pibTerra.TabStop = false;
            // 
            // Gerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 710);
            this.Controls.Add(this.pibTerra);
            this.Controls.Add(this.btnretornar);
            this.Controls.Add(this.grbPlaneta);
            this.Controls.Add(this.grbAbduzidos);
            this.Controls.Add(this.grbtripulantes);
            this.Controls.Add(this.glbInformacoes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "Gerenciador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador";
            this.glbInformacoes.ResumeLayout(false);
            this.glbInformacoes.PerformLayout();
            this.grbtripulantes.ResumeLayout(false);
            this.grbAbduzidos.ResumeLayout(false);
            this.grbPlaneta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibTerra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox glbInformacoes;
        private System.Windows.Forms.Label lblAbiduzidos;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblTripulacao;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.GroupBox grbtripulantes;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox grbAbduzidos;
        private System.Windows.Forms.Button btndDezabiduzir;
        private System.Windows.Forms.Button btnAbduzir;
        private System.Windows.Forms.GroupBox grbPlaneta;
        private System.Windows.Forms.Button btnMudarplaneta;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.Button btnretornar;
        private System.Windows.Forms.Label lblplaneta;
        private System.Windows.Forms.PictureBox pibTerra;
    }
}