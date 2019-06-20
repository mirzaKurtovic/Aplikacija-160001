namespace Wellness.WinUI.Trening
{
    partial class frmTreningDetalji
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
            this.cbTipTreninga = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDatumTreninga = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpPocetak = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpKraj = new System.Windows.Forms.DateTimePicker();
            this.txtMaxPrisutnih = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.btnPogledajPrisutne = new System.Windows.Forms.Button();
            this.epTreningDetalji = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epTreningDetalji)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTipTreninga
            // 
            this.cbTipTreninga.FormattingEnabled = true;
            this.cbTipTreninga.Location = new System.Drawing.Point(43, 63);
            this.cbTipTreninga.Name = "cbTipTreninga";
            this.cbTipTreninga.Size = new System.Drawing.Size(172, 21);
            this.cbTipTreninga.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tip treninga";
            // 
            // dtpDatumTreninga
            // 
            this.dtpDatumTreninga.CustomFormat = "dd.MM.yyyy";
            this.dtpDatumTreninga.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumTreninga.Location = new System.Drawing.Point(43, 113);
            this.dtpDatumTreninga.Name = "dtpDatumTreninga";
            this.dtpDatumTreninga.Size = new System.Drawing.Size(172, 20);
            this.dtpDatumTreninga.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum treninga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pocetak";
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.CustomFormat = "HH:mm";
            this.dtpPocetak.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPocetak.Location = new System.Drawing.Point(246, 113);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.Size = new System.Drawing.Size(72, 20);
            this.dtpPocetak.TabIndex = 4;
            this.dtpPocetak.Validating += new System.ComponentModel.CancelEventHandler(this.DtpPocetak_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kraj";
            // 
            // dtpKraj
            // 
            this.dtpKraj.CustomFormat = "HH:mm";
            this.dtpKraj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKraj.Location = new System.Drawing.Point(333, 113);
            this.dtpKraj.Name = "dtpKraj";
            this.dtpKraj.Size = new System.Drawing.Size(72, 20);
            this.dtpKraj.TabIndex = 6;
            this.dtpKraj.Validating += new System.ComponentModel.CancelEventHandler(this.DtpKraj_Validating);
            // 
            // txtMaxPrisutnih
            // 
            this.txtMaxPrisutnih.Location = new System.Drawing.Point(43, 162);
            this.txtMaxPrisutnih.Name = "txtMaxPrisutnih";
            this.txtMaxPrisutnih.Size = new System.Drawing.Size(172, 20);
            this.txtMaxPrisutnih.TabIndex = 8;
            this.txtMaxPrisutnih.Validating += new System.ComponentModel.CancelEventHandler(this.TxtMaxPrisutnih_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Maksimalan broj prisutnih";
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSnimi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSnimi.Location = new System.Drawing.Point(43, 202);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(75, 23);
            this.btnSnimi.TabIndex = 10;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.BtnSnimi_Click);
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(143, 202);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(75, 23);
            this.btnPonisti.TabIndex = 11;
            this.btnPonisti.Text = "Ponisti";
            this.btnPonisti.UseVisualStyleBackColor = true;
            // 
            // btnPogledajPrisutne
            // 
            this.btnPogledajPrisutne.Location = new System.Drawing.Point(43, 237);
            this.btnPogledajPrisutne.Name = "btnPogledajPrisutne";
            this.btnPogledajPrisutne.Size = new System.Drawing.Size(175, 23);
            this.btnPogledajPrisutne.TabIndex = 12;
            this.btnPogledajPrisutne.Text = "Pogledaj prisutne";
            this.btnPogledajPrisutne.UseVisualStyleBackColor = true;
            this.btnPogledajPrisutne.Click += new System.EventHandler(this.BtnPogledajPrisutne_Click);
            // 
            // epTreningDetalji
            // 
            this.epTreningDetalji.ContainerControl = this;
            // 
            // frmTreningDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 272);
            this.Controls.Add(this.btnPogledajPrisutne);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaxPrisutnih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpKraj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpPocetak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDatumTreninga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipTreninga);
            this.Name = "frmTreningDetalji";
            this.Text = "frmTreningDetalji";
            this.Load += new System.EventHandler(this.FrmTreningDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epTreningDetalji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTipTreninga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDatumTreninga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpPocetak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpKraj;
        private System.Windows.Forms.TextBox txtMaxPrisutnih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.Button btnPogledajPrisutne;
        private System.Windows.Forms.ErrorProvider epTreningDetalji;
    }
}