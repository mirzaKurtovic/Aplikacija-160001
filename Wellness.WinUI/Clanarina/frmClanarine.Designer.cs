namespace Wellness.WinUI.Clanarina
{
    partial class frmClanarine
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
            this.gbClanarina = new System.Windows.Forms.GroupBox();
            this.dgvClanarina = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uplataZaMjesecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uplataZaGodinuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumUplateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosUplateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clanIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paketIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clanarinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnTrazi = new System.Windows.Forms.Button();
            this.txtUplataZaMjesec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUplataZaGodinu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPaket = new System.Windows.Forms.ComboBox();
            this.cbClan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbClanarina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanarina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanarinaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbClanarina
            // 
            this.gbClanarina.Controls.Add(this.dgvClanarina);
            this.gbClanarina.Location = new System.Drawing.Point(12, 212);
            this.gbClanarina.Name = "gbClanarina";
            this.gbClanarina.Size = new System.Drawing.Size(654, 321);
            this.gbClanarina.TabIndex = 0;
            this.gbClanarina.TabStop = false;
            this.gbClanarina.Text = "Clanarine";
            // 
            // dgvClanarina
            // 
            this.dgvClanarina.AllowUserToAddRows = false;
            this.dgvClanarina.AllowUserToDeleteRows = false;
            this.dgvClanarina.AutoGenerateColumns = false;
            this.dgvClanarina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanarina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.uplataZaMjesecDataGridViewTextBoxColumn,
            this.uplataZaGodinuDataGridViewTextBoxColumn,
            this.datumUplateDataGridViewTextBoxColumn,
            this.iznosUplateDataGridViewTextBoxColumn,
            this.Clan,
            this.Paket,
            this.clanIdDataGridViewTextBoxColumn,
            this.paketIdDataGridViewTextBoxColumn,
            this.clanDataGridViewTextBoxColumn,
            this.paketDataGridViewTextBoxColumn});
            this.dgvClanarina.DataSource = this.clanarinaBindingSource;
            this.dgvClanarina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClanarina.Location = new System.Drawing.Point(3, 16);
            this.dgvClanarina.Name = "dgvClanarina";
            this.dgvClanarina.ReadOnly = true;
            this.dgvClanarina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClanarina.Size = new System.Drawing.Size(648, 302);
            this.dgvClanarina.TabIndex = 0;
            this.dgvClanarina.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvClanarina_MouseDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // uplataZaMjesecDataGridViewTextBoxColumn
            // 
            this.uplataZaMjesecDataGridViewTextBoxColumn.DataPropertyName = "UplataZaMjesec";
            this.uplataZaMjesecDataGridViewTextBoxColumn.HeaderText = "UplataZaMjesec";
            this.uplataZaMjesecDataGridViewTextBoxColumn.Name = "uplataZaMjesecDataGridViewTextBoxColumn";
            this.uplataZaMjesecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uplataZaGodinuDataGridViewTextBoxColumn
            // 
            this.uplataZaGodinuDataGridViewTextBoxColumn.DataPropertyName = "UplataZaGodinu";
            this.uplataZaGodinuDataGridViewTextBoxColumn.HeaderText = "UplataZaGodinu";
            this.uplataZaGodinuDataGridViewTextBoxColumn.Name = "uplataZaGodinuDataGridViewTextBoxColumn";
            this.uplataZaGodinuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumUplateDataGridViewTextBoxColumn
            // 
            this.datumUplateDataGridViewTextBoxColumn.DataPropertyName = "DatumUplate";
            this.datumUplateDataGridViewTextBoxColumn.HeaderText = "DatumUplate";
            this.datumUplateDataGridViewTextBoxColumn.Name = "datumUplateDataGridViewTextBoxColumn";
            this.datumUplateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iznosUplateDataGridViewTextBoxColumn
            // 
            this.iznosUplateDataGridViewTextBoxColumn.DataPropertyName = "IznosUplate";
            this.iznosUplateDataGridViewTextBoxColumn.HeaderText = "IznosUplate";
            this.iznosUplateDataGridViewTextBoxColumn.Name = "iznosUplateDataGridViewTextBoxColumn";
            this.iznosUplateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Clan
            // 
            this.Clan.HeaderText = "Clan";
            this.Clan.Name = "Clan";
            this.Clan.ReadOnly = true;
            // 
            // Paket
            // 
            this.Paket.HeaderText = "Paket";
            this.Paket.Name = "Paket";
            this.Paket.ReadOnly = true;
            // 
            // clanIdDataGridViewTextBoxColumn
            // 
            this.clanIdDataGridViewTextBoxColumn.DataPropertyName = "ClanId";
            this.clanIdDataGridViewTextBoxColumn.HeaderText = "ClanId";
            this.clanIdDataGridViewTextBoxColumn.Name = "clanIdDataGridViewTextBoxColumn";
            this.clanIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.clanIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // paketIdDataGridViewTextBoxColumn
            // 
            this.paketIdDataGridViewTextBoxColumn.DataPropertyName = "PaketId";
            this.paketIdDataGridViewTextBoxColumn.HeaderText = "PaketId";
            this.paketIdDataGridViewTextBoxColumn.Name = "paketIdDataGridViewTextBoxColumn";
            this.paketIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.paketIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // clanDataGridViewTextBoxColumn
            // 
            this.clanDataGridViewTextBoxColumn.DataPropertyName = "Clan";
            this.clanDataGridViewTextBoxColumn.HeaderText = "Clan";
            this.clanDataGridViewTextBoxColumn.Name = "clanDataGridViewTextBoxColumn";
            this.clanDataGridViewTextBoxColumn.ReadOnly = true;
            this.clanDataGridViewTextBoxColumn.Visible = false;
            // 
            // paketDataGridViewTextBoxColumn
            // 
            this.paketDataGridViewTextBoxColumn.DataPropertyName = "Paket";
            this.paketDataGridViewTextBoxColumn.HeaderText = "Paket";
            this.paketDataGridViewTextBoxColumn.Name = "paketDataGridViewTextBoxColumn";
            this.paketDataGridViewTextBoxColumn.ReadOnly = true;
            this.paketDataGridViewTextBoxColumn.Visible = false;
            // 
            // clanarinaBindingSource
            // 
            this.clanarinaBindingSource.DataSource = typeof(Wellness.Model.Clanarina);
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(12, 171);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(117, 23);
            this.btnTrazi.TabIndex = 1;
            this.btnTrazi.Text = "Trazi";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.BtnTrazi_Click);
            // 
            // txtUplataZaMjesec
            // 
            this.txtUplataZaMjesec.Location = new System.Drawing.Point(12, 28);
            this.txtUplataZaMjesec.Name = "txtUplataZaMjesec";
            this.txtUplataZaMjesec.Size = new System.Drawing.Size(117, 20);
            this.txtUplataZaMjesec.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Uplata za mjesec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Uplata za godinu";
            // 
            // txtUplataZaGodinu
            // 
            this.txtUplataZaGodinu.Location = new System.Drawing.Point(12, 74);
            this.txtUplataZaGodinu.Name = "txtUplataZaGodinu";
            this.txtUplataZaGodinu.Size = new System.Drawing.Size(117, 20);
            this.txtUplataZaGodinu.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Paket";
            // 
            // cbPaket
            // 
            this.cbPaket.FormattingEnabled = true;
            this.cbPaket.Location = new System.Drawing.Point(12, 124);
            this.cbPaket.Name = "cbPaket";
            this.cbPaket.Size = new System.Drawing.Size(117, 21);
            this.cbPaket.TabIndex = 7;
            // 
            // cbClan
            // 
            this.cbClan.FormattingEnabled = true;
            this.cbClan.Location = new System.Drawing.Point(159, 124);
            this.cbClan.Name = "cbClan";
            this.cbClan.Size = new System.Drawing.Size(117, 21);
            this.cbClan.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Clan";
            // 
            // frmClanarine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 568);
            this.Controls.Add(this.cbClan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbPaket);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUplataZaGodinu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUplataZaMjesec);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.gbClanarina);
            this.Name = "frmClanarine";
            this.Text = "Clanarina - Osnovni prikaz";
            this.Load += new System.EventHandler(this.FrmClanarine_Load);
            this.gbClanarina.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanarina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanarinaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbClanarina;
        private System.Windows.Forms.DataGridView dgvClanarina;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.TextBox txtUplataZaMjesec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource clanarinaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uplataZaMjesecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uplataZaGodinuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumUplateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznosUplateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paket;
        private System.Windows.Forms.DataGridViewTextBoxColumn clanIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paketIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paketDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUplataZaGodinu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPaket;
        private System.Windows.Forms.ComboBox cbClan;
        private System.Windows.Forms.Label label4;
    }
}