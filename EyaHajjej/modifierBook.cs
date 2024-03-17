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
    public partial class modifierBook : Form
    {
        public string sconstr = @"provider=Microsoft.jet.oleDB.4.0;Data source = GestionBiblio.mdb";
        public modifierBook()
        {
            InitializeComponent();
          
    }
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
                MessageBox.Show("*** Modification terminer avec succée***");
                Close();
                Home frm2 = new Home();
                frm2.Show();
                Hide();
            }

            catch (Exception ex)
            {
                MessageBox.Show("exception Générée : " + ex.Message);
            }
        }
        private void Modifier_Click(object sender, EventArgs e)
        {
            string txtsql = "update Livre set TitreLivre= '" + text_TitreLivre.Text
    + "', Auteur='" + text_auteur.Text
    + "', AnneeSortie='" + text_Annee_Sortie.Text
    + "', TypeLivre='" + comboBox_Type_Livre.Text
    + "', Editeur='" + text_editeur.Text
    + "' where ISBN = " + text_ISBN.Text + "";

            lancerRequete(txtsql);
           
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void text_ISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void modifierBook_Load(object sender, EventArgs e)
        {

        }

        private void text_Annee_Sortie_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
