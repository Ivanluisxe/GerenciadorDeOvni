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
    public partial class Inicializador : Form
    {
        public Inicializador()
        {
            InitializeComponent();
            // Popular o combobox com o array da classe: 
            cmbPlanetas.DataSource = BibliotecaOVNI.OVNI.PlanetasValidos;
        }

        private void lblTripulantes_Click(object sender, EventArgs e)
        {

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            //obter valores da interface: 

           string planetaOrigem = cmbPlanetas.Text;
            int maxTripulantes = (int)txbTripulantes.Value;
            int maxAbduzidos = (int)txbAbduzidos.Value;

            // Criar objeto do tipo ovni: 
            BibliotecaOVNI.OVNI ovni = new BibliotecaOVNI.OVNI(maxTripulantes, maxAbduzidos, planetaOrigem);

            // Mudar de janela: 
            Gerenciador gerenciador = new Gerenciador(ovni);
            gerenciador.ShowDialog();
             


        }
    }
}
