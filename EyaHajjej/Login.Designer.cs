namespace EyaHajjej
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.authentification = new System.Windows.Forms.Label();
            this.text_Login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_pwd = new System.Windows.Forms.TextBox();
            this.text_Connection = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.text_pwd);
            this.panel1.Controls.Add(this.authentification);
            this.panel1.Controls.Add(this.text_Login);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.text_Connection);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 700);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // authentification
            // 
            this.authentification.AutoSize = true;
            this.authentification.BackColor = System.Drawing.Color.PapayaWhip;
            this.authentification.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.authentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authentification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.authentification.Location = new System.Drawing.Point(157, 172);
            this.authentification.Name = "authentification";
            this.authentification.Size = new System.Drawing.Size(78, 29);
            this.authentification.TabIndex = 0;
            this.authentification.Text = "Login";
            this.authentification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.authentification.Click += new System.EventHandler(this.authentification_Click);
            // 
            // text_Login
            // 
            this.text_Login.BackColor = System.Drawing.Color.PapayaWhip;
            this.text_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.text_Login.Location = new System.Drawing.Point(373, 167);
            this.text_Login.Name = "text_Login";
            this.text_Login.Size = new System.Drawing.Size(283, 34);
            this.text_Login.TabIndex = 1;
            this.text_Login.Text = "admin";
            this.text_Login.TextChanged += new System.EventHandler(this.text_Login_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PapayaWhip;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(157, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // text_pwd
            // 
            this.text_pwd.BackColor = System.Drawing.Color.PapayaWhip;
            this.text_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_pwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.text_pwd.Location = new System.Drawing.Point(373, 272);
            this.text_pwd.Name = "text_pwd";
            this.text_pwd.Size = new System.Drawing.Size(283, 34);
            this.text_pwd.TabIndex = 3;
            this.text_pwd.Text = "admin";
            this.text_pwd.UseSystemPasswordChar = true;
            this.text_pwd.TextChanged += new System.EventHandler(this.text_pwd_TextChanged);
            // 
            // text_Connection
            // 
            this.text_Connection.BackColor = System.Drawing.Color.SandyBrown;
            this.text_Connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Connection.ForeColor = System.Drawing.Color.Black;
            this.text_Connection.Location = new System.Drawing.Point(162, 590);
            this.text_Connection.Name = "text_Connection";
            this.text_Connection.Size = new System.Drawing.Size(243, 82);
            this.text_Connection.TabIndex = 4;
            this.text_Connection.Text = "Connexion";
            this.text_Connection.UseVisualStyleBackColor = false;
            this.text_Connection.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SandyBrown;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(443, 589);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 82);
            this.button2.TabIndex = 5;
            this.button2.Text = "Quitter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SandyBrown;
            this.pictureBox3.Image = global::EyaHajjej.Properties.Resources.urjjl1;
            this.pictureBox3.Location = new System.Drawing.Point(345, 615);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 30);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SandyBrown;
            this.pictureBox2.Image = global::EyaHajjej.Properties.Resources.exit;
            this.pictureBox2.Location = new System.Drawing.Point(606, 611);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EyaHajjej.Properties.Resources._books;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(863, 567);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 714);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button text_Connection;
        private System.Windows.Forms.TextBox text_pwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Login;
        private System.Windows.Forms.Label authentification;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}