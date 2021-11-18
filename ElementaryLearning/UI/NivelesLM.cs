using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElementaryLearning.UI
{
    public partial class NivelesLM : Form
    {
        String DatoPublico;
        int puntuacion = 0;
        public NivelesLM()
        {
            InitializeComponent();
        }

        public NivelesLM(String usuario)
        {
            InitializeComponent();
            DatoPublico = usuario;
        }
        public NivelesLM(String usuario, int puntos)
        {
            InitializeComponent();
            DatoPublico = usuario;
            puntuacion = puntos;
        }

        private void btnFacil_Click(object sender, EventArgs e)
        {
            
            //NivelBasico basico = new NivelBasico(DatoPublico);
            //this.Hide();
            //basico.ShowDialog();

            this.Hide();
            Nivel1Matematicas n1 = new Nivel1Matematicas(DatoPublico);
            n1.ShowDialog();
        }

        private void NivelesLM_Load(object sender, EventArgs e)
        {
            lblUser.Text = DatoPublico;
            lblPuntos.Text = "Puntos: " + puntuacion;
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nivel3Matematicas n3 = new Nivel3Matematicas(DatoPublico);
            n3.ShowDialog();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nivel2Matematicas n2 = new Nivel2Matematicas(DatoPublico);
            n2.ShowDialog();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            frmMenu menu1 = new frmMenu(DatoPublico);
            this.Close();
            menu1.Show();
        }
    }
}
