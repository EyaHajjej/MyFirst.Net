namespace EyaHajjej
{
    partial class modifierBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Annuler = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.comboBox_Type_Livre = new System.Windows.Forms.ComboBox();
            this.text_editeur = new System.Windows.Forms.TextBox();
            this.text_Annee_Sortie = new System.Windows.Forms.TextBox();
            this.text_auteur = new System.Windows.Forms.TextBox();
            this.text_TitreLivre = new System.Windows.Forms.TextBox();
            this.text_ISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Annuler
            // 
            this.Annuler.BackColor = System.Drawing.Color.SandyBrown;
            this.Annuler.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Annuler.Location = new System.Drawing.Point(402, 390);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(151, 57);
            this.Annuler.TabIndex = 1;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = false;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.Color.SandyBrown;
            this.Modifier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Modifier.Location = new System.Drawing.Point(184, 390);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(173, 60);
            this.Modifier.TabIndex = 0;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // comboBox_Type_Livre
            // 
            this.comboBox_Type_Livre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Type_Livre.FormattingEnabled = true;
            this.comboBox_Type_Livre.Items.AddRange(new object[] {
            "Roman",
            "Action",
            "Comédie",
            "Horreur"});
            this.comboBox_Type_Livre.Location = new System.Drawing.Point(184, 265);
            this.comboBox_Type_Livre.Name = "comboBox_Type_Livre";
            this.comboBox_Type_Livre.Size = new System.Drawing.Size(369, 28);
            this.comboBox_Type_Livre.TabIndex = 11;
            // 
            // text_editeur
            // 
            this.text_editeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_editeur.Location = new System.Drawing.Point(184, 326);
            this.text_editeur.Name = "text_editeur";
            this.text_editeur.Size = new System.Drawing.Size(369, 27);
            this.text_editeur.TabIndex = 9;
            // 
            // text_Annee_Sortie
            // 
            this.text_Annee_Sortie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Annee_Sortie.Location = new System.Drawing.Point(184, 212);
            this.text_Annee_Sortie.MaxLength = 4;
            this.text_Annee_Sortie.Name = "text_Annee_Sortie";
            this.text_Annee_Sortie.Size = new System.Drawing.Size(369, 27);
            this.text_Annee_Sortie.TabIndex = 8;
            this.text_Annee_Sortie.TextChanged += new System.EventHandler(this.text_Annee_Sortie_TextChanged);
            // 
            // text_auteur
            // 
            this.text_auteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_auteur.Location = new System.Drawing.Point(184, 157);
            this.text_auteur.MaxLength = 15;
            this.text_auteur.Name = "text_auteur";
            this.text_auteur.Size = new System.Drawing.Size(369, 27);
            this.text_auteur.TabIndex = 7;
            // 
            // text_TitreLivre
            // 
            this.text_TitreLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_TitreLivre.Location = new System.Drawing.Point(183, 100);
            this.text_TitreLivre.Name = "text_TitreLivre";
            this.text_TitreLivre.Size = new System.Drawing.Size(370, 27);
            this.text_TitreLivre.TabIndex = 6;
            // 
            // text_ISBN
            // 
            this.text_ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ISBN.Location = new System.Drawing.Point(183, 48);
            this.text_ISBN.MaxLength = 13;
            this.text_ISBN.Name = "text_ISBN";
            this.text_ISBN.ReadOnly = true;
            this.text_ISBN.Size = new System.Drawing.Size(370, 27);
            this.text_ISBN.TabIndex = 0;
            this.text_ISBN.TextChanged += new System.EventHandler(this.text_ISBN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(34, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Editeur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(27, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Type Livre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(27, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Annee Sortie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Chocolate;
            this.label6.Location = new System.Drawing.Point(29, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Auteur";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Chocolate;
            this.label7.Location = new System.Drawing.Point(29, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Titre Livre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Chocolate;
            this.label8.Location = new System.Drawing.Point(30, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "ISBN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Annuler);
            this.panel2.Controls.Add(this.Modifier);
            this.panel2.Controls.Add(this.comboBox_Type_Livre);
            this.panel2.Controls.Add(this.text_editeur);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.text_Annee_Sortie);
            this.panel2.Controls.Add(this.text_auteur);
            this.panel2.Controls.Add(this.text_TitreLivre);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.text_ISBN);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(400, -7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 516);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SandyBrown;
            this.pictureBox3.Image = global::EyaHajjej.Properties.Resources.cancel;
            this.pictureBox3.Location = new System.Drawing.Point(519, 408);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SandyBrown;
            this.pictureBox2.Image = global::EyaHajjej.Properties.Resources.add1;
            this.pictureBox2.Location = new System.Drawing.Point(319, 407);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EyaHajjej.Properties.Resources._bs;
            this.pictureBox1.Location = new System.Drawing.Point(-183, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 516);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // modifierBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 505);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Name = "modifierBook";
            this.Text = "modifierBook";
            this.Load += new System.EventHandler(this.modifierBook_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.Button Modifier;
        public System.Windows.Forms.ComboBox comboBox_Type_Livre;
        public System.Windows.Forms.TextBox text_editeur;
        public System.Windows.Forms.TextBox text_Annee_Sortie;
        public System.Windows.Forms.TextBox text_auteur;
        public System.Windows.Forms.TextBox text_TitreLivre;
        public System.Windows.Forms.TextBox text_ISBN;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}