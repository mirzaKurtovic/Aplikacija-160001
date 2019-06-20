namespace Wellness.WinUI.Clanarina
{
    partial class frmClanarinaDetalji
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateDatumUplate = new System.Windows.Forms.DateTimePicker();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUplataZaGodinu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUplataZaMjesec = new System.Windows.Forms.TextBox();
            this.txtUplataZaGodinu = new System.Windows.Forms.TextBox();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.ClanarineErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbPaket = new System.Windows.Forms.ComboBox();
            this.cbClan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClanarineErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Clan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Paket";
            // 
            // dateDatumUplate
            // 
            this.dateDatumUplate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDatumUplate.Location = new System.Drawing.Point(77, 117);
            this.dateDatumUplate.Name = "dateDatumUplate";
            this.dateDatumUplate.Size = new System.Drawing.Size(219, 20);
            this.dateDatumUplate.TabIndex = 24;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(77, 288);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(219, 23);
            this.btnSacuvaj.TabIndex = 23;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Iznos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Datum uplate";
            // 
            // lblUplataZaGodinu
            // 
            this.lblUplataZaGodinu.AutoSize = true;
            this.lblUplataZaGodinu.Location = new System.Drawing.Point(74, 53);
            this.lblUplataZaGodinu.Name = "lblUplataZaGodinu";
            this.lblUplataZaGodinu.Size = new System.Drawing.Size(87, 13);
            this.lblUplataZaGodinu.TabIndex = 18;
            this.lblUplataZaGodinu.Text = "Uplata za godinu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Uplata za mjesec";
            // 
            // txtUplataZaMjesec
            // 
            this.txtUplataZaMjesec.Location = new System.Drawing.Point(77, 25);
            this.txtUplataZaMjesec.Name = "txtUplataZaMjesec";
            this.txtUplataZaMjesec.Size = new System.Drawing.Size(219, 20);
            this.txtUplataZaMjesec.TabIndex = 30;
            this.txtUplataZaMjesec.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUplataZaMjesec_Validating);
            // 
            // txtUplataZaGodinu
            // 
            this.txtUplataZaGodinu.Location = new System.Drawing.Point(77, 69);
            this.txtUplataZaGodinu.Name = "txtUplataZaGodinu";
            this.txtUplataZaGodinu.Size = new System.Drawing.Size(219, 20);
            this.txtUplataZaGodinu.TabIndex = 31;
            this.txtUplataZaGodinu.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUplataZaGodinu_Validating);
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(77, 161);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(219, 20);
            this.txtIznos.TabIndex = 32;
            this.txtIznos.Validating += new System.ComponentModel.CancelEventHandler(this.TxtIznos_Validating);
            // 
            // ClanarineErrorProvider
            // 
            this.ClanarineErrorProvider.ContainerControl = this;
            // 
            // cbPaket
            // 
            this.cbPaket.FormattingEnabled = true;
            this.cbPaket.Location = new System.Drawing.Point(77, 205);
            this.cbPaket.Name = "cbPaket";
            this.cbPaket.Size = new System.Drawing.Size(219, 21);
            this.cbPaket.TabIndex = 33;
            // 
            // cbClan
            // 
            this.cbClan.FormattingEnabled = true;
            this.cbClan.Location = new System.Drawing.Point(77, 250);
            this.cbClan.Name = "cbClan";
            this.cbClan.Size = new System.Drawing.Size(219, 21);
            this.cbClan.TabIndex = 34;
            // 
            // frmClanarinaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 344);
            this.Controls.Add(this.cbClan);
            this.Controls.Add(this.cbPaket);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.txtUplataZaGodinu);
            this.Controls.Add(this.txtUplataZaMjesec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateDatumUplate);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUplataZaGodinu);
            this.Controls.Add(this.label1);
            this.Name = "frmClanarinaDetalji";
            this.Text = "frmClanarinaDetalji";
            this.Load += new System.EventHandler(this.FrmClanarinaDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClanarineErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateDatumUplate;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUplataZaGodinu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUplataZaMjesec;
        private System.Windows.Forms.TextBox txtUplataZaGodinu;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.ErrorProvider ClanarineErrorProvider;
        private System.Windows.Forms.ComboBox cbClan;
        private System.Windows.Forms.ComboBox cbPaket;
    }
}