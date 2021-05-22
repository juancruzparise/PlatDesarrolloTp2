using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var usuriod = new AgenciaManager().autenticarUsuario(Convert.ToInt32(textuser.Text), textpassword.Text);

            if (usuriod != null)
            {
                if (usuriod.getEsAdmin())
                {
                    FormAdministrators frm = new FormAdministrators();

                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
                else
                {   
                    FormUsers frm = new FormUsers();

                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }

            }
            else
                MessageBox.Show("Login erroneo.");
        }
    }
}
