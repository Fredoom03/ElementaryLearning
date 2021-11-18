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
    public partial class NivelBasico : Form
    {

        String DatoPublico;
        public NivelBasico()
        {
            InitializeComponent();  
        }

        public NivelBasico(String usuario)
        {
            InitializeComponent();
            DatoPublico = usuario;
        }

        private void NivelBasico_Load(object sender, EventArgs e)
        {
            pcCorrecto.Visible = false;
            pcIncorrecto.Visible = false;
            pccorrect.Visible = false;
            pcIncorrect.Visible = false;
            lblUser.Text = DatoPublico;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (p1rb4.Checked)
            {
                pcCorrecto.Visible = true;
                pcIncorrecto.Visible = false;
                button1.Enabled = false;
                groupBox1.Enabled = false;
            }
            else 
            {
                pcIncorrecto.Visible = true;
                pcCorrecto.Visible = false;          
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (p2rb1.Checked)
            {
                pccorrect.Visible = true;
                pcIncorrect.Visible = false;
                button2.Enabled = false;
                groupBox2.Enabled = false;
            }
            else 
            {
                //pccorrect.Visible = true;
                pcIncorrect.Visible = true;

            }
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
