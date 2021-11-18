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
    public partial class Nivel1Matematicas : Form
    {
        String DatoPublico;
        int puntuacionFinal = 0;
        int puntuacionParcial = 3;
        public Nivel1Matematicas()
        {
            InitializeComponent();
        }

        public Nivel1Matematicas(String usuario)
        {
            InitializeComponent();
            DatoPublico = usuario;
            pnlIntroduccion.Location = new Point(64, 65);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            panelAyuda.Visible = true;
            panelAyudaIntroduccion.Visible = true;
            panelAyuda1.Visible = true;
            panelAyuda2.Visible = true;
            gunaElipsePanel2.Visible = true;
            btnAyuda.Enabled = false;
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            panelAyuda.Visible = false;
            panelAyudaIntroduccion.Visible = false;
            panelAyuda1.Visible = false;
            panelAyuda2.Visible = false;
            gunaElipsePanel2.Visible = false;
            btnAyuda.Enabled = true;
        }

        private void Nivel1Matematicas_Load(object sender, EventArgs e)
        {
            lblUser.Text = DatoPublico;
        }

        private void mayor1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CORRECTO!");
            mayor1.Enabled = false;
            igual1.Enabled = false;
            menor1.Enabled = false;
            puntuacionFinal += puntuacionParcial;
            lblPuntos.Text = "Puntos: " + puntuacionFinal;
        }

        private void igual2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CORRECTO!");
            mayor2.Enabled = false;
            igual2.Enabled = false;
            menor2.Enabled = false;
            puntuacionFinal += puntuacionParcial;
            lblPuntos.Text = "Puntos: " + puntuacionFinal;
        }

        private void menor3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CORRECTO!");
            mayor3.Enabled = false;
            igual3.Enabled = false;
            menor3.Enabled = false;


            puntuacionFinal += puntuacionParcial;
            lblPuntos.Text = "Puntos: " + puntuacionFinal;
            puntuacionParcial = 3;

            pnlLvl2.Visible = false;

            pnlLvl3.Location = new Point(64, 65);
            
        }

        private void igual1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deberias pensar mejor tu respuesta!");
            igual1.Enabled = false;
            puntuacionParcial -= 1;
        }

        private void menor1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deberias pensar mejor tu respuesta!");
            menor1.Enabled = false;
            puntuacionParcial -= 1;
        }

        private void mayor2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deberias pensar mejor tu respuesta!");
            mayor2.Enabled = false;
            puntuacionParcial -= 1;
        }

        private void menor2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deberias pensar mejor tu respuesta!");
            menor2.Enabled = false;
            puntuacionParcial -= 1;
        }

        private void mayor3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deberias pensar mejor tu respuesta!");
            mayor3.Enabled = false;
            puntuacionParcial -= 1;
        }

        private void igual3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deberias pensar mejor tu respuesta!");
            igual3.Enabled = false;
            puntuacionParcial -= 1;
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            NivelesLM menu = new NivelesLM(DatoPublico);
            this.Close();
            menu.Show();

        }

        private void mayor0_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CORRECTO!");
            mayor0.Enabled = false;
            igual0.Enabled = false;
            menor0.Enabled = false;
            puntuacionFinal += puntuacionParcial;
            lblPuntos.Text = "Puntos: " + puntuacionFinal;
            puntuacionParcial = 3;
        }

        private void igual0_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deberias pensar mejor tu respuesta!");
            igual0.Enabled = false;
            puntuacionParcial -= 1;
        }

        private void menor0_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deberias pensar mejor tu respuesta!");
            menor0.Enabled = false;
            puntuacionParcial -= 1;
        }

        private void mayor01_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deberias pensar mejor tu respuesta!");
            mayor0.Enabled = false;
            puntuacionParcial -= 1;
        }

        private void igual01_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CORRECTO!");
            mayor01.Enabled = false;
            igual01.Enabled = false;
            menor01.Enabled = false;


            pnlLvl1.Visible = false;

            pnlLvl2.Location = new Point(64, 65);

            puntuacionFinal += puntuacionParcial;

            lblPuntos.Text = "Puntos: " + puntuacionFinal;

            puntuacionParcial = 3;
        }

        private void menor01_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deberias pensar mejor tu respuesta!");
            menor0.Enabled = false;
            puntuacionParcial -= 1;
        }

        private void igual03_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CORRECTO!");
            mayor03.Enabled = false;
            igual03.Enabled = false;
            menor03.Enabled = false;

            puntuacionFinal += puntuacionParcial;
            lblPuntos.Text = "Puntos: " + puntuacionFinal;
            puntuacionParcial = 3;
        }

        private void menor003_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CORRECTO!");
            mayor003.Enabled = false;
            igual003.Enabled = false;
            menor003.Enabled = false;

            puntuacionFinal += puntuacionParcial;
            lblPuntos.Text = "Puntos: " + puntuacionFinal;
            puntuacionParcial = 3;
        }

        private void menor0003_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CORRECTO!");
            mayor0003.Enabled = false;
            igual0003.Enabled = false;
            menor0003.Enabled = false;

            puntuacionFinal += puntuacionParcial;
            lblPuntos.Text = "Puntos: " + puntuacionFinal;
            puntuacionParcial = 3;
        }

        private void igual00003_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CORRECTO!");
            mayor00003.Enabled = false;
            igual00003.Enabled = false;
            menor00003.Enabled = false;

            puntuacionFinal += puntuacionParcial;
            lblPuntos.Text = "Puntos: " + puntuacionFinal;
            puntuacionParcial = 3;

            MessageBox.Show("Muy bien!\nHaz terminado el nivel facil con " + puntuacionFinal + " puntos, seras redirigido al menu de seleccion de dificultades");

            NivelesLM menu = new NivelesLM(DatoPublico, puntuacionFinal);
            this.Close();
            menu.Show();
        }

        private void mayor003_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deberias pensar mejor tu respuesta!");
            mayor003.Enabled = false;
            puntuacionParcial -= 1;
        }

        private void igual003_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deberias pensar mejor tu respuesta!");
            igual003.Enabled = false;
            puntuacionParcial -= 1;
        }

        private void mayor0003_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deberias pensar mejor tu respuesta!");
            mayor0003.Enabled = false;
            puntuacionParcial -= 1;
        }

        private void igual0003_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deberias pensar mejor tu respuesta!");
            igual0003.Enabled = false;
            puntuacionParcial -= 1;
        }

        private void mayor00003_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deberias pensar mejor tu respuesta!");
            mayor00003.Enabled = false;
            puntuacionParcial -= 1;

        }

        private void menor00003_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deberias pensar mejor tu respuesta!");
            menor00003.Enabled = false;
            puntuacionParcial -= 1;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (p1rb4.Checked)
            {
                pcCorrecto.Visible = true;
                pcIncorrecto.Visible = false;
                btn1.Enabled = false;
                groupBox1.Enabled = false;
            }
            else
            {
                pcIncorrecto.Visible = true;
                pcCorrecto.Visible = false;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (p2rb1.Checked)
            {
                pccorrect.Visible = true;
                pcIncorrect.Visible = false;
                btn2.Enabled = false;
                groupBox2.Enabled = false;
                pnlIntroduccion.Visible = false;

                MessageBox.Show("Haz terminado el pequeño examen diganostico, \nlos niveles a continuacion si tendran valor\nasí que piensa bien tu respuesta!");

                pnlLvl1.Visible = true;
            }
            else
            {
                pccorrect.Visible = false;
                pcIncorrect.Visible = true;

            }
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            panelAyuda.Visible = false;
            panelAyudaIntroduccion.Visible = false;
            panelAyuda1.Visible = false;
            panelAyuda2.Visible = false;
            gunaElipsePanel2.Visible = false;
            btnAyuda.Enabled = true;
        }

        private void btnIntroduccion_Click(object sender, EventArgs e)
        {
            panelAyuda.Visible = false;
            panelAyudaIntroduccion.Visible = false;
            panelAyuda1.Visible = false;
            panelAyuda2.Visible = false;
            gunaElipsePanel2.Visible = false;
            btnAyuda.Enabled = true;
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            panelAyuda.Visible = false;
            panelAyudaIntroduccion.Visible = false;
            panelAyuda1.Visible = false;
            panelAyuda2.Visible = false;
            gunaElipsePanel2.Visible = false;
            btnAyuda.Enabled = true;
        }

        private void menor03_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deberias pensar mejor tu respuesta!");
            menor0.Enabled = false;
            puntuacionParcial -= 1;
        }

        private void mayor03_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deberias pensar mejor tu respuesta!");
            mayor0.Enabled = false;
            puntuacionParcial -= 1;
        }
    }
}
