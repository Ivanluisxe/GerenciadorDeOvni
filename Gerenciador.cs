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
        //OVNI "global"
        BibliotecaOVNI.OVNI ovni;
        

        //Construtor:
        public Gerenciador(BibliotecaOVNI.OVNI ovni)
        {
            InitializeComponent();
            //atribuir o ovni local para o global:
            this.ovni = ovni;
            
            //Popular o combobox
            cmbPlaneta.DataSource = BibliotecaOVNI.OVNI.PlanetasValidos;
            AtualizarInterface();


        }

        private void AtualizarInterface()
        {
            //Exibir ou Ocultar os groupBoxes:

            grbTripulacao.Visible = ovni.Situacao;
            grbPlaneta.Visible = ovni.Situacao;
            grbEstatisticas.Visible = ovni.Situacao;
            grbAbduzidos.Visible = ovni.Situacao;
            //Exibir ou Ocultar o botão desligar e ligar: 
            btnDesligar.Visible = ovni.Situacao;
            btnLigar.Visible = !ovni.Situacao;

            //Atualizar o planeta do combobox
            cmbPlaneta.Text = ovni.PlanetaAtual;

            //Atualizar as estatisticas 
            lblTripulantes.Text = "Tripulantes: " + ovni.QtdTripulantes;
            lblPlaneta.Text = "Planeta Atual: " + ovni.PlanetaAtual;
            lblAbduzidos.Text = "Abduzidos: " + ovni.QtdAbduzidos;


            
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            ovni.Ligar();
            AtualizarInterface();

        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            ovni.Desligar();
            AtualizarInterface();
        }

        private void btnAddAbduzido_Click(object sender, EventArgs e)
        {
            if (ovni.Abduzir() == false)
            {
                MessageBox.Show("Numero máximo de vacas atingido! Devolva algumas antes.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblVaca.Text = "CHEIO";
                lblVaca.ForeColor = Color.Red;
            }
            AtualizarInterface();
        }

        private void btnRemoverAbduzido_Click(object sender, EventArgs e)
        {
            if (!ovni.Desabduzir())
            {
                MessageBox.Show("Não temos mais vacas para devolver! ", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblVaca.Text = "";
            }
            lblVaca.Text = "";
            AtualizarInterface();
        }

        private void btnRemoverTripulante_Click(object sender, EventArgs e)
        {
            if(!ovni.RemoverTripulante())
            {
                MessageBox.Show("Só restou o piloto, não pode removê-lo!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblCheio.Text = "";
                
            }
            lblCheio.Text = "";
            AtualizarInterface();

        }

        private void btnAddTripulante_Click(object sender, EventArgs e)
        {
            if(ovni.AdicionarTripulante() == false)
            {
                MessageBox.Show("Numero máximo de tripulantes atingido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblCheio.Text = "CHEIO";
                lblCheio.ForeColor = Color.Red;
            }
            AtualizarInterface();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if(ovni.RetornarAoPlanetaDeOrigem() == false)
            {
                MessageBox.Show("Já estamos em casa!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AtualizarInterface();
        }

        private void cmbPlaneta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ovni.MudarPlaneta(cmbPlaneta.Text) == false)
            {
                MessageBox.Show("Já estamos no planeta que você quer ir!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AtualizarInterface();
        }
    }
}
