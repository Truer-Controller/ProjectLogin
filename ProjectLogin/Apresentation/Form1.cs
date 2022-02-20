using ProjectLogin.Apresentation;
using ProjectLogin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSingup_Click(object sender, EventArgs e)
        {
            SingUpUser singUpUserBottom = new SingUpUser();
            singUpUserBottom.Show(); 
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSingin_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            controller.Acess(txbLogin.Text, txbPassword.Text);

            if (controller.mensage.Equals(""))
            {
                if (controller.temp)
                {
                    MessageBox.Show("Login efect sucesseful", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Welcome wc = new Welcome();
                    wc.Show();
                }
                else
                {
                    MessageBox.Show("Cadaster or Login and Password incorrects", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show(controller.mensage);
            }
            
        }

        private void txbLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
