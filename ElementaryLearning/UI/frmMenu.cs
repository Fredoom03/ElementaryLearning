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
    public partial class frmMenu : Form
    {
       public String DatoPublico;
        public Boolean bEntrar;
        public frmMenu()
        {
            InitializeComponent();
            
        }
        public frmMenu(String usuario)
        {
            InitializeComponent();
            DatoPublico = usuario;
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Has seleccionado Logíca matemática");
            this.Hide();
            NivelesLM nlm = new NivelesLM(DatoPublico);
            nlm.ShowDialog();
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has seleccionado Logíca de programación");
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblUser.Text = DatoPublico;
            gunaLabel2.Text += " " + DatoPublico;
        }

        private void lblaUser_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Close();
            log.Show();
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
