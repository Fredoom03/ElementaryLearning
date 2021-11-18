using ElementaryLearning.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transacciones;


namespace ElementaryLearning
{
    public partial class Login : Form
    {
        public String DatoPublico;
        int intentos = 0;
        public Boolean bEntrar;

        opLogin opLogin = new opLogin();

        public Login()
        {
            InitializeComponent();
            bEntrar = false;
        }

        private void lblCrearCuenta_Click(object sender, EventArgs e)
        {
            pnlRegistrarUsuario.Visible = true;
            pnlLoginTb.Visible = false;
        }

        datosUsuarios datosUsuarios = new datosUsuarios();
        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                datosUsuarios.Nombre = tbNombre.Text;
                datosUsuarios.Edad = tbEdad.Text;
                datosUsuarios.Usuario = tbNuevoUsuario.Text;
                datosUsuarios.Contrasena = tbCrearContraseña.Text;

                if (tbCrearContraseña.Text == tbConfirmarContrasena.Text)
                {
                    opUsuarios opUsuarios = new opUsuarios();
                    opUsuarios.RegistrarUsuario(datosUsuarios);
                    Limpiar();

                    pnlRegistrarUsuario.Visible = false;
                    MessageBox.Show("Se registro el usuario");

                    pnlRegistrarUsuario.Visible = false;
                    pnlLoginTb.Visible = true;
                }
                else
                {
                    MessageBox.Show("Las claves no coniciden");
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la operacion " + ex.ToString());
            }
            
        }

        private void Limpiar()
        {
            tbNombre.Text = "Nombre";
            tbEdad.Text = "Edad";
            tbNuevoUsuario.Text = "Usuario";
            tbCrearContraseña.Text = "Contraseña";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlRegistrarUsuario.Visible = false;
            pnlLoginTb.Visible = true;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int resultado = opLogin.Login(
                DatoPublico=tbUsuario.Text,
                tbPassword.Text);

            if (resultado == 1)
            {
                this.Hide();
                frmMenu menu = new frmMenu(DatoPublico);
                menu.ShowDialog();
                if (bEntrar==true)
                {
                    this.Close();
                }
            }

            else if (resultado == 0)
            {
                MessageBox.Show("Error, Usuario/Contraseña invalidos");
                intentos += 1;
                if (intentos == 3)
                {
                    MessageBox.Show("Adios");
                    this.Close();
                }
                //MessageBox.Show("El Usuario o Contraseña no son correctos");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Limpiar();
        }

        private void btnIniciar_Enter(object sender, EventArgs e)
        {
           
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pnlLoginTb_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbUsuario_Enter(object sender, EventArgs e)
        {
            tbUsuario.Text = "";
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            tbPassword.Text = ""; 
        }
    }
}
