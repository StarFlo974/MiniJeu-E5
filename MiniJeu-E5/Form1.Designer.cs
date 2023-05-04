namespace MiniJeu_E5
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.attaque_btn = new System.Windows.Forms.Button();
            this.soigner_btn = new System.Windows.Forms.Button();
            this.agmAttaque_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelMonsterHealth = new System.Windows.Forms.Label();
            this.labelPlayerHealth = new System.Windows.Forms.Label();
            this.Txt_jeu = new System.Windows.Forms.Label();
            this.VieMonstre = new System.Windows.Forms.ProgressBar();
            this.VieJoueur = new System.Windows.Forms.ProgressBar();
            this.timerTxt = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // attaque_btn
            // 
            this.attaque_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.attaque_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attaque_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.attaque_btn.Location = new System.Drawing.Point(1023, 322);
            this.attaque_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.attaque_btn.Name = "attaque_btn";
            this.attaque_btn.Size = new System.Drawing.Size(160, 43);
            this.attaque_btn.TabIndex = 0;
            this.attaque_btn.Text = "Attaquer";
            this.attaque_btn.UseVisualStyleBackColor = false;
            this.attaque_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // soigner_btn
            // 
            this.soigner_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.soigner_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soigner_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.soigner_btn.Location = new System.Drawing.Point(1023, 518);
            this.soigner_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soigner_btn.Name = "soigner_btn";
            this.soigner_btn.Size = new System.Drawing.Size(160, 44);
            this.soigner_btn.TabIndex = 1;
            this.soigner_btn.Text = "Se Soigner";
            this.soigner_btn.UseVisualStyleBackColor = false;
            this.soigner_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // agmAttaque_btn
            // 
            this.agmAttaque_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.agmAttaque_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agmAttaque_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.agmAttaque_btn.Location = new System.Drawing.Point(1023, 420);
            this.agmAttaque_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agmAttaque_btn.Name = "agmAttaque_btn";
            this.agmAttaque_btn.Size = new System.Drawing.Size(160, 42);
            this.agmAttaque_btn.TabIndex = 2;
            this.agmAttaque_btn.Text = "Augmenter l\'attaque";
            this.agmAttaque_btn.UseVisualStyleBackColor = false;
            this.agmAttaque_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MiniJeu_E5.Properties.Resources.Monstre_Idle2;
            this.pictureBox1.Location = new System.Drawing.Point(176, 343);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::MiniJeu_E5.Properties.Resources.Hero_Idle;
            this.pictureBox2.Location = new System.Drawing.Point(775, 364);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // labelMonsterHealth
            // 
            this.labelMonsterHealth.AutoSize = true;
            this.labelMonsterHealth.BackColor = System.Drawing.Color.Transparent;
            this.labelMonsterHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonsterHealth.Location = new System.Drawing.Point(211, 530);
            this.labelMonsterHealth.Name = "labelMonsterHealth";
            this.labelMonsterHealth.Size = new System.Drawing.Size(0, 16);
            this.labelMonsterHealth.TabIndex = 5;
            // 
            // labelPlayerHealth
            // 
            this.labelPlayerHealth.AutoSize = true;
            this.labelPlayerHealth.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayerHealth.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerHealth.Location = new System.Drawing.Point(772, 530);
            this.labelPlayerHealth.Name = "labelPlayerHealth";
            this.labelPlayerHealth.Size = new System.Drawing.Size(0, 16);
            this.labelPlayerHealth.TabIndex = 6;
            // 
            // Txt_jeu
            // 
            this.Txt_jeu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_jeu.AutoSize = true;
            this.Txt_jeu.BackColor = System.Drawing.Color.Transparent;
            this.Txt_jeu.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_jeu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txt_jeu.Location = new System.Drawing.Point(345, 18);
            this.Txt_jeu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_jeu.Name = "Txt_jeu";
            this.Txt_jeu.Size = new System.Drawing.Size(0, 34);
            this.Txt_jeu.TabIndex = 7;
            // 
            // VieMonstre
            // 
            this.VieMonstre.Location = new System.Drawing.Point(176, 499);
            this.VieMonstre.Maximum = 200;
            this.VieMonstre.Name = "VieMonstre";
            this.VieMonstre.Size = new System.Drawing.Size(167, 28);
            this.VieMonstre.TabIndex = 8;
            // 
            // VieJoueur
            // 
            this.VieJoueur.Location = new System.Drawing.Point(742, 499);
            this.VieJoueur.Name = "VieJoueur";
            this.VieJoueur.Size = new System.Drawing.Size(168, 28);
            this.VieJoueur.TabIndex = 9;
            // 
            // timerTxt
            // 
            this.timerTxt.Interval = 90;
            this.timerTxt.Tick += new System.EventHandler(this.timerTxt_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1276, 614);
            this.Controls.Add(this.VieJoueur);
            this.Controls.Add(this.VieMonstre);
            this.Controls.Add(this.Txt_jeu);
            this.Controls.Add(this.labelPlayerHealth);
            this.Controls.Add(this.labelMonsterHealth);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.agmAttaque_btn);
            this.Controls.Add(this.soigner_btn);
            this.Controls.Add(this.attaque_btn);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "ChronoQuest";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button attaque_btn;
        private System.Windows.Forms.Button soigner_btn;
        private System.Windows.Forms.Button agmAttaque_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelMonsterHealth;
        private System.Windows.Forms.Label labelPlayerHealth;
        private System.Windows.Forms.Label Txt_jeu;
        private System.Windows.Forms.ProgressBar VieMonstre;
        private System.Windows.Forms.ProgressBar VieJoueur;
        private System.Windows.Forms.Timer timerTxt;
    }
}

