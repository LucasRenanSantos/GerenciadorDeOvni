namespace GerenciadorDeOvni
{
    partial class TelaInicial
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
            this.lblTripulacao = new System.Windows.Forms.Label();
            this.txbTripulantes = new System.Windows.Forms.TextBox();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.txbabiduzidos = new System.Windows.Forms.TextBox();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTripulacao
            // 
            this.lblTripulacao.AutoSize = true;
            this.lblTripulacao.Location = new System.Drawing.Point(36, 138);
            this.lblTripulacao.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTripulacao.Name = "lblTripulacao";
            this.lblTripulacao.Size = new System.Drawing.Size(234, 31);
            this.lblTripulacao.TabIndex = 0;
            this.lblTripulacao.Text = "Max de tripulantes";
            // 
            // txbTripulantes
            // 
            this.txbTripulantes.BackColor = System.Drawing.Color.White;
            this.txbTripulantes.Location = new System.Drawing.Point(305, 135);
            this.txbTripulantes.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txbTripulantes.Name = "txbTripulantes";
            this.txbTripulantes.Size = new System.Drawing.Size(260, 38);
            this.txbTripulantes.TabIndex = 1;
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Location = new System.Drawing.Point(36, 206);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(247, 31);
            this.lblTripulantes.TabIndex = 2;
            this.lblTripulantes.Text = "Max de abduzidpos";
            // 
            // txbabiduzidos
            // 
            this.txbabiduzidos.Location = new System.Drawing.Point(305, 206);
            this.txbabiduzidos.Name = "txbabiduzidos";
            this.txbabiduzidos.Size = new System.Drawing.Size(260, 38);
            this.txbabiduzidos.TabIndex = 3;
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(38, 283);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(232, 31);
            this.lblPlaneta.TabIndex = 4;
            this.lblPlaneta.Text = "Planeta de origem";
            this.lblPlaneta.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(305, 280);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(260, 39);
            this.cmbPlanetas.TabIndex = 5;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(44, 385);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(178, 47);
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(193, 52);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(258, 31);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "ABDUZAIDER 5000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GerenciadorDeOvni.Properties.Resources.nz6ndyhm;
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 498);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.cmbPlanetas);
            this.Controls.Add(this.lblPlaneta);
            this.Controls.Add(this.txbabiduzidos);
            this.Controls.Add(this.lblTripulantes);
            this.Controls.Add(this.txbTripulantes);
            this.Controls.Add(this.lblTripulacao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inicializador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTripulacao;
        private System.Windows.Forms.TextBox txbTripulantes;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.TextBox txbabiduzidos;
        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}