using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MiniJeu_E5
{
    public partial class Form2 : Form
    {

        MySqlConnection connection = new MySqlConnection("Server=172.18.153.50; Database=jeu_e5; pwd=12-Soleil&; Uid=starnortf; ");

        public Form2()
        {
            InitializeComponent();

            connection.Open();

            // Récupérer les noms de joueurs à partir de la base de données
            List<string> joueurNoms = new List<string>();
            MySqlCommand command = new MySqlCommand("SELECT nom FROM Joueur", connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string nom = reader.GetString("nom");
                joueurNoms.Add(nom);
            }
            reader.Close();

            // Ajouter les noms de joueurs à la ComboBox
            foreach (string nom in joueurNoms)
            {
                comboBox1.Items.Add(nom);
            }

            // Récupérer les noms des armes à partir de la base de données
            List<string> armeNom = new List<string>();
            MySqlCommand arme = new MySqlCommand("SELECT nom FROM Arme", connection);
            MySqlDataReader lire = arme.ExecuteReader();
            while (lire.Read())
            {
                string nom = lire.GetString("nom");
                armeNom.Add(nom);
            }
            lire.Close();

            // Ajouter les noms de joueurs à la ComboBox
            foreach (string nom in armeNom)
            {
                comboBox2.Items.Add(nom);
            }

        }


        private void buttonOuvrirForm2_Click(object sender, EventArgs e)
        {
            
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnOuvrirJeu_Click(object sender, EventArgs e)
        {
            string joueurSelectionnee = comboBox1.SelectedItem.ToString();
            string armeSelectionnee = comboBox2.SelectedItem.ToString();
            

            Form1 form1 = new Form1(armeSelectionnee, joueurSelectionnee);

            form1.Show();
        }
    }
}
