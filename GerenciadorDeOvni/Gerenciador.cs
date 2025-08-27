using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeOvni
{
    public partial class Gerenciador : Form
    {
        //objetos globaus: 
        BibliotecaOVNI.OVNI ovni;
        
        public Gerenciador(BibliotecaOVNI.OVNI ovni) // Obrigatriamente de ser iniciada passando um OVNI
        {
            InitializeComponent();
            //"copiado" o ovni vindo da outra janela para um objt global:
            this.ovni = ovni;

            // Atualçizar as informações novamente
            AtualizarInformacoes();

            //Popular o combobox com os planetas validos
            cmbPlanetas.Items.AddRange(BibliotecaOVNI.OVNI.PlanetasValidos);
        }

        public void AtualizarInformacoes()
        {
            lblTripulacao.Text = $"trpulantes: {ovni.QtdTripulantes}";
            lblAbiduzidos.Text = $"abduzidos: {ovni.QtdAbduzidos}";
            lblSituacao.Text = $"situação: {(ovni.Situacao ? "Ligado" : "desligado")}";
            lblplaneta.Text = $"planeta arual: {ovni.planetaAtual}";
            cmbPlanetas.Text = ovni.planetaAtual;

            //Atualizar informções
            btnLigar.Enabled = !ovni.Situacao;
            btnDesligar.Enabled = ovni.Situacao;

            // ativardesativar o gbr de aordo com o status da nave
            grbtripulantes.Enabled = ovni.Situacao;
            grbAbduzidos.Enabled = ovni.Situacao;
            grbPlaneta.Enabled = ovni.Situacao;

            pibTerra.Image = ovni.planetaAtual == "Terra" ? Properties.Resources.terra : null; 

        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            if (ovni.Ligar())
            {
                MessageBox.Show("O ovni foi ligado!",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("O ovni ja esta ligado!",
                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // atualizar as informacoes
            AtualizarInformacoes();
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            if (ovni.Desligar())
            {
                MessageBox.Show("O ovni foi deligado!",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("O ovni ja esta desligado!",
                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // atualizar as informacoes
            AtualizarInformacoes();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (ovni.AdicionarTripulante())
            {
                MessageBox.Show("Tripulantes adicionado!",
                    "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("quantidade maxima de tripulantes atigida!",
                    "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarInformacoes();
        }

        private void btnremover_Click(object sender, EventArgs e)
        {

            if (ovni.AdicionarTripulante())
            {
                MessageBox.Show("Tripulantes removido!",
                    "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O tripulante ja foi removido!",
                    "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarInformacoes();
        }

        private void btnAbduzir_Click(object sender, EventArgs e)
        {

            if (ovni.Abduzir())
            {
                MessageBox.Show("animal desconhecido abduido com sucesso!",
                    "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O animal nao pode ser abduzido!",
                    "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarInformacoes();
        }

        private void btndDezabiduzir_Click(object sender, EventArgs e)
        {

            if (ovni.Abduzir())
            {
                MessageBox.Show("O animal foi dezabduzido!",
                    "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O animal já foi dezabduzido!",
                    "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarInformacoes();

        }

        private void btnMudarplaneta_Click(object sender, EventArgs e)
        {
            if (ovni.MudarPlaneta(cmbPlanetas.Text))
            {
                MessageBox.Show("show voce chegou ao planeta!",
                   "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nãon foi possivel mudar de planeta!",
                    "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarInformacoes();
        }
        
    }
}
