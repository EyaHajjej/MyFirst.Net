using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyaHajjej
{
    public partial class AjouterLivre : Form
    {
        public AjouterLivre()
        {
            InitializeComponent();
        }
        public string sconstr = @"provider=Microsoft.jet.oleDB.4.0;Data source = GestionBiblio.mdb";
        public void lancerRequete(string requete)
        {
            OleDbConnection ocn = new OleDbConnection();
            OleDbCommand ocm = new OleDbCommand();
            ocn.ConnectionString = sconstr;
            try
            {
                ocn.Open();
                ocm.Connection = ocn;
                ocm.CommandText = requete;
                ocm.ExecuteNonQuery();
                ocn.Close();
                MessageBox.Show("***insertion terminer avec succée***");
            }

            catch (Exception ex)
            {
                MessageBox.Show("exception Générée : " + ex.Message);
            }
        }
        private void text_ISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
          
            string txtinsert;
            txtinsert = "INSERT INTO Livre VALUES (" +
               "'" + text_ISBN.Text + "', " +
               "'" + text_TitreLivre.Text + "', " +
               "'" + text_auteur.Text + "', " +
               "'" + text_Annee_Sortie.Text + "', " +
               "'" + comboBox_Type_Livre.Text + "', " +
               "'" + text_editeur.Text + "')";

            lancerRequete(txtinsert);


        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_3(object sender, EventArgs e)
        {

        }

        private void Editeur_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_Type_Livre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TypeLivre_Click(object sender, EventArgs e)
        {

        }

        private void text_editeur_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_Annee_Sortie_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_auteur_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_TitreLivre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AnneeSortie_Click(object sender, EventArgs e)
        {

        }

        private void Auteur_Click(object sender, EventArgs e)
        {

        }

        private void TitreLivre_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void ISBN_Click(object sender, EventArgs e)
        {

        }
    }
}
