namespace Wellness.WinUI.Menadzment
{
    partial class frmRadnici
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRadnici = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OsobaIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OsobaPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._OsobaUloga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumZaposlenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osobaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OsobaUloga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.Ime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.cbUloga = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRadnici);
            this.groupBox1.Location = new System.Drawing.Point(12, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Radnici";
            // 
            // dgvRadnici
            // 
            this.dgvRadnici.AllowUserToAddRows = false;
            this.dgvRadnici.AllowUserToDeleteRows = false;
            this.dgvRadnici.AutoGenerateColumns = false;
            this.dgvRadnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRadnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.OsobaIme,
            this.OsobaPrezime,
            this._OsobaUloga,
            this.satnicaDataGridViewTextBoxColumn,
            this.datumZaposlenjaDataGridViewTextBoxColumn,
            this.osobaDataGridViewTextBoxColumn,
            this.OsobaUloga});
            this.dgvRadnici.DataSource = this.radnikBindingSource;
            this.dgvRadnici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRadnici.Location = new System.Drawing.Point(3, 16);
            this.dgvRadnici.Name = "dgvRadnici";
            this.dgvRadnici.ReadOnly = true;
            this.dgvRadnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRadnici.Size = new System.Drawing.Size(583, 210);
            this.dgvRadnici.TabIndex = 0;
            this.dgvRadnici.DoubleClick += new System.EventHandler(this.DgvRadnici_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // OsobaIme
            // 
            this.OsobaIme.HeaderText = "Ime";
            this.OsobaIme.Name = "OsobaIme";
            this.OsobaIme.ReadOnly = true;
            // 
            // OsobaPrezime
            // 
            this.OsobaPrezime.HeaderText = "Prezime";
            this.OsobaPrezime.Name = "OsobaPrezime";
            this.OsobaPrezime.ReadOnly = true;
            // 
            // _OsobaUloga
            // 
            this._OsobaUloga.HeaderText = "Uloga";
            this._OsobaUloga.Name = "_OsobaUloga";
            this._OsobaUloga.ReadOnly = true;
            // 
            // satnicaDataGridViewTextBoxColumn
            // 
            this.satnicaDataGridViewTextBoxColumn.DataPropertyName = "Satnica";
            this.satnicaDataGridViewTextBoxColumn.HeaderText = "Satnica";
            this.satnicaDataGridViewTextBoxColumn.Name = "satnicaDataGridViewTextBoxColumn";
            this.satnicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumZaposlenjaDataGridViewTextBoxColumn
            // 
            this.datumZaposlenjaDataGridViewTextBoxColumn.DataPropertyName = "DatumZaposlenja";
            this.datumZaposlenjaDataGridViewTextBoxColumn.HeaderText = "Datum zaposlenja";
            this.datumZaposlenjaDataGridViewTextBoxColumn.Name = "datumZaposlenjaDataGridViewTextBoxColumn";
            this.datumZaposlenjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumZaposlenjaDataGridViewTextBoxColumn.Width = 140;
            // 
            // osobaDataGridViewTextBoxColumn
            // 
            this.osobaDataGridViewTextBoxColumn.DataPropertyName = "Osoba";
            this.osobaDataGridViewTextBoxColumn.HeaderText = "Osoba";
            this.osobaDataGridViewTextBoxColumn.Name = "osobaDataGridViewTextBoxColumn";
            this.osobaDataGridViewTextBoxColumn.ReadOnly = true;
            this.osobaDataGridViewTextBoxColumn.Visible = false;
            // 
            // OsobaUloga
            // 
            this.OsobaUloga.DataPropertyName = "Id";
            this.OsobaUloga.HeaderText = "Uloga";
            this.OsobaUloga.Name = "OsobaUloga";
            this.OsobaUloga.ReadOnly = true;
            this.OsobaUloga.Visible = false;
            // 
            // radnikBindingSource
            // 
            this.radnikBindingSource.DataSource = typeof(Wellness.Model.Radnik);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(15, 38);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 1;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(132, 38);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 2;
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Location = new System.Drawing.Point(12, 22);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(24, 13);
            this.Ime.TabIndex = 3;
            this.Ime.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prezime";
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(15, 119);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(103, 23);
            this.btnTrazi.TabIndex = 5;
            this.btnTrazi.Text = "Trazi";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.BtnTrazi_Click);
            // 
            // cbUloga
            // 
            this.cbUloga.FormattingEnabled = true;
            this.cbUloga.Location = new System.Drawing.Point(15, 83);
            this.cbUloga.Name = "cbUloga";
            this.cbUloga.Size = new System.Drawing.Size(100, 21);
            this.cbUloga.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Uloga";
            // 
            // frmRadnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 398);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbUloga);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRadnici";
            this.Text = "Pregled korisnika";
            this.Load += new System.EventHandler(this.FrmRadnici_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRadnici;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.BindingSource radnikBindingSource;
        private System.Windows.Forms.ComboBox cbUloga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OsobaIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn OsobaPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn _OsobaUloga;
        private System.Windows.Forms.DataGridViewTextBoxColumn satnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumZaposlenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn osobaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OsobaUloga;
    }
}