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

namespace ProjectLogin.Apresentation
{
    public partial class SingUpUser : Form
    {
        public SingUpUser()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SingUp_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            string mensage = controller.CadasterUsuer(txbLogin.Text, txbPassword.Text, txbConfirmToPassword.Text);
            if (controller.temp)
            {
                MessageBox.Show(mensage, "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controller.mensage);
            }
        }
    }
}
