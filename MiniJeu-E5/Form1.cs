using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MiniJeu_E5
{
    

    public partial class Form1 : Form
    {
        Joueur joueur;
        Monstre monstre;

        int compteur;
        int len;
        string txt;

        int vieMaxM;
        int vieMaxJ;

        MySqlConnection connection = new MySqlConnection("Server=172.18.153.50; Database=jeu_e5; pwd=12-Soleil&; Uid=starnortf; ");

        public string ArmeSelectionnee { get; set; }
        public string JoueurSelectionnee { get; set; }



        public Form1(string armeSelectionnee, string joueurSelectionnee)
        {
            InitializeComponent();

            ArmeSelectionnee = armeSelectionnee;
            JoueurSelectionnee = joueurSelectionnee;

            connection.Open();

            // Sélection d'un joueur dans la base de données
            
            MySqlCommand command = new MySqlCommand("SELECT * FROM Joueur where nom = " + "'" + JoueurSelectionnee + "'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string nomJoueur = reader.GetString("nom");
            int pvJoueur = reader.GetInt32("pv");
            int degatJoueur = reader.GetInt32("attaque");
            int soinJoueur = reader.GetInt32("soin");
            reader.Close();


            // Sélection d'une arme dans la base de données
            command = new MySqlCommand("SELECT * FROM Arme where nom = " + "'" + ArmeSelectionnee + "'", connection);
            reader = command.ExecuteReader();
            reader.Read();
            string nomArme = reader.GetString("nom");
            int degatArme = reader.GetInt32("degat");
            reader.Close();

            int degatTotal = degatJoueur + degatArme;

            joueur = new Joueur(nomJoueur, pvJoueur, degatTotal, soinJoueur);



            // Sélection d'un monstre aléatoire dans la base de données
            command = new MySqlCommand("SELECT * FROM Monstre ORDER BY RAND() LIMIT 1", connection);
            reader = command.ExecuteReader();
            reader.Read();
            string monsterName = reader.GetString("nom");
            int monsterHealth = reader.GetInt32("pv");
            int monsterAttack = reader.GetInt32("attaque");
            int monsterHeal = reader.GetInt32("soin");
            reader.Close();

            monstre = new Monstre(monsterName, monsterHealth, monsterAttack, monsterHeal);


            
            Txt_jeu.Text = "Bienvenue dans le jeu de combat !";

            Txt_jeu.Text = "Un " + monstre.Nom + " sauvage apparaît !";

            labelPlayerHealth.Text = "Santé: " + joueur.PV;
            labelMonsterHealth.Text = "Santé: " + monstre.PV;

            VieMonstre.Maximum = monstre.PV;
            VieJoueur.Maximum = joueur.PV;

            VieJoueur.Value = joueur.PV;
            VieMonstre.Value = monstre.PV;

            vieMaxM = VieMonstre.Value;
            vieMaxJ = VieJoueur.Value;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            compteur = 0;
            len = Txt_jeu.Text.Length;
            txt = Txt_jeu.Text;

            timerTxt.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            joueur.Attaquer(monstre);
            labelPlayerHealth.Text = "Santé: " + joueur.PV; // mise à jour du label avec les points de vie du joueur
            labelMonsterHealth.Text = "Santé: " + monstre.PV;

            if (monstre.PV < 0)
            {
                monstre.PV = 0;
            }

            VieMonstre.Value = monstre.PV;
            VieJoueur.Value = joueur.PV;

            
            Txt_jeu.Text = "Vous avez infliger " + joueur.Degat + " au " + monstre.Nom + " !";

            if (!monstre.EstEnVie())
            {
                MessageBox.Show("Vous avez tuer le " + monstre.Nom + " !");
                this.Close();
            }
            else
            {
                monstre.Attaquer(joueur);

                labelPlayerHealth.Text = "Santé: " + joueur.PV;
                labelMonsterHealth.Text = "Santé: " + monstre.PV; // mise à jour du label avec les points de vie du monstre
                
                if (joueur.PV < 0)
                {
                    joueur.PV = 0;
                }

                VieMonstre.Value = monstre.PV;
                VieJoueur.Value = joueur.PV;

                timerTxt.Start();
                Txt_jeu.Text = "Le " + monstre.Nom + "vous a infliger " + monstre.Degat + " degat !";

                if (!joueur.EstEnVie())
                {
                    MessageBox.Show("Vous avez été vaincu par le " + monstre.Nom + " !");
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (vieMaxJ != joueur.PV)
            {
                joueur.Soigner();

                labelPlayerHealth.Text = "Santé: " + joueur.PV;
                labelMonsterHealth.Text = "Santé: " + monstre.PV;

                if (monstre.PV < 0)
                {
                    monstre.PV = 0;
                }

                VieMonstre.Value = monstre.PV;
                VieJoueur.Value = joueur.PV;
            } else
            {
                timerTxt.Start();
                Txt_jeu.Text = "Vous avez déjà le maximum de vie";
            }

            if (!monstre.EstEnVie())
            {
                MessageBox.Show("Vous avez tuer le " + monstre.Nom + " !");
                this.Close();
            }
            else
            {
                monstre.Attaquer(joueur);

                if (joueur.PV < 0)
                {
                    joueur.PV = 0;
                }

                labelPlayerHealth.Text = "Santé: " + joueur.PV;
                labelMonsterHealth.Text = "Santé: " + monstre.PV;

                VieMonstre.Value = monstre.PV;
                VieJoueur.Value = joueur.PV;

                if (!joueur.EstEnVie())
                {
                    MessageBox.Show("Vous avez été vaincu par le " + monstre.Nom + " !");
                    this.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            joueur.AugmenterAttaque();

            labelPlayerHealth.Text = "Santé: " + joueur.PV;
            labelMonsterHealth.Text = "Santé: " + monstre.PV;

            if (monstre.PV < 0)
            {
                monstre.PV = 0;
            }

            VieMonstre.Value = monstre.PV;
            VieJoueur.Value = joueur.PV;

            if (!monstre.EstEnVie())
            {
                MessageBox.Show("Vous avez tuer le " + monstre.Nom + " !");
                this.Close();
            }
            else
            {
                monstre.Attaquer(joueur);

                if (joueur.PV < 0)
                {
                    joueur.PV = 0;
                }

                labelPlayerHealth.Text = "Santé: " + joueur.PV;
                labelMonsterHealth.Text = "Santé: " + monstre.PV;

                VieMonstre.Value = monstre.PV;
                VieJoueur.Value = joueur.PV;

                if (!joueur.EstEnVie())
                {
                    MessageBox.Show("Vous avez été vaincu par le " + monstre.Nom + " !");
                    this.Close();
                }
            }
        }

        class Personnage
        {
            public string Nom { get; set; }
            public int PV { get; set; }
            public int Degat { get; set; }
            public int Soin { get; set; }

            public bool EstEnVie()
            {
                return PV > 0;
            }
        }
        class Joueur : Personnage
        {
           
            public Joueur(string nom, int vie, int attaque, int soin)
            {
                Nom = nom;
                PV = vie;
                Degat = attaque;
                Soin = soin;
            }

            public void Attaquer(Monstre target)
            {
                int damage = Degat;
                Console.WriteLine(Nom + " attaque " + target.Nom + " et lui inflige " + damage + " points de dégâts");
                target.PV -= damage;
            }

            public void Soigner()
            {
                int heal = Soin;
                Console.WriteLine(Nom + " se soigne de " + heal + " points de vie");
                PV += heal;
            }

            public void AugmenterAttaque()
            {
                int améliorer = 5;
                Console.WriteLine(Nom + " augmente son attaque de " + améliorer);
                Degat += améliorer;
            }
        }



        class Monstre : Personnage
        {
            public Monstre(string nom, int vie, int attaque, int soin)
            {
                Nom = nom;
                PV = vie;
                Degat = attaque;
                Soin = soin;
            }

            public void Attaquer(Joueur target)
            {
                int damage = Degat;
                Console.WriteLine(Nom + " attaque " + target.Nom + " et lui inflige " + damage + " points de dégâts");
                target.PV -= damage;
            }
        }

        private void timerTxt_Tick(object sender, EventArgs e)
        {
            compteur += 1;
            Txt_jeu.Text = txt.Substring(0,compteur-1);

            if (compteur > len)
            {
                timerTxt.Stop();   
                compteur = 0;
                Txt_jeu.Text = "";
            }
        }
    }
}
