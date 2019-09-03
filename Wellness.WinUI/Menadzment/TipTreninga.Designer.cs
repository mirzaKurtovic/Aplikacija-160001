namespace Wellness.WinUI.Menadzment
{
    partial class TipTreninga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipTreninga));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.lblSlika = new System.Windows.Forms.Label();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.btnSlikaNova = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbSlika
            // 
            this.pbSlika.Image = ((System.Drawing.Image)(resources.GetObject("pbSlika.Image")));
            this.pbSlika.Location = new System.Drawing.Point(271, 46);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(202, 106);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSlika.TabIndex = 0;
            this.pbSlika.TabStop = false;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(27, 244);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(211, 23);
            this.btnSacuvaj.TabIndex = 1;
            this.btnSacuvaj.Text = "Spasi";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(24, 46);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(214, 20);
            this.txtNaziv.TabIndex = 2;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(24, 28);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 3;
            this.lblNaziv.Text = "Naziv";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(24, 74);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(28, 13);
            this.lblOpis.TabIndex = 5;
            this.lblOpis.Text = "Opis";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(24, 92);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(211, 91);
            this.txtOpis.TabIndex = 4;
            // 
            // lblSlika
            // 
            this.lblSlika.AutoSize = true;
            this.lblSlika.Location = new System.Drawing.Point(27, 189);
            this.lblSlika.Name = "lblSlika";
            this.lblSlika.Size = new System.Drawing.Size(30, 13);
            this.lblSlika.TabIndex = 7;
            this.lblSlika.Text = "Slika";
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(27, 207);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(214, 20);
            this.txtSlika.TabIndex = 6;
            // 
            // btnSlikaNova
            // 
            this.btnSlikaNova.Location = new System.Drawing.Point(256, 207);
            this.btnSlikaNova.Name = "btnSlikaNova";
            this.btnSlikaNova.Size = new System.Drawing.Size(56, 21);
            this.btnSlikaNova.TabIndex = 8;
            this.btnSlikaNova.Text = "Dodaj";
            this.btnSlikaNova.UseVisualStyleBackColor = true;
            this.btnSlikaNova.Click += new System.EventHandler(this.BtnSlikaNova_Click);
            // 
            // TipTreninga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSlikaNova);
            this.Controls.Add(this.lblSlika);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.pbSlika);
            this.Name = "TipTreninga";
            this.Text = "Tip treninga - detaljan prikaz";
            this.Load += new System.EventHandler(this.TipTreninga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label lblSlika;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.Button btnSlikaNova;
    }
}