namespace Wellness.WinUI.Menadzment
{
    partial class frmRadniciDetalji
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Ime = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.Prezime = new System.Windows.Forms.Label();
            this.dtpDatumRodenja = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSpol = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPasswordPotvrda = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbUloga = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbMjestoBoravka = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtSatnica = new System.Windows.Forms.TextBox();
            this.lblSatnica = new System.Windows.Forms.Label();
            this.txtSpecijalizacija = new System.Windows.Forms.TextBox();
            this.lblSpecijalizacija = new System.Windows.Forms.Label();
            this.radniciDetaljiErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radniciDetaljiErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Location = new System.Drawing.Point(40, 28);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(24, 13);
            this.Ime.TabIndex = 0;
            this.Ime.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(43, 45);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 1;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.TxtIme_Validating);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(178, 45);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 3;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPrezime_Validating);
            // 
            // Prezime
            // 
            this.Prezime.AutoSize = true;
            this.Prezime.Location = new System.Drawing.Point(175, 28);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(44, 13);
            this.Prezime.TabIndex = 2;
            this.Prezime.Text = "Prezime";
            // 
            // dtpDatumRodenja
            // 
            this.dtpDatumRodenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumRodenja.Location = new System.Drawing.Point(43, 100);
            this.dtpDatumRodenja.Name = "dtpDatumRodenja";
            this.dtpDatumRodenja.Size = new System.Drawing.Size(100, 20);
            this.dtpDatumRodenja.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum rodenja";
            // 
            // cbSpol
            // 
            this.cbSpol.FormattingEnabled = true;
            this.cbSpol.Location = new System.Drawing.Point(43, 147);
            this.cbSpol.Name = "cbSpol";
            this.cbSpol.Size = new System.Drawing.Size(100, 21);
            this.cbSpol.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Spol";
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(43, 240);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(235, 20);
            this.txtJMBG.TabIndex = 9;
            this.txtJMBG.Validating += new System.ComponentModel.CancelEventHandler(this.TxtJMBG_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "JMBG";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(43, 288);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(235, 20);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEmail_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "e-mail";
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Location = new System.Drawing.Point(43, 338);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(235, 20);
            this.txtBrojTelefona.TabIndex = 13;
            this.txtBrojTelefona.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBrojTelefona_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Broj telefona";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(43, 388);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 15;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUserName_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Korisnicko ime";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(43, 441);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPassword_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Sifra";
            // 
            // txtPasswordPotvrda
            // 
            this.txtPasswordPotvrda.Location = new System.Drawing.Point(178, 441);
            this.txtPasswordPotvrda.Name = "txtPasswordPotvrda";
            this.txtPasswordPotvrda.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordPotvrda.TabIndex = 19;
            this.txtPasswordPotvrda.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPasswordPotvrda_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(175, 424);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Potvrda sifre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 475);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Tip korisnika";
            // 
            // cbUloga
            // 
            this.cbUloga.FormattingEnabled = true;
            this.cbUloga.Location = new System.Drawing.Point(43, 491);
            this.cbUloga.Name = "cbUloga";
            this.cbUloga.Size = new System.Drawing.Size(100, 21);
            this.cbUloga.TabIndex = 21;
            this.cbUloga.SelectedIndexChanged += new System.EventHandler(this.CbUloga_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Mjesto boravka";
            // 
            // cbMjestoBoravka
            // 
            this.cbMjestoBoravka.FormattingEnabled = true;
            this.cbMjestoBoravka.Location = new System.Drawing.Point(43, 194);
            this.cbMjestoBoravka.Name = "cbMjestoBoravka";
            this.cbMjestoBoravka.Size = new System.Drawing.Size(100, 21);
            this.cbMjestoBoravka.TabIndex = 22;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(43, 534);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(235, 31);
            this.btnRegister.TabIndex = 24;
            this.btnRegister.Text = "Spasi";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // txtSatnica
            // 
            this.txtSatnica.Location = new System.Drawing.Point(178, 492);
            this.txtSatnica.Name = "txtSatnica";
            this.txtSatnica.Size = new System.Drawing.Size(100, 20);
            this.txtSatnica.TabIndex = 26;
            this.txtSatnica.Validating += new System.ComponentModel.CancelEventHandler(this.TxtSatnica_Validating);
            // 
            // lblSatnica
            // 
            this.lblSatnica.AutoSize = true;
            this.lblSatnica.Location = new System.Drawing.Point(175, 475);
            this.lblSatnica.Name = "lblSatnica";
            this.lblSatnica.Size = new System.Drawing.Size(43, 13);
            this.lblSatnica.TabIndex = 25;
            this.lblSatnica.Text = "Satnica";
            // 
            // txtSpecijalizacija
            // 
            this.txtSpecijalizacija.Location = new System.Drawing.Point(315, 491);
            this.txtSpecijalizacija.Name = "txtSpecijalizacija";
            this.txtSpecijalizacija.Size = new System.Drawing.Size(100, 20);
            this.txtSpecijalizacija.TabIndex = 28;
            this.txtSpecijalizacija.Validating += new System.ComponentModel.CancelEventHandler(this.TxtSpecijalizacija_Validating);
            // 
            // lblSpecijalizacija
            // 
            this.lblSpecijalizacija.AutoSize = true;
            this.lblSpecijalizacija.Location = new System.Drawing.Point(312, 474);
            this.lblSpecijalizacija.Name = "lblSpecijalizacija";
            this.lblSpecijalizacija.Size = new System.Drawing.Size(73, 13);
            this.lblSpecijalizacija.TabIndex = 27;
            this.lblSpecijalizacija.Text = "Specijalizacija";
            // 
            // radniciDetaljiErrorProvider
            // 
            this.radniciDetaljiErrorProvider.ContainerControl = this;
            // 
            // frmRadniciDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 618);
            this.Controls.Add(this.txtSpecijalizacija);
            this.Controls.Add(this.lblSpecijalizacija);
            this.Controls.Add(this.txtSatnica);
            this.Controls.Add(this.lblSatnica);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbMjestoBoravka);
            this.Controls.Add(this.cbUloga);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPasswordPotvrda);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBrojTelefona);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSpol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDatumRodenja);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.Prezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.Ime);
            this.Name = "frmRadniciDetalji";
            this.Text = "frmRadniciDetalji";
            this.Load += new System.EventHandler(this.FrmRadniciDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radniciDetaljiErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label Prezime;
        private System.Windows.Forms.DateTimePicker dtpDatumRodenja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSpol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPasswordPotvrda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbUloga;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbMjestoBoravka;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtSatnica;
        private System.Windows.Forms.Label lblSatnica;
        private System.Windows.Forms.TextBox txtSpecijalizacija;
        private System.Windows.Forms.Label lblSpecijalizacija;
        private System.Windows.Forms.ErrorProvider radniciDetaljiErrorProvider;
    }
}