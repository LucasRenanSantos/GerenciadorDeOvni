using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeOvni
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
         
            InitializeComponent();

            //aDICIONAR PLANETAS NO COMBOBOX
            cmbPlanetas.Items.AddRange(BibliotecaOVNI.OVNI.PlanetasValidos);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            //verificar se o numero de tripulantes esta vazio:
            if (txbTripulantes.Text == "")

            {
                MessageBox.Show("informe o numero de tripulantes da sua nave!",
                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txbabiduzidos.Text == "")
            {
                MessageBox.Show("Informe a capacidaade de do compartimentos de abduzidos!",
                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cmbPlanetas.SelectedIndex == -1)
            {
                MessageBox.Show("selecione seu planeta de origem para proceguir!",
                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             // Variaveis para receber os valores dos txbs

            int maxTripulantes = int.Parse(txbTripulantes.Text);
            int maxAbduzidos = int.Parse(txbabiduzidos.Text);
            string planetaOrigem = cmbPlanetas.Text;

            //instanciar o OVNI
            BibliotecaOVNI.OVNI ovni = new BibliotecaOVNI.OVNI(maxTripulantes, maxAbduzidos, planetaOrigem);

            // Instanciar a janela gerenci9ador para chama-la 
            Gerenciador gerenciador = new Gerenciador(ovni);

            //esomder janela atual
            Hide();

            // abrir a janela Gerenciador
            gerenciador.ShowDialog();

            // Mostrar novamente a janela atuaal apos a anterior ser fechada:
            Show();
        }
    }
}
