using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyaHajjej
{
    public partial class Login : Form
    {
        public string sconstr = @"provider=Microsoft.jet.oleDB.4.0;Data source = GestionBiblio.mdb";
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txtsql = "select count (login) from connexion where login='" + text_Login.Text + "' and pwd='" + text_pwd.Text + "'";
            OleDbConnection ocn = new OleDbConnection(sconstr);
            OleDbCommand ocm = new OleDbCommand(txtsql, ocn);
            Int32 ival;

            try
            {
                ocm.Connection.Open();
                ival = Convert.ToInt32(ocm.ExecuteScalar());
                if (ival == 0)
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("verifier l'identifient", "erreur login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    text_Login.Text = "";
                    text_pwd.Text = "";
                    text_Login.Focus();
                    ocm.Connection.Close();
                }
                else
                {
                    ocm.Connection.Close();
                    Home frm2 = new Home();
                    frm2.Show();
                    Hide();
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show("exception Générée : " + ex.Message);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void authentification_Click(object sender, EventArgs e)
        {

        }

        private void text_Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void text_pwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
