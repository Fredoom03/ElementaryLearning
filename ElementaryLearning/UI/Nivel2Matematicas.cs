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
    public partial class Nivel2Matematicas : Form
    {
        String DatoPublico;
        int puntuacionFinal = 0;
        int puntuacionParcial = 5;
        public Nivel2Matematicas()
        {
            InitializeComponent();
        }

        public Nivel2Matematicas(String usuario)
        {
            InitializeComponent();
            DatoPublico = usuario;
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            panelAyuda.Visible = true;
            panelAyuda2.Visible = true;
            panelAyuda3.Visible = true;
            btnAyuda.Enabled = false;
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            panelAyuda.Visible = false;
            panelAyuda2.Visible = false;
            panelAyuda3.Visible = false;
            btnAyuda.Enabled = true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "")
            {
                MessageBox.Show("Porfavor ingresa tu respuesta");
            }
            else
            {

                if (Int32.Parse(tb1.Text) == 15)
                {
                    MessageBox.Show("CORRECTO!");
                    tb1.Enabled = false;
                    btn1.Enabled = false;
                    puntuacionFinal += puntuacionParcial;
                    lblPuntos.Text = "Puntos: " + puntuacionFinal;
                    puntuacionParcial = 5;
                }
                else
                {
                    if (puntuacionParcial == 0)
                    {
                        lbl1.Enabled = false;
                        btn1.Enabled = false;
                        tb1.Enabled = false;
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        tb1.Text = "";
                        puntuacionParcial = 5;
                    }
                    else
                    {
                        puntuacionParcial -= 1;
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        tb1.Text = "";
                    }
                }
            }           
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (tb2.Text == "")
            {
                MessageBox.Show("Porfavor ingresa tu respuesta");
            }
            else
            {

                if (Int32.Parse(tb2.Text) == 6)
                {
                    MessageBox.Show("CORRECTO!");
                    tb2.Enabled = false;
                    btn2.Enabled = false;
                    puntuacionFinal += puntuacionParcial;
                    lblPuntos.Text = "Puntos: " + puntuacionFinal;
                    puntuacionParcial = 5;
                }
                else
                {
                    if (puntuacionParcial == 0)
                    {
                        lbl2.Enabled = false;
                        btn2.Enabled = false;
                        tb2.Enabled = false;
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        tb2.Text = "";
                        puntuacionParcial = 5;
                    }
                    else
                    {
                        puntuacionParcial -= 1;
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        tb2.Text = "";
                    }
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (tb3.Text == "")
            {
                MessageBox.Show("Porfavor ingresa tu respuesta");
            }
            else
            {

                if (Int32.Parse(tb3.Text) == 52)
                {
                    MessageBox.Show("CORRECTO!");
                    tb3.Enabled = false;
                    btn3.Enabled = false;
                    puntuacionFinal += puntuacionParcial;
                    lblPuntos.Text = "Puntos: " + puntuacionFinal;
                    puntuacionParcial = 5;
                }
                else
                {
                    if (puntuacionParcial == 0)
                    {
                        lbl3.Enabled = false;
                        btn3.Enabled = false;
                        tb3.Enabled = false;
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        tb3.Text = "";
                        puntuacionParcial = 5;
                    }
                    else
                    {
                        puntuacionParcial -= 1;
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        tb3.Text = "";
                    }
                }
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (tb4.Text == "")
            {
                MessageBox.Show("Porfavor ingresa tu respuesta");
            }
            else
            {

                if (Int32.Parse(tb4.Text) == 33)
                {
                    MessageBox.Show("CORRECTO!");
                    tb4.Enabled = false;
                    btn4.Enabled = false;
                    puntuacionFinal += puntuacionParcial;
                    lblPuntos.Text = "Puntos: " + puntuacionFinal;
                    puntuacionParcial = 5;
                }
                else
                {
                    if (puntuacionParcial == 0)
                    {
                        lbl4.Enabled = false;
                        btn4.Enabled = false;
                        tb4.Enabled = false;
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        tb4.Text = "";
                        puntuacionParcial = 5;
                    }
                    else
                    {
                        puntuacionParcial -= 1;
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        tb4.Text = "";
                    }
                }
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (tb5.Text == "")
            {
                MessageBox.Show("Porfavor ingresa tu respuesta");
            }
            else
            {

                if (Int32.Parse(tb5.Text) == 28)
                {
                    MessageBox.Show("CORRECTO!");
                    tb5.Enabled = false;
                    btn5.Enabled = false;
                    puntuacionFinal += puntuacionParcial;
                    lblPuntos.Text = "Puntos: " + puntuacionFinal;
                    puntuacionParcial = 5;
                }
                else
                {
                    if (puntuacionParcial == 0)
                    {
                        lbl5.Enabled = false;
                        btn5.Enabled = false;
                        tb5.Enabled = false;
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        tb5.Text = "";
                        puntuacionParcial = 5;
                    }
                    else
                    {
                        puntuacionParcial -= 1;
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        tb5.Text = "";
                    }
                }
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (tb6.Text == "")
            {
                MessageBox.Show("Porfavor ingresa tu respuesta");
            }
            else
            {

                if (Int32.Parse(tb6.Text) == 33)
                {
                    MessageBox.Show("CORRECTO!");
                    tb6.Enabled = false;
                    btn6.Enabled = false;
                    puntuacionFinal += puntuacionParcial;
                    lblPuntos.Text = "Puntos: " + puntuacionFinal;
                    puntuacionParcial = 5;
                }
                else
                {
                    if (puntuacionParcial == 0)
                    {
                        lbl6.Enabled = false;
                        btn6.Enabled = false;
                        tb6.Enabled = false;
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        tb6.Text = "";
                        puntuacionParcial = 5;
                    }
                    else
                    {
                        puntuacionParcial -= 1;
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        tb6.Text = "";
                    }
                }
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (tb7.Text == "")
            {
                MessageBox.Show("Porfavor ingresa tu respuesta");
            }
            else
            {

                if (Int32.Parse(tb7.Text) == 26)
                {
                    MessageBox.Show("CORRECTO!");
                    tb7.Enabled = false;
                    btn7.Enabled = false;
                    puntuacionFinal += puntuacionParcial;
                    lblPuntos.Text = "Puntos: " + puntuacionFinal;
                    puntuacionParcial = 5;

                    pnlLvl1.Visible = false;

                    pnlLvl2.Location = new Point(75, 57);
                }
                else
                {
                    if (puntuacionParcial == 0)
                    {
                        lbl7.Enabled = false;
                        btn7.Enabled = false;
                        tb7.Enabled = false;
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        tb7.Text = "";
                        puntuacionParcial = 5;
                    }
                    else
                    {
                        puntuacionParcial -= 1;
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        tb7.Text = "";
                    }
                }
            }
        }

        private void Nivel2Matematicas_Load(object sender, EventArgs e)
        {
            lblUser.Text = DatoPublico;
        }

        private void tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) 
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tb3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tb4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tb5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tb6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tb7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            NivelesLM menu = new NivelesLM(DatoPublico);
            this.Close();
            menu.Show();
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            if (tb21.Text == "")
            {
                MessageBox.Show("Porfavor ingresa tu respuesta");
            }
            else
            {

                if (Int32.Parse(tb21.Text) == 0)
                {
                    MessageBox.Show("CORRECTO!");
                    tb21.Enabled = false;
                    btn21.Enabled = false;
                    puntuacionFinal += puntuacionParcial;
                    lblPuntos.Text = "Puntos: " + puntuacionFinal;
                    puntuacionParcial = 5;
                }
                else
                {
                    if (puntuacionParcial == 0)
                    {
                        btn21.Enabled = false;
                        tb21.Enabled = false;
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        tb21.Text = "";
                        puntuacionParcial = 5;
                    }
                    else
                    {
                        puntuacionParcial -= 1;
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        tb21.Text = "";
                    }
                }
            }
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            if (tb22.Text == "")
            {
                MessageBox.Show("Porfavor ingresa tu respuesta");
            }
            else
            {

                if (Int32.Parse(tb22.Text) == 6)
                {
                    MessageBox.Show("CORRECTO!");
                    tb22.Enabled = false;
                    btn22.Enabled = false;
                    puntuacionFinal += puntuacionParcial;
                    lblPuntos.Text = "Puntos: " + puntuacionFinal;
                    puntuacionParcial = 5;
                }
                else
                {
                    if (puntuacionParcial == 0)
                    {
                        btn22.Enabled = false;
                        tb22.Enabled = false;
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        tb22.Text = "";
                        puntuacionParcial = 5;
                    }
                    else
                    {
                        puntuacionParcial -= 1;
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        tb22.Text = "";
                    }
                }
            }
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            if (tb23.Text == "")
            {
                MessageBox.Show("Porfavor ingresa tu respuesta");
            }
            else
            {

                if (Int32.Parse(tb23.Text) == 15)
                {
                    MessageBox.Show("CORRECTO!");
                    tb23.Enabled = false;
                    btn23.Enabled = false;
                    puntuacionFinal += puntuacionParcial;
                    lblPuntos.Text = "Puntos: " + puntuacionFinal;
                    puntuacionParcial = 5;
                }
                else
                {
                    if (puntuacionParcial == 0)
                    {
                        btn23.Enabled = false;
                        tb23.Enabled = false;
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        tb23.Text = "";
                        puntuacionParcial = 5;
                    }
                    else
                    {
                        puntuacionParcial -= 1;
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        tb23.Text = "";
                    }
                }
            }
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            if (tb24.Text == "")
            {
                MessageBox.Show("Porfavor ingresa tu respuesta");
            }
            else
            {

                if (Int32.Parse(tb24.Text) == 37)
                {
                    MessageBox.Show("CORRECTO!");
                    tb24.Enabled = false;
                    btn24.Enabled = false;
                    puntuacionFinal += puntuacionParcial;
                    lblPuntos.Text = "Puntos: " + puntuacionFinal;
                    puntuacionParcial = 5;
                }
                else
                {
                    if (puntuacionParcial == 0)
                    {
                        btn24.Enabled = false;
                        tb24.Enabled = false;
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        tb24.Text = "";
                        puntuacionParcial = 5;
                    }
                    else
                    {
                        puntuacionParcial -= 1;
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        tb24.Text = "";
                    }
                }
            }
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            if (tb25.Text == "")
            {
                MessageBox.Show("Porfavor ingresa tu respuesta");
            }
            else
            {

                if (Int32.Parse(tb25.Text) == 5)
                {
                    MessageBox.Show("CORRECTO!");
                    tb25.Enabled = false;
                    btn25.Enabled = false;
                    puntuacionFinal += puntuacionParcial;
                    lblPuntos.Text = "Puntos: " + puntuacionFinal;
                    puntuacionParcial = 5;
                }
                else
                {
                    if (puntuacionParcial == 0)
                    {
                        btn25.Enabled = false;
                        tb25.Enabled = false;
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        tb25.Text = "";
                        puntuacionParcial = 5;
                    }
                    else
                    {
                        puntuacionParcial -= 1;
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        tb25.Text = "";
                    }
                }
            }
        }

        private void btn26_Click(object sender, EventArgs e)
        {
            if (tb26.Text == "")
            {
                MessageBox.Show("Porfavor ingresa tu respuesta");
            }
            else
            {

                if (Int32.Parse(tb26.Text) == 3)
                {
                    MessageBox.Show("CORRECTO!");
                    tb26.Enabled = false;
                    btn26.Enabled = false;
                    puntuacionFinal += puntuacionParcial;
                    lblPuntos.Text = "Puntos: " + puntuacionFinal;
                    puntuacionParcial = 5;
                }
                else
                {
                    if (puntuacionParcial == 0)
                    {
                        btn26.Enabled = false;
                        tb26.Enabled = false;
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        tb26.Text = "";
                        puntuacionParcial = 5;
                    }
                    else
                    {
                        puntuacionParcial -= 1;
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        tb26.Text = "";
                    }
                }
            }
        }

        private void btn27_Click(object sender, EventArgs e)
        {

            if (tb27.Text == "")
            {
                MessageBox.Show("Porfavor ingresa tu respuesta");
            }
            else
            {

                if (Int32.Parse(tb27.Text) == 3)
                {                   
                    MessageBox.Show("ÇORRECTO!");
                    tb27.Enabled = false;
                    btn27.Enabled = false;

                    pnlLvl2.Visible = false;

                    pnlLvl3.Location = new Point(75, 57);

                    puntuacionFinal += puntuacionParcial;
                    lblPuntos.Text = "Puntos: " + puntuacionFinal;
                    puntuacionParcial = 5;
                }
                else
                {
                    if (puntuacionParcial == 0)
                    {
                        btn27.Enabled = false;
                        tb27.Enabled = false;
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        tb27.Text = "";
                        puntuacionParcial = 5;
                    }
                    else
                    {
                        puntuacionParcial -= 1;
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        tb27.Text = "";
                    }
                }
            }
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            panelAyuda.Visible = false;
            panelAyuda2.Visible = false;
            panelAyuda3.Visible = false;
            btnAyuda.Enabled = true;
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            panelAyuda.Visible = false;
            panelAyuda2.Visible = false;
            panelAyuda3.Visible = false;
            btnAyuda.Enabled = true;
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            if (tb31.Text == "")
            {
                MessageBox.Show("Porfavor ingresa tu respuesta");
            }
            else
            {

                if (Int32.Parse(tb31.Text) == 25)
                {
                    MessageBox.Show("CORRECTO!");
                    tb31.Enabled = false;
                    btn31.Enabled = false;
                    puntuacionFinal += puntuacionParcial;
                    lblPuntos.Text = "Puntos: " + puntuacionFinal;
                    puntuacionParcial = 5;
                }
                else
                {
                    if (puntuacionParcial == 0)
                    {
                        btn31.Enabled = false;
                        tb31.Enabled = false;
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        tb31.Text = "";
                        puntuacionParcial = 5;
                    }
                    else
                    {
                        puntuacionParcial -= 1;
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        tb31.Text = "";
                    }
                }
            }
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            if (tb32.Text == "")
            {
                MessageBox.Show("Porfavor ingresa tu respuesta");
            }
            else
            {

                if (Int32.Parse(tb32.Text) == 12)
                {
                    MessageBox.Show("CORRECTO!");
                    tb32.Enabled = false;
                    btn32.Enabled = false;
                    puntuacionFinal += puntuacionParcial;
                    lblPuntos.Text = "Puntos: " + puntuacionFinal;
                    puntuacionParcial = 5;
                }
                else
                {
                    if (puntuacionParcial == 0)
                    {
                        btn32.Enabled = false;
                        tb32.Enabled = false;
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        tb32.Text = "";
                        puntuacionParcial = 5;
                    }
                    else
                    {
                        puntuacionParcial -= 1;
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        tb32.Text = "";
                    }
                }
            }
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            if (tb33.Text == "")
            {
                MessageBox.Show("Porfavor ingresa tu respuesta");
            }
            else
            {

                if (Int32.Parse(tb33.Text) == 49)
                {
                    MessageBox.Show("CORRECTO!");
                    tb33.Enabled = false;
                    btn33.Enabled = false;
                    puntuacionFinal += puntuacionParcial;
                    lblPuntos.Text = "Puntos: " + puntuacionFinal;
                    puntuacionParcial = 5;
                }
                else
                {
                    if (puntuacionParcial == 0)
                    {
                        btn33.Enabled = false;
                        tb33.Enabled = false;
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        tb33.Text = "";
                        puntuacionParcial = 5;
                    }
                    else
                    {
                        puntuacionParcial -= 1;
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        tb33.Text = "";
                    }
                }
            }
        }

        private void btn34_Click(object sender, EventArgs e)
        {
            if (tb34.Text == "")
            {
                MessageBox.Show("Porfavor ingresa tu respuesta");
            }
            else
            {

                if (Int32.Parse(tb34.Text) == 27)
                {
                    MessageBox.Show("CORRECTO!");
                    tb34.Enabled = false;
                    btn34.Enabled = false;
                    puntuacionFinal += puntuacionParcial;
                    lblPuntos.Text = "Puntos: " + puntuacionFinal;
                    puntuacionParcial = 5;
                }
                else
                {
                    if (puntuacionParcial == 0)
                    {
                        btn34.Enabled = false;
                        tb34.Enabled = false;
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        tb34.Text = "";
                        puntuacionParcial = 5;
                    }
                    else
                    {
                        puntuacionParcial -= 1;
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        tb34.Text = "";
                    }
                }
            }
        }

        private void btn35_Click(object sender, EventArgs e)
        {
            if (tb35.Text == "")
            {
                MessageBox.Show("Porfavor ingresa tu respuesta");
            }
            else
            {

                if (Int32.Parse(tb35.Text) == 40)
                {
                    MessageBox.Show("CORRECTO!");
                    tb35.Enabled = false;
                    btn35.Enabled = false;
                    puntuacionFinal += puntuacionParcial;
                    lblPuntos.Text = "Puntos: " + puntuacionFinal;
                    puntuacionParcial = 5;
                }
                else
                {
                    if (puntuacionParcial == 0)
                    {
                        btn35.Enabled = false;
                        tb35.Enabled = false;
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        tb35.Text = "";
                        puntuacionParcial = 5;
                    }
                    else
                    {
                        puntuacionParcial -= 1;
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        tb35.Text = "";
                    }
                }
            }
        }

        private void btn36_Click(object sender, EventArgs e)
        {
            if (tb36.Text == "")
            {
                MessageBox.Show("Porfavor ingresa tu respuesta");
            }
            else
            {

                if (Int32.Parse(tb36.Text) == 28)
                {
                    MessageBox.Show("CORRECTO!");
                    tb36.Enabled = false;
                    btn36.Enabled = false;
                    puntuacionFinal += puntuacionParcial;
                    lblPuntos.Text = "Puntos: " + puntuacionFinal;
                    puntuacionParcial = 5;
                }
                else
                {
                    if (puntuacionParcial == 0)
                    {
                        btn36.Enabled = false;
                        tb36.Enabled = false;
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        tb36.Text = "";
                        puntuacionParcial = 5;
                    }
                    else
                    {
                        puntuacionParcial -= 1;
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        tb36.Text = "";
                    }
                }
            }
        }

        private void btn37_Click(object sender, EventArgs e)
        {          
            if (tb37.Text == "")
            {
                MessageBox.Show("Porfavor ingresa tu respuesta");
            }
            else
            {
                if (Int32.Parse(tb37.Text) == 18)
                {
                    MessageBox.Show("CORRECTO!");
                    tb37.Enabled = false;
                    btn37.Enabled = false;
                    MessageBox.Show("Muy bien!\nHaz terminado el nivel medio con " + puntuacionFinal + " puntos, seras redirigido al menu de seleccion de dificultades");

                    NivelesLM menu = new NivelesLM(DatoPublico, puntuacionFinal);
                    this.Close();
                    menu.Show();              
                }
                else
                {
                    if (puntuacionParcial == 0)
                    {
                        btn37.Enabled = false;
                        tb37.Enabled = false;
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        tb37.Text = "";
                        puntuacionParcial = 5;
                    }
                    else
                    {
                        puntuacionParcial -= 1;
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        tb37.Text = "";
                    }
                }
            }
        }
    }
}
