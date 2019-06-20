namespace Wellness.WinUI.Menadzment
{
    partial class frmIsplataRadnika
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
            this.cbRadnik = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIzvor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRadnihSati = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUplataZaGodinu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUplataZaMjesec = new System.Windows.Forms.TextBox();
            this.btnEvidentirajUplatu = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.lblSatnica = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSatnica = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.x = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvIsplate = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUplataZaGodinuSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUplataZaMjesecSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbRadnikSearch = new System.Windows.Forms.ComboBox();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.RadnikIsplataErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.clanPrisustvoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radnikPlataHistorijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uplataZaGodinuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uplataZaMjesecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumUplateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radnihSatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radnikIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadnikIsplataErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanPrisustvoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikPlataHistorijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRadnik
            // 
            this.cbRadnik.FormattingEnabled = true;
            this.cbRadnik.Location = new System.Drawing.Point(26, 36);
            this.cbRadnik.Name = "cbRadnik";
            this.cbRadnik.Size = new System.Drawing.Size(165, 21);
            this.cbRadnik.TabIndex = 0;
            this.cbRadnik.SelectedIndexChanged += new System.EventHandler(this.CbRadnik_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Radnik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Izvor";
            // 
            // txtIzvor
            // 
            this.txtIzvor.Location = new System.Drawing.Point(29, 87);
            this.txtIzvor.Name = "txtIzvor";
            this.txtIzvor.Size = new System.Drawing.Size(162, 20);
            this.txtIzvor.TabIndex = 4;
            this.txtIzvor.TextChanged += new System.EventHandler(this.TxtIzvor_TextChanged);
            this.txtIzvor.Validating += new System.ComponentModel.CancelEventHandler(this.TxtIzvor_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Radnih sati";
            // 
            // txtRadnihSati
            // 
            this.txtRadnihSati.Location = new System.Drawing.Point(29, 146);
            this.txtRadnihSati.Name = "txtRadnihSati";
            this.txtRadnihSati.Size = new System.Drawing.Size(85, 20);
            this.txtRadnihSati.TabIndex = 6;
            this.txtRadnihSati.TextChanged += new System.EventHandler(this.TxtRadnihSati_TextChanged);
            this.txtRadnihSati.Validating += new System.ComponentModel.CancelEventHandler(this.TxtRadnihSati_Validating);
            this.txtRadnihSati.Validated += new System.EventHandler(this.TxtRadnihSati_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Uplata za godinu";
            // 
            // txtUplataZaGodinu
            // 
            this.txtUplataZaGodinu.Location = new System.Drawing.Point(221, 87);
            this.txtUplataZaGodinu.Name = "txtUplataZaGodinu";
            this.txtUplataZaGodinu.Size = new System.Drawing.Size(84, 20);
            this.txtUplataZaGodinu.TabIndex = 8;
            this.txtUplataZaGodinu.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUplataZaGodinu_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Uplata za mjesec";
            // 
            // txtUplataZaMjesec
            // 
            this.txtUplataZaMjesec.Location = new System.Drawing.Point(333, 87);
            this.txtUplataZaMjesec.Name = "txtUplataZaMjesec";
            this.txtUplataZaMjesec.Size = new System.Drawing.Size(85, 20);
            this.txtUplataZaMjesec.TabIndex = 10;
            this.txtUplataZaMjesec.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUplataZaMjesec_Validating);
            // 
            // btnEvidentirajUplatu
            // 
            this.btnEvidentirajUplatu.Location = new System.Drawing.Point(29, 193);
            this.btnEvidentirajUplatu.Name = "btnEvidentirajUplatu";
            this.btnEvidentirajUplatu.Size = new System.Drawing.Size(100, 23);
            this.btnEvidentirajUplatu.TabIndex = 12;
            this.btnEvidentirajUplatu.Text = "Evidentiraj uplatu";
            this.btnEvidentirajUplatu.UseVisualStyleBackColor = true;
            this.btnEvidentirajUplatu.Click += new System.EventHandler(this.BtnEvidentirajUplatu_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(152, 193);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(84, 23);
            this.btnIzlaz.TabIndex = 13;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.BtnIzlaz_Click);
            // 
            // lblSatnica
            // 
            this.lblSatnica.AutoSize = true;
            this.lblSatnica.Location = new System.Drawing.Point(135, 130);
            this.lblSatnica.Name = "lblSatnica";
            this.lblSatnica.Size = new System.Drawing.Size(43, 13);
            this.lblSatnica.TabIndex = 15;
            this.lblSatnica.Text = "Satnica";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(225, 130);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total";
            // 
            // txtSatnica
            // 
            this.txtSatnica.Location = new System.Drawing.Point(138, 146);
            this.txtSatnica.Name = "txtSatnica";
            this.txtSatnica.Size = new System.Drawing.Size(65, 20);
            this.txtSatnica.TabIndex = 17;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(228, 146);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(65, 20);
            this.txtTotal.TabIndex = 18;
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(120, 149);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(12, 13);
            this.x.TabIndex = 19;
            this.x.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "=";
            // 
            // dgvIsplate
            // 
            this.dgvIsplate.AllowUserToAddRows = false;
            this.dgvIsplate.AllowUserToDeleteRows = false;
            this.dgvIsplate.AutoGenerateColumns = false;
            this.dgvIsplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsplate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uplataZaGodinuDataGridViewTextBoxColumn,
            this.uplataZaMjesecDataGridViewTextBoxColumn,
            this.datumUplateDataGridViewTextBoxColumn,
            this.radnihSatiDataGridViewTextBoxColumn,
            this.satnicaDataGridViewTextBoxColumn,
            this.radnikIdDataGridViewTextBoxColumn,
            this.radnikDataGridViewTextBoxColumn});
            this.dgvIsplate.DataSource = this.radnikPlataHistorijaBindingSource;
            this.dgvIsplate.Location = new System.Drawing.Point(26, 361);
            this.dgvIsplate.Name = "dgvIsplate";
            this.dgvIsplate.ReadOnly = true;
            this.dgvIsplate.Size = new System.Drawing.Size(547, 205);
            this.dgvIsplate.TabIndex = 21;
            this.dgvIsplate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvIsplate_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Uplata za godinu";
            // 
            // txtUplataZaGodinuSearch
            // 
            this.txtUplataZaGodinuSearch.Location = new System.Drawing.Point(29, 297);
            this.txtUplataZaGodinuSearch.Name = "txtUplataZaGodinuSearch";
            this.txtUplataZaGodinuSearch.Size = new System.Drawing.Size(85, 20);
            this.txtUplataZaGodinuSearch.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Uplata za mjesec";
            // 
            // txtUplataZaMjesecSearch
            // 
            this.txtUplataZaMjesecSearch.Location = new System.Drawing.Point(138, 297);
            this.txtUplataZaMjesecSearch.Name = "txtUplataZaMjesecSearch";
            this.txtUplataZaMjesecSearch.Size = new System.Drawing.Size(85, 20);
            this.txtUplataZaMjesecSearch.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Radnik";
            // 
            // cbRadnikSearch
            // 
            this.cbRadnikSearch.FormattingEnabled = true;
            this.cbRadnikSearch.Location = new System.Drawing.Point(29, 257);
            this.cbRadnikSearch.Name = "cbRadnikSearch";
            this.cbRadnikSearch.Size = new System.Drawing.Size(162, 21);
            this.cbRadnikSearch.TabIndex = 27;
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(29, 332);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(85, 23);
            this.btnTrazi.TabIndex = 29;
            this.btnTrazi.Text = "Trazi";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.BtnTrazi_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(415, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "____________________________________________________________________";
            // 
            // RadnikIsplataErrorProvider
            // 
            this.RadnikIsplataErrorProvider.ContainerControl = this;
            // 
            // clanPrisustvoBindingSource
            // 
            this.clanPrisustvoBindingSource.DataSource = typeof(Wellness.Model.ClanPrisustvo);
            // 
            // radnikPlataHistorijaBindingSource
            // 
            this.radnikPlataHistorijaBindingSource.DataSource = typeof(Wellness.Model.RadnikPlataHistorija);
            // 
            // uplataZaGodinuDataGridViewTextBoxColumn
            // 
            this.uplataZaGodinuDataGridViewTextBoxColumn.DataPropertyName = "UplataZaGodinu";
            this.uplataZaGodinuDataGridViewTextBoxColumn.HeaderText = "UplataZaGodinu";
            this.uplataZaGodinuDataGridViewTextBoxColumn.Name = "uplataZaGodinuDataGridViewTextBoxColumn";
            this.uplataZaGodinuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uplataZaMjesecDataGridViewTextBoxColumn
            // 
            this.uplataZaMjesecDataGridViewTextBoxColumn.DataPropertyName = "UplataZaMjesec";
            this.uplataZaMjesecDataGridViewTextBoxColumn.HeaderText = "UplataZaMjesec";
            this.uplataZaMjesecDataGridViewTextBoxColumn.Name = "uplataZaMjesecDataGridViewTextBoxColumn";
            this.uplataZaMjesecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumUplateDataGridViewTextBoxColumn
            // 
            this.datumUplateDataGridViewTextBoxColumn.DataPropertyName = "DatumUplate";
            this.datumUplateDataGridViewTextBoxColumn.HeaderText = "DatumUplate";
            this.datumUplateDataGridViewTextBoxColumn.Name = "datumUplateDataGridViewTextBoxColumn";
            this.datumUplateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // radnihSatiDataGridViewTextBoxColumn
            // 
            this.radnihSatiDataGridViewTextBoxColumn.DataPropertyName = "RadnihSati";
            this.radnihSatiDataGridViewTextBoxColumn.HeaderText = "RadnihSati";
            this.radnihSatiDataGridViewTextBoxColumn.Name = "radnihSatiDataGridViewTextBoxColumn";
            this.radnihSatiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // satnicaDataGridViewTextBoxColumn
            // 
            this.satnicaDataGridViewTextBoxColumn.DataPropertyName = "Satnica";
            this.satnicaDataGridViewTextBoxColumn.HeaderText = "Satnica";
            this.satnicaDataGridViewTextBoxColumn.Name = "satnicaDataGridViewTextBoxColumn";
            this.satnicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // radnikIdDataGridViewTextBoxColumn
            // 
            this.radnikIdDataGridViewTextBoxColumn.DataPropertyName = "RadnikId";
            this.radnikIdDataGridViewTextBoxColumn.HeaderText = "RadnikId";
            this.radnikIdDataGridViewTextBoxColumn.Name = "radnikIdDataGridViewTextBoxColumn";
            this.radnikIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.radnikIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // radnikDataGridViewTextBoxColumn
            // 
            this.radnikDataGridViewTextBoxColumn.DataPropertyName = "Radnik";
            this.radnikDataGridViewTextBoxColumn.HeaderText = "Radnik";
            this.radnikDataGridViewTextBoxColumn.Name = "radnikDataGridViewTextBoxColumn";
            this.radnikDataGridViewTextBoxColumn.ReadOnly = true;
            this.radnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmIsplataRadnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 578);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbRadnikSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUplataZaMjesecSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUplataZaGodinuSearch);
            this.Controls.Add(this.dgvIsplate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.x);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSatnica);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSatnica);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnEvidentirajUplatu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUplataZaMjesec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUplataZaGodinu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRadnihSati);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIzvor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRadnik);
            this.Name = "frmIsplataRadnika";
            this.Text = "frmIsplataRadnika";
            this.Load += new System.EventHandler(this.FrmIsplataRadnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadnikIsplataErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanPrisustvoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikPlataHistorijaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRadnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIzvor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRadnihSati;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUplataZaGodinu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUplataZaMjesec;
        private System.Windows.Forms.Button btnEvidentirajUplatu;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Label lblSatnica;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtSatnica;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvIsplate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUplataZaGodinuSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUplataZaMjesecSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbRadnikSearch;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider RadnikIsplataErrorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn uplataZaGodinuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uplataZaMjesecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumUplateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn radnihSatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn radnikIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn radnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource radnikPlataHistorijaBindingSource;
        private System.Windows.Forms.BindingSource clanPrisustvoBindingSource;
    }
}