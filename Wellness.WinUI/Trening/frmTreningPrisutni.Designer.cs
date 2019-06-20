namespace Wellness.WinUI.Trening
{
    partial class frmTreningPrisutni
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
            this.dgvClanoviPrisustvo = new System.Windows.Forms.DataGridView();
            this.Clan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prisustvovaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.datumPrijaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clanIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treningIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clanPrisustvoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.clanPrisustvoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treningSearchRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanoviPrisustvo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanPrisustvoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanPrisustvoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treningSearchRequestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvClanoviPrisustvo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 404);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prisutni";
            // 
            // dgvClanoviPrisustvo
            // 
            this.dgvClanoviPrisustvo.AllowUserToAddRows = false;
            this.dgvClanoviPrisustvo.AllowUserToDeleteRows = false;
            this.dgvClanoviPrisustvo.AutoGenerateColumns = false;
            this.dgvClanoviPrisustvo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanoviPrisustvo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clan,
            this.prisustvovaoDataGridViewTextBoxColumn,
            this.datumPrijaveDataGridViewTextBoxColumn,
            this.clanIdDataGridViewTextBoxColumn,
            this.treningIdDataGridViewTextBoxColumn,
            this.treningDataGridViewTextBoxColumn,
            this.clanDataGridViewTextBoxColumn});
            this.dgvClanoviPrisustvo.DataSource = this.clanPrisustvoBindingSource1;
            this.dgvClanoviPrisustvo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClanoviPrisustvo.Location = new System.Drawing.Point(3, 16);
            this.dgvClanoviPrisustvo.Name = "dgvClanoviPrisustvo";
            this.dgvClanoviPrisustvo.Size = new System.Drawing.Size(444, 385);
            this.dgvClanoviPrisustvo.TabIndex = 0;
            // 
            // Clan
            // 
            this.Clan.HeaderText = "Clan";
            this.Clan.Name = "Clan";
            this.Clan.ReadOnly = true;
            // 
            // prisustvovaoDataGridViewTextBoxColumn
            // 
            this.prisustvovaoDataGridViewTextBoxColumn.DataPropertyName = "Prisustvovao";
            this.prisustvovaoDataGridViewTextBoxColumn.HeaderText = "Prisustvovao";
            this.prisustvovaoDataGridViewTextBoxColumn.Name = "prisustvovaoDataGridViewTextBoxColumn";
            this.prisustvovaoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.prisustvovaoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // datumPrijaveDataGridViewTextBoxColumn
            // 
            this.datumPrijaveDataGridViewTextBoxColumn.DataPropertyName = "DatumPrijave";
            this.datumPrijaveDataGridViewTextBoxColumn.HeaderText = "DatumPrijave";
            this.datumPrijaveDataGridViewTextBoxColumn.Name = "datumPrijaveDataGridViewTextBoxColumn";
            this.datumPrijaveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clanIdDataGridViewTextBoxColumn
            // 
            this.clanIdDataGridViewTextBoxColumn.DataPropertyName = "ClanId";
            this.clanIdDataGridViewTextBoxColumn.HeaderText = "ClanId";
            this.clanIdDataGridViewTextBoxColumn.Name = "clanIdDataGridViewTextBoxColumn";
            this.clanIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // treningIdDataGridViewTextBoxColumn
            // 
            this.treningIdDataGridViewTextBoxColumn.DataPropertyName = "TreningId";
            this.treningIdDataGridViewTextBoxColumn.HeaderText = "TreningId";
            this.treningIdDataGridViewTextBoxColumn.Name = "treningIdDataGridViewTextBoxColumn";
            this.treningIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.treningIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // treningDataGridViewTextBoxColumn
            // 
            this.treningDataGridViewTextBoxColumn.DataPropertyName = "Trening";
            this.treningDataGridViewTextBoxColumn.HeaderText = "Trening";
            this.treningDataGridViewTextBoxColumn.Name = "treningDataGridViewTextBoxColumn";
            this.treningDataGridViewTextBoxColumn.ReadOnly = true;
            this.treningDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.treningDataGridViewTextBoxColumn.Visible = false;
            // 
            // clanDataGridViewTextBoxColumn
            // 
            this.clanDataGridViewTextBoxColumn.DataPropertyName = "Clan";
            this.clanDataGridViewTextBoxColumn.HeaderText = "Clan";
            this.clanDataGridViewTextBoxColumn.Name = "clanDataGridViewTextBoxColumn";
            this.clanDataGridViewTextBoxColumn.ReadOnly = true;
            this.clanDataGridViewTextBoxColumn.Visible = false;
            // 
            // clanPrisustvoBindingSource1
            // 
            this.clanPrisustvoBindingSource1.DataSource = typeof(Wellness.Model.ClanPrisustvo);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(12, 431);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(447, 23);
            this.btnSacuvaj.TabIndex = 1;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(12, 460);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(447, 23);
            this.btnPonisti.TabIndex = 2;
            this.btnPonisti.Text = "Ponisti";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.BtnPonisti_Click);
            // 
            // clanPrisustvoBindingSource
            // 
            this.clanPrisustvoBindingSource.DataSource = typeof(Wellness.Model.ClanPrisustvo);
            // 
            // treningSearchRequestBindingSource
            // 
            this.treningSearchRequestBindingSource.DataSource = typeof(Wellness.Model.Requests.TreningSearchRequest);
            // 
            // frmTreningPrisutni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 503);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTreningPrisutni";
            this.Text = "frmTreningPrisutni";
            this.Load += new System.EventHandler(this.FrmTreningPrisutni_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanoviPrisustvo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanPrisustvoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanPrisustvoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treningSearchRequestBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvClanoviPrisustvo;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.BindingSource clanPrisustvoBindingSource;
        private System.Windows.Forms.BindingSource clanPrisustvoBindingSource1;
        private System.Windows.Forms.BindingSource treningSearchRequestBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn prisustvovaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumPrijaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clanIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treningIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treningDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clanDataGridViewTextBoxColumn;
    }
}