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
    public partial class Nivel3Matematicas : Form
    {
        #region Variables
        String DatoPublico;
        Boolean flag = false;
        Boolean flag2 = false;
        Boolean flag3 = false;
        int puntuacionFinal = 0;
        int puntuacionParcial = 5;

        #endregion

        public Nivel3Matematicas()
        {
            InitializeComponent();
        }

        public Nivel3Matematicas(String usuario)
        {
            InitializeComponent();
            DatoPublico = usuario;
        }

        private void gunaAdvenceButton18_Click(object sender, EventArgs e)
        {
            panelAyuda.Visible = true;
            panelAyuda2.Visible = true;
            panelAyuda3.Visible = true;
            btnAyuda.Enabled = false;
        }

        private void Nivel3Matematicas_Load(object sender, EventArgs e)
        {
            lblUser.Text = DatoPublico;
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            panelAyuda.Visible = false;
            panelAyuda2.Visible = false;
            panelAyuda3.Visible = false;
            btnAyuda.Enabled = true;
        }

        #region NIVEL 1

        #region Operacion 1
        private void btnMultiplicacion1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                MessageBox.Show("Ya seleccionaste una operacion, porfavor selecciona la respuesta");
            }
            else
            {
                btnMultiplicacion1.Enabled = false;
                flag = true;
                lblOperacion.Text = btnMultiplicacion1.Text + " = ?";
            }
        }

        private void btnRespuesta1_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                MessageBox.Show("Primero debes seleccionar una operacion!");
            }
            else
            {
                if (!btnMultiplicacion1.Enabled)
                {
                    MessageBox.Show("CORRECTO!");
                    btnRespuesta1.Enabled = false;
                    flag = false;
                    lblOperacion.Text = "Sin seleccionar";
                    comprobarLvl2();
                    
                }
                else
                {
                    MessageBox.Show("Deberias pensar mejor tu respuesta!");
                    puntuacionParcial = -1;
                }
            }
        }

        #endregion

        #region Operacion 2
        private void btnMultiplicacion2_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                MessageBox.Show("Ya seleccionaste una operacion, porfavor selecciona la respuesta");
            }
            else
            {
                btnMultiplicacion2.Enabled = false;
                flag = true;
                lblOperacion.Text = btnMultiplicacion2.Text + " = ?";
            }
        }

        private void btnRespuesta2_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                MessageBox.Show("Primero debes seleccionar una operacion!");
            }
            else
            {
                if (!btnMultiplicacion2.Enabled)
                {
                    MessageBox.Show("CORRECTO!");
                    btnRespuesta2.Enabled = false;
                    flag = false;
                    lblOperacion.Text = "Sin seleccionar";
                    comprobarLvl2();
                }
                else
                {
                    if (puntuacionParcial <= 0)
                    {
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        puntuacionParcial = 5;
                        comprobarLvl2();
                    }
                    else
                    {
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        puntuacionParcial -= 1;
                    }
                }
            }
        }

        #endregion

        #region Operacion 3
        private void btnMultiplicacion3_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                MessageBox.Show("Ya seleccionaste una operacion, porfavor selecciona la respuesta");
            }
            else
            {
                btnMultiplicacion3.Enabled = false;
                flag = true;
                lblOperacion.Text = btnMultiplicacion3.Text + " = ?";
            }
        }

        private void btnRespuesta3_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                MessageBox.Show("Primero debes seleccionar una operacion!");
            }
            else
            {
                if (!btnMultiplicacion3.Enabled)
                {
                    MessageBox.Show("CORRECTO!");
                    btnRespuesta3.Enabled = false;
                    flag = false;
                    lblOperacion.Text = "Sin seleccionar";
                    comprobarLvl2();
                }
                else
                {
                    if (puntuacionParcial <= 0)
                    {
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        puntuacionParcial = 5;
                        comprobarLvl2();
                    }
                    else
                    {
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        puntuacionParcial -= 1;
                    }
                }
            }
        }

        #endregion

        #region Operacion 4
        private void btnMultiplicacion4_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                MessageBox.Show("Ya seleccionaste una operacion, porfavor selecciona la respuesta");
            }
            else
            {
                btnMultiplicacion4.Enabled = false;
                flag = true;
                lblOperacion.Text = btnMultiplicacion4.Text + " = ?";
            }
        }

        private void btnRespuesta4_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                MessageBox.Show("Primero debes seleccionar una operacion!");
            }
            else
            {
                if (!btnMultiplicacion4.Enabled)
                {
                    MessageBox.Show("CORRECTO!");
                    btnRespuesta4.Enabled = false;
                    flag = false;
                    lblOperacion.Text = "Sin seleccionar";
                    comprobarLvl2();
                }
                else
                {
                    if (puntuacionParcial <= 0)
                    {
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        puntuacionParcial = 5;
                        comprobarLvl2();
                    }
                    else
                    {
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        puntuacionParcial -= 1;
                    }
                }
            }
        }


        #endregion

        #region Operacion 5
        private void btnMultiplicacion5_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                MessageBox.Show("Ya seleccionaste una operacion, porfavor selecciona la respuesta");
            }
            else
            {
                btnMultiplicacion5.Enabled = false;
                flag = true;
                lblOperacion.Text = btnMultiplicacion5.Text + " = ?";
            }
        }

        private void btnRespuesta5_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                MessageBox.Show("Primero debes seleccionar una operacion!");
            }
            else
            {
                if (!btnMultiplicacion5.Enabled)
                {
                    MessageBox.Show("CORRECTO!");
                    btnRespuesta5.Enabled = false;
                    flag = false;
                    lblOperacion.Text = "Sin seleccionar";
                    comprobarLvl2();
                }
                else
                {
                    if (puntuacionParcial <= 0)
                    {
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        puntuacionParcial = 5;
                        comprobarLvl2();
                    }
                    else
                    {
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        puntuacionParcial -= 1;
                    }
                }
            }
        }

        #endregion

        #region Operacion 6
        private void btnMultiplicacion6_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                MessageBox.Show("Ya seleccionaste una operacion, porfavor selecciona la respuesta");
            }
            else
            {
                btnMultiplicacion6.Enabled = false;
                flag = true;
                lblOperacion.Text = btnMultiplicacion6.Text + " = ?";
            }
        }

        private void btnRespuesta6_Click_1(object sender, EventArgs e)
        {
            if (!flag)
            {
                MessageBox.Show("Primero debes seleccionar una operacion!");
            }
            else
            {
                if (!btnMultiplicacion6.Enabled)
                {
                    MessageBox.Show("CORRECTO!");
                    btnRespuesta6.Enabled = false;
                    flag = false;
                    lblOperacion.Text = "Sin seleccionar";
                    comprobarLvl2();
                }
                else
                {
                    if (puntuacionParcial <= 0)
                    {
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        puntuacionParcial = 5;
                        comprobarLvl2();
                    }
                    else
                    {
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        puntuacionParcial -= 1;
                    }
                }
            }
        }

        #endregion

        #region Operacion 7
        private void btnMultiplicacion7_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                MessageBox.Show("Ya seleccionaste una operacion, porfavor selecciona la respuesta");
            }
            else
            {
                btnMultiplicacion7.Enabled = false;
                flag = true;
                lblOperacion.Text = btnMultiplicacion7.Text + " = ?";
            }
        }

        private void btnRespuesta7_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                MessageBox.Show("Primero debes seleccionar una operacion!");
            }
            else
            {
                if (!btnMultiplicacion7.Enabled)
                {
                    MessageBox.Show("CORRECTO!");
                    btnRespuesta7.Enabled = false;
                    flag = false;
                    comprobarLvl2();
                }
                else
                {
                    if (puntuacionParcial <= 0)
                    {
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        puntuacionParcial = 5;
                        comprobarLvl2();
                    }
                    else
                    {
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        puntuacionParcial -= 1;
                    }
                }
            }
        }

        #endregion

        #region Operacion 8
        private void btnMultiplicacion8_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                MessageBox.Show("Ya seleccionaste una operacion, porfavor selecciona la respuesta");
            }
            else
            {
                btnMultiplicacion8.Enabled = false;
                flag = true;
                lblOperacion.Text = btnMultiplicacion8.Text + " = ?";
            }
        }

        private void btnRespuesta8_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                MessageBox.Show("Primero debes seleccionar una operacion!");
            }
            else
            {
                if (!btnMultiplicacion8.Enabled)
                {
                    MessageBox.Show("CORRECTO!");
                    btnRespuesta5.Enabled = false;
                    flag = false;
                    lblOperacion.Text = "Sin seleccionar";

                    comprobarLvl2();

                    pnlLvl2.Visible = false;

                    pnlLvl3.Location = new Point(60, 75);
                }
                else
                {
                    if (puntuacionParcial <= 0)
                    {
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        puntuacionParcial = 5;
                        comprobarLvl2();
                    }
                    else
                    {
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        puntuacionParcial -= 1;
                    }
                }
            }
        }












        #endregion

        #endregion

        #region NIVEL 2

        #region Operacion 1
        private void btnSuma1_Click(object sender, EventArgs e)
        {
            if (flag2)
            {
                MessageBox.Show("Ya seleccionaste una operacion, porfavor selecciona la respuesta");
            }
            else
            {
                btnSuma1.Enabled = false;
                flag2 = true;
                lblOperacion2.Text = btnSuma1.Text + " = ?";
            }
        }

        private void btnRespuestaSuma1_Click(object sender, EventArgs e)
        {
            if (!flag2)
            {
                MessageBox.Show("Primero debes seleccionar una operacion!");
            }
            else
            {
                if (!btnSuma1.Enabled)
                {
                    MessageBox.Show("CORRECTO!");
                    btnRespuestaSuma1.Enabled = false;
                    flag2 = false;
                    lblOperacion2.Text = "Sin seleccionar";
                    puntuacionFinal += puntuacionParcial;
                    puntuacionParcial = 5;
                    lblPuntos.Text = "Puntos: " + puntuacionFinal;
                }
                else
                {
                    if (puntuacionParcial <= 0)
                    {
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        puntuacionParcial = 5;
                        comprobarLvl1();
                    }
                    else
                    {
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        puntuacionParcial -= 1;
                    }
                }
            }
        }
        #endregion

        #region Operacion 2
        private void btnSuma2_Click(object sender, EventArgs e)
        {
            if (flag2)
            {
                MessageBox.Show("Ya seleccionaste una operacion, porfavor selecciona la respuesta");
            }
            else
            {
                btnSuma2.Enabled = false;
                flag2 = true;
                lblOperacion2.Text = btnSuma2.Text + " = ?";
            }
        }

        private void btnRespuestaSuma2_Click(object sender, EventArgs e)
        {
            if (!flag2)
            {
                MessageBox.Show("Primero debes seleccionar una operacion!");
            }
            else
            {
                if (!btnSuma2.Enabled)
                {
                    MessageBox.Show("CORRECTO!");
                    btnRespuestaSuma2.Enabled = false;
                    flag2 = false;
                    lblOperacion2.Text = "Sin seleccionar";
                    puntuacionFinal += puntuacionParcial;
                    puntuacionParcial = 5;
                    lblPuntos.Text = "Puntos: " + puntuacionFinal;
                }
                else
                {
                    if (puntuacionParcial <= 0)
                    {
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        puntuacionParcial = 5;
                        comprobarLvl1();
                    }
                    else
                    {
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        puntuacionParcial -= 1;
                    }
                }
            }
        }
        #endregion

        #region Operacion 3
        private void btnSuma3_Click(object sender, EventArgs e)
        {
            if (flag2)
            {
                MessageBox.Show("Ya seleccionaste una operacion, porfavor selecciona la respuesta");
            }
            else
            {
                btnSuma3.Enabled = false;
                flag2 = true;
                lblOperacion2.Text = btnSuma3.Text + " = ?";
            }
        }

        private void btnRespuestaSuma3_Click(object sender, EventArgs e)
        {
            if (!flag2)
            {
                MessageBox.Show("Primero debes seleccionar una operacion!");
            }
            else
            {
                if (!btnSuma3.Enabled)
                {
                    MessageBox.Show("CORRECTO!");
                    btnRespuestaSuma3.Enabled = false;
                    flag2 = false;
                    lblOperacion2.Text = "Sin seleccionar";
                    puntuacionFinal += puntuacionParcial;
                    puntuacionParcial = 5;
                    lblPuntos.Text = "Puntos: " + puntuacionFinal;
                }
                else
                {
                    if (puntuacionParcial <= 0)
                    {
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        puntuacionParcial = 5;
                        comprobarLvl1();
                    }
                    else
                    {
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        puntuacionParcial -= 1;
                    }
                }
            }
        }
        #endregion

        #region Operacion 4
        private void btnSuma4_Click(object sender, EventArgs e)
        {
            if (flag2)
            {
                MessageBox.Show("Ya seleccionaste una operacion, porfavor selecciona la respuesta");
            }
            else
            {
                btnSuma4.Enabled = false;
                flag2 = true;
                lblOperacion2.Text = btnSuma4.Text + " = ?";
            }
        }

        private void btnRespuestaSuma4_Click(object sender, EventArgs e)
        {
            if (!flag2)
            {
                MessageBox.Show("Primero debes seleccionar una operacion!");
            }
            else
            {
                if (!btnSuma4.Enabled)
                {
                    MessageBox.Show("CORRECTO!");
                    btnRespuestaSuma4.Enabled = false;
                    flag2 = false;
                    lblOperacion2.Text = "Sin seleccionar";
                    puntuacionFinal += puntuacionParcial;
                    puntuacionParcial = 5;
                    lblPuntos.Text = "Puntos: " + puntuacionFinal;
                }
                else
                {
                    if (puntuacionParcial <= 0)
                    {
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        puntuacionParcial = 5;
                        comprobarLvl1();
                    }
                    else
                    {
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        puntuacionParcial -= 1;
                    }

                }
            }
        }
        #endregion

        #region Operacion 5
        private void btnSuma5_Click(object sender, EventArgs e)
        {
            if (flag2)
            {
                MessageBox.Show("Ya seleccionaste una operacion, porfavor selecciona la respuesta");
            }
            else
            {
                btnSuma5.Enabled = false;
                flag2 = true;
                lblOperacion2.Text = btnSuma5.Text + " = ?";
            }
        }

        private void btnRespuestaSuma5_Click(object sender, EventArgs e)
        {
            if (!flag2)
            {
                MessageBox.Show("Primero debes seleccionar una operacion!");
            }
            else
            {
                if (!btnSuma5.Enabled)
                {
                    MessageBox.Show("CORRECTO!");
                    btnRespuestaSuma5.Enabled = false;
                    flag2 = false;
                    lblOperacion2.Text = "Sin seleccionar";
                    puntuacionFinal += puntuacionParcial;
                    puntuacionParcial = 5;
                    lblPuntos.Text = "Puntos: " + puntuacionFinal;
                }
                else
                {
                    if (puntuacionParcial <= 0)
                    {
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        puntuacionParcial = 5;
                        comprobarLvl1();
                    }
                    else
                    {
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        puntuacionParcial -= 1;
                    }
                }
            }
        }
        #endregion

        #region Operacion 6
        private void btnSuma6_Click(object sender, EventArgs e)
        {
            if (flag2)
            {
                MessageBox.Show("Ya seleccionaste una operacion, porfavor selecciona la respuesta");
            }
            else
            {
                btnSuma6.Enabled = false;
                flag2 = true;
                lblOperacion2.Text = btnSuma6.Text + " = ?";
            }
        }

        private void btnRespuestaSuma6_Click(object sender, EventArgs e)
        {
            if (!flag2)
            {
                MessageBox.Show("Primero debes seleccionar una operacion!");
            }
            else
            {
                if (!btnSuma6.Enabled)
                {
                    MessageBox.Show("CORRECTO!");
                    btnRespuestaSuma6.Enabled = false;
                    flag2 = false;
                    lblOperacion2.Text = "Sin seleccionar";
                    puntuacionFinal += puntuacionParcial;
                    puntuacionParcial = 5;
                    lblPuntos.Text = "Puntos: " + puntuacionFinal;
                }
                else
                {
                    if (puntuacionParcial <= 0)
                    {
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        puntuacionParcial = 5;
                        comprobarLvl1();
                    }
                    else
                    {
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        puntuacionParcial -= 1;
                    }
                }
            }
        }
        #endregion

        #region Operacion 7
        private void btnSuma7_Click(object sender, EventArgs e)
        {
            if (flag2)
            {
                MessageBox.Show("Ya seleccionaste una operacion, porfavor selecciona la respuesta");
            }
            else
            {
                btnSuma7.Enabled = false;
                flag2 = true;
                lblOperacion2.Text = btnSuma7.Text + " = ?";
            }
        }

        private void btnRespuestaSuma7_Click(object sender, EventArgs e)
        {
            if (!flag2)
            {
                MessageBox.Show("Primero debes seleccionar una operacion!");
            }
            else
            {
                if (!btnSuma7.Enabled)
                {
                    MessageBox.Show("CORRECTO!");
                    btnRespuestaSuma7.Enabled = false;
                    flag2 = false;
                    lblOperacion2.Text = "Sin seleccionar";
                    puntuacionFinal += puntuacionParcial;
                    puntuacionParcial = 5;
                    lblPuntos.Text = "Puntos: " + puntuacionFinal;
                }
                else
                {
                    if (puntuacionParcial <= 0)
                    {
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        puntuacionParcial = 5;
                        comprobarLvl1();
                    }
                    else
                    {
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        puntuacionParcial -= 1;
                    }
                }
            }
        }
        #endregion

        #region Operacion 8
        private void btnSuma8_Click(object sender, EventArgs e)
        {
            if (flag2)
            {
                MessageBox.Show("Ya seleccionaste una operacion, porfavor selecciona la respuesta");
            }
            else
            {
                btnSuma8.Enabled = false;
                flag2 = true;
                lblOperacion2.Text = btnSuma8.Text + " = ?";
            }
        }

        private void btnRespuestaSuma8_Click(object sender, EventArgs e)
        {
            if (!flag2)
            {
                MessageBox.Show("Primero debes seleccionar una operacion!");
            }
            else
            {
                if (!btnSuma8.Enabled)
                {
                    MessageBox.Show("CORRECTO!");
                    btnRespuestaSuma8.Enabled = false;
                    flag2 = false;
                    lblOperacion2.Text = "Sin seleccionar";
                    pnlLvl1.Visible = false;
                    pnlLvl2.Location = new Point(60, 75);
                    comprobarLvl1();

                }
                else
                {
                    if (puntuacionParcial <= 0)
                    {
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        puntuacionParcial = 5;
                        comprobarLvl1();
                    }
                    else
                    {
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        puntuacionParcial -= 1;
                    }
                }
            }
        }
        #endregion

        #endregion

        #region NIVEL 3

            #region Operacion 1
        private void btnOp1_Click(object sender, EventArgs e)
        {
            if (flag3)
            {
                MessageBox.Show("Ya seleccionaste una operacion, porfavor selecciona la respuesta");
            }
            else
            {
                btnOp1.Enabled = false;
                flag3 = true;
                lblOperacion3.Text = btnOp1.Text + " = ?";
            }
        }

        private void gunaAdvenceButton20_Click(object sender, EventArgs e)
        {
            if (!flag3)
            {
                MessageBox.Show("Primero debes seleccionar una operacion!");
            }
            else
            {
                if (!btnOp1.Enabled)
                {
                    MessageBox.Show("CORRECTO!");
                    gunaAdvenceButton20.Enabled = false;
                    flag3 = false;
                    lblOperacion3.Text = "Sin seleccionar";
                    comprobarLvl3();

                }
                else
                {
                    if (puntuacionParcial <= 0)
                    {
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        puntuacionParcial = 5;
                        comprobarLvl3();
                    }
                    else
                    {
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        puntuacionParcial -= 1;
                    }
                }
            }
        }
            #endregion

            #region Operacion 2
            private void btnOp2_Click(object sender, EventArgs e)
            {
                if (flag3)
                {
                    MessageBox.Show("Ya seleccionaste una operacion, porfavor selecciona la respuesta");
                }
                else
                {
                    btnOp2.Enabled = false;
                    flag3 = true;
                    lblOperacion3.Text = btnOp2.Text + " = ?";
                }
            }

            private void gunaAdvenceButton14_Click(object sender, EventArgs e)
            {
                if (!flag3)
                {
                    MessageBox.Show("Primero debes seleccionar una operacion!");
                }
                else
                {
                    if (!btnOp2.Enabled)
                    {
                        MessageBox.Show("CORRECTO!");
                        gunaAdvenceButton14.Enabled = false;
                        flag3 = false;
                        lblOperacion3.Text = "Sin seleccionar";
                        comprobarLvl3();

                    }
                    else
                    {
                    if (puntuacionParcial <= 0)
                    {
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        puntuacionParcial = 5;
                        comprobarLvl3();
                    }
                    else
                    {
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        puntuacionParcial -= 1;
                    }
                }
                }
            }
            #endregion

            #region Operacion 3
            private void btnOp3_Click(object sender, EventArgs e)
            {
                if (flag3)
                {
                    MessageBox.Show("Ya seleccionaste una operacion, porfavor selecciona la respuesta");
                }
                else
                {
                    btnOp3.Enabled = false;
                    flag3 = true;
                    lblOperacion3.Text = btnOp3.Text + " = ?";
                }
            }

            private void gunaAdvenceButton17_Click(object sender, EventArgs e)
            {
                if (!flag3)
                {
                    MessageBox.Show("Primero debes seleccionar una operacion!");
                }
                else
                {
                    if (!btnOp3.Enabled)
                    {
                        MessageBox.Show("CORRECTO!");
                        gunaAdvenceButton17.Enabled = false;
                        flag3 = false;
                        lblOperacion3.Text = "Sin seleccionar";
                        comprobarLvl3();

                    }
                    else
                    {
                    if (puntuacionParcial <= 0)
                    {
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        puntuacionParcial = 5;
                        comprobarLvl3();
                    }
                    else
                    {
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        puntuacionParcial -= 1;
                    }
                }
                }
            }
            #endregion

            #region Operacion 4
            private void btnOp4_Click(object sender, EventArgs e)
            {
                if (flag3)
                {
                    MessageBox.Show("Ya seleccionaste una operacion, porfavor selecciona la respuesta");
                }
                else
                {
                    btnOp4.Enabled = false;
                    flag3 = true;
                    lblOperacion3.Text = btnOp4.Text + " = ?";
                }
            }

            private void gunaAdvenceButton16_Click(object sender, EventArgs e)
            {
                if (!flag3)
                {
                    MessageBox.Show("Primero debes seleccionar una operacion!");
                }
                else
                {
                    if (!btnOp4.Enabled)
                    {
                        MessageBox.Show("CORRECTO!");
                        gunaAdvenceButton16.Enabled = false;
                        flag3 = false;
                        lblOperacion3.Text = "Sin seleccionar";
                        comprobarLvl3();


                    }
                else
                    {
                    if (puntuacionParcial <= 0)
                    {
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        puntuacionParcial = 5;
                        comprobarLvl3();
                    }
                    else
                    {
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        puntuacionParcial -= 1;
                    }
                }
                }
            }
            #endregion

            #region Operacion 5
            private void btnOp5_Click(object sender, EventArgs e)
            {
                if (flag3)
                {
                    MessageBox.Show("Ya seleccionaste una operacion, porfavor selecciona la respuesta");
                }
                else
                {
                    btnOp5.Enabled = false;
                    flag3 = true;
                    lblOperacion3.Text = btnOp5.Text + " = ?";
                }
            }

            private void gunaAdvenceButton18_Click_1(object sender, EventArgs e)
            {
                if (!flag3)
                {
                    MessageBox.Show("Primero debes seleccionar una operacion!");
                }
                else
                {
                    if (!btnOp5.Enabled)
                    {
                        MessageBox.Show("CORRECTO!");
                        gunaAdvenceButton18.Enabled = false;
                        flag3 = false;
                        lblOperacion3.Text = "Sin seleccionar";
                        comprobarLvl3();

                    }
                else
                    {
                    if (puntuacionParcial <= 0)
                    {
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        puntuacionParcial = 5;
                        comprobarLvl3();
                    }
                    else
                    {
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        puntuacionParcial -= 1;
                    }
                }
                }
            }
            #endregion

            #region Operacion 6
            private void btnOp6_Click(object sender, EventArgs e)
            {
                if (flag3)
                {
                    MessageBox.Show("Ya seleccionaste una operacion, porfavor selecciona la respuesta");
                }
                else
                {
                    btnOp6.Enabled = false;
                    flag3 = true;
                    lblOperacion3.Text = btnOp6.Text + " = ?";
                }
            }

            private void gunaAdvenceButton15_Click(object sender, EventArgs e)
            {
                if (!flag3)
                {
                    MessageBox.Show("Primero debes seleccionar una operacion!");
                }
                else
                {
                    if (!btnOp6.Enabled)
                    {
                        MessageBox.Show("CORRECTO!");
                        gunaAdvenceButton15.Enabled = false;
                        flag3 = false;
                        lblOperacion3.Text = "Sin seleccionar";
                        comprobarLvl3();

                    }
                else
                    {
                    if (puntuacionParcial <= 0)
                    {
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        puntuacionParcial = 5;
                        comprobarLvl3();
                    }
                    else
                    {
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        puntuacionParcial -= 1;
                    }
                }
                }
            }
            #endregion

            #region Operacion 7
            private void btnOp7_Click(object sender, EventArgs e)
            {
                if (flag3)
                {
                    MessageBox.Show("Ya seleccionaste una operacion, porfavor selecciona la respuesta");
                }
                else
                {
                    btnOp7.Enabled = false;
                    flag3 = true;
                    lblOperacion3.Text = btnOp7.Text + " = ?";
                }
            }

            private void gunaAdvenceButton19_Click(object sender, EventArgs e)
            {
                if (!flag3)
                {
                    MessageBox.Show("Primero debes seleccionar una operacion!");
                }
                else
                {
                    if (!btnOp7.Enabled)
                    {
                        MessageBox.Show("CORRECTO!");
                        gunaAdvenceButton19.Enabled = false;
                        flag3 = false;
                        lblOperacion3.Text = "Sin seleccionar";
                        comprobarLvl3();

                    }
                else
                    {
                    if (puntuacionParcial <= 0)
                    {
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        puntuacionParcial = 5;
                        comprobarLvl3();
                    }
                    else
                    {
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        puntuacionParcial -= 1;
                    }
                }
                }
            }
            #endregion

            #region Operacion 8
            private void btnOp8_Click(object sender, EventArgs e)
            {
                if (flag3)
                {
                    MessageBox.Show("Ya seleccionaste una operacion, porfavor selecciona la respuesta");
                }
                else
                {
                    btnOp8.Enabled = false;
                    flag3 = true;
                    lblOperacion3.Text = btnOp8.Text + " = ?";
                }
            }

            private void gunaAdvenceButton21_Click(object sender, EventArgs e)
            {
                if (!flag3)
                {
                    MessageBox.Show("Primero debes seleccionar una operacion!");
                }
                else
                {
                    if (!btnOp8.Enabled)
                    {
                        MessageBox.Show("CORRECTO!");
                        gunaAdvenceButton21.Enabled = false;
                        flag3 = false;
                        lblOperacion3.Text = "Sin seleccionar";

                        comprobarLvl3();

                        MessageBox.Show("Muy bien!\nHaz terminado el nivel medio con " + puntuacionFinal + " puntos, seras redirigido al menu de seleccion de dificultades");

                        NivelesLM menu = new NivelesLM(DatoPublico, puntuacionFinal);
                        this.Close();
                        menu.Show();
                    }
                    else
                    {
                    if (puntuacionParcial <= 0)
                    {
                        MessageBox.Show("Lo siento, se te acabaron los intentos :(");
                        puntuacionParcial = 5;
                        comprobarLvl3();
                    }
                    else
                    {
                        MessageBox.Show("Deberias pensar mejor tu respuesta!");
                        puntuacionParcial -= 1;
                    }
                }
                }
            }
        #endregion

        #endregion

        #region EXTRAS
        private void btnCorrecto_Click(object sender, EventArgs e)
        {
            panelCorrecto.Visible = false;
        }

        private void btnIncorrecto_Click(object sender, EventArgs e)
        {
            panelIncorrecto.Visible = false;
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            NivelesLM menu = new NivelesLM(DatoPublico);
            this.Close();
            menu.Show();
        }
        #endregion

        private void comprobarLvl1()
        {
            flag2 = false;
            puntuacionFinal += puntuacionParcial;
            puntuacionParcial = 5;
            lblPuntos.Text = "Puntos: " + puntuacionFinal;
            lblOperacion2.Text = "Sin seleccionar";

            if (!btnSuma1.Enabled)
            {
                btnRespuestaSuma1.Enabled = false;               
            }
            else if (!btnSuma2.Enabled)
            {
                btnRespuestaSuma2.Enabled = false;
            }
            else if (!btnSuma3.Enabled)
            {
                btnRespuestaSuma3.Enabled = false;
            }
            else if (!btnSuma4.Enabled)
            {
                btnRespuestaSuma4.Enabled = false;
            }
            else if (!btnSuma5.Enabled)
            {
                btnRespuestaSuma5.Enabled = false;
            }
            else if (!btnSuma6.Enabled)
            {
                btnRespuestaSuma6.Enabled = false;
            }
            else if (!btnSuma7.Enabled)
            {
                btnRespuestaSuma7.Enabled = false;
            }
            else if (!btnSuma8.Enabled)
            {
                btnRespuestaSuma8.Enabled = false;
            }
            puntuacionParcial = 5;
        }

        private void comprobarLvl2()
        {
            flag = false;
            puntuacionFinal += puntuacionParcial;
            puntuacionParcial = 5;
            lblPuntos.Text = "Puntos: " + puntuacionFinal;
            lblOperacion.Text = "Sin seleccionar";

            if (!btnMultiplicacion1.Enabled)
            {
                btnRespuesta1.Enabled = false;
            }
            else if (!btnMultiplicacion2.Enabled)
            {
                btnRespuesta2.Enabled = false;
            }
            else if (!btnMultiplicacion3.Enabled)
            {
                btnRespuesta3.Enabled = false;
            }
            else if (!btnMultiplicacion4.Enabled)
            {
                btnRespuesta4.Enabled = false;
            }
            else if (!btnMultiplicacion5.Enabled)
            {
                btnRespuesta5.Enabled = false;
            }
            else if (!btnMultiplicacion6.Enabled)
            {
                btnRespuesta6.Enabled = false;
            }
            else if (!btnMultiplicacion7.Enabled)
            {
                btnRespuesta7.Enabled = false;
            }
            else if (!btnMultiplicacion8.Enabled)
            {
                btnRespuesta8.Enabled = false;
            }
            puntuacionParcial = 5;
        }

        private void comprobarLvl3()
        {
            puntuacionFinal += puntuacionParcial;
            puntuacionParcial = 5;
            lblPuntos.Text = "Puntos: " + puntuacionFinal;
            flag3 = false;
            lblOperacion3.Text = "Sin seleccionar";

            if (!btnOp1.Enabled)
            {
                gunaAdvenceButton20.Enabled = false;
            }
            else if (!btnOp2.Enabled)
            {
                gunaAdvenceButton14.Enabled = false;
            }
            else if (!btnOp3.Enabled)
            {
                gunaAdvenceButton17.Enabled = false;
            }
            else if (!btnOp4.Enabled)
            {
                gunaAdvenceButton16.Enabled = false;
            }
            else if (!btnOp5.Enabled)
            {
                gunaAdvenceButton18.Enabled = false;
            }
            else if (!btnOp6.Enabled)
            {
                gunaAdvenceButton15.Enabled = false;
            }
            else if (!btnOp7.Enabled)
            {
                gunaAdvenceButton19.Enabled = false;
            }
            else if (!btnOp8.Enabled)
            {
                gunaAdvenceButton21.Enabled = false;
            }
            puntuacionParcial = 5;
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
    }
}
