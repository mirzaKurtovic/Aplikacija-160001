namespace Wellness.WinUI.Menadzment
{
    partial class frmIzvjestaj
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Paket = new System.Windows.Forms.Label();
            this.Tab1_cbPaket = new System.Windows.Forms.ComboBox();
            this.Tab1_cbOmoguci_DatumKraj = new System.Windows.Forms.CheckBox();
            this.Tab1_cbOmoguci_DatumPocetak = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Tab1_dtpDatumKraj = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.Tab1_dtpDatumPocetak = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUplataZaGodinu = new System.Windows.Forms.TextBox();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Tab2_cbOmoguci_DatumKraj = new System.Windows.Forms.CheckBox();
            this.Tab2_cbOmoguci_DatumPocetak = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tab2_dtpDatumKraj = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Tab2_dtpDatumPocetak = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Tab2_cbTipTreninga = new System.Windows.Forms.ComboBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnUcitaj2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(952, 483);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Paket);
            this.tabPage1.Controls.Add(this.Tab1_cbPaket);
            this.tabPage1.Controls.Add(this.Tab1_cbOmoguci_DatumKraj);
            this.tabPage1.Controls.Add(this.Tab1_cbOmoguci_DatumPocetak);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.Tab1_dtpDatumKraj);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.Tab1_dtpDatumPocetak);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtUplataZaGodinu);
            this.tabPage1.Controls.Add(this.btnUcitaj);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(944, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Zarada";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Paket
            // 
            this.Paket.AutoSize = true;
            this.Paket.Location = new System.Drawing.Point(15, 19);
            this.Paket.Name = "Paket";
            this.Paket.Size = new System.Drawing.Size(82, 13);
            this.Paket.TabIndex = 17;
            this.Paket.Text = "Uplata za paket";
            // 
            // Tab1_cbPaket
            // 
            this.Tab1_cbPaket.FormattingEnabled = true;
            this.Tab1_cbPaket.Location = new System.Drawing.Point(18, 35);
            this.Tab1_cbPaket.Name = "Tab1_cbPaket";
            this.Tab1_cbPaket.Size = new System.Drawing.Size(121, 21);
            this.Tab1_cbPaket.TabIndex = 16;
            // 
            // Tab1_cbOmoguci_DatumKraj
            // 
            this.Tab1_cbOmoguci_DatumKraj.AutoSize = true;
            this.Tab1_cbOmoguci_DatumKraj.Location = new System.Drawing.Point(142, 187);
            this.Tab1_cbOmoguci_DatumKraj.Name = "Tab1_cbOmoguci_DatumKraj";
            this.Tab1_cbOmoguci_DatumKraj.Size = new System.Drawing.Size(108, 17);
            this.Tab1_cbOmoguci_DatumKraj.TabIndex = 15;
            this.Tab1_cbOmoguci_DatumKraj.Text = "omogucen odabir";
            this.Tab1_cbOmoguci_DatumKraj.UseVisualStyleBackColor = true;
            this.Tab1_cbOmoguci_DatumKraj.CheckedChanged += new System.EventHandler(this.Tab1_cbOmoguci_DatumKraj_CheckedChanged);
            // 
            // Tab1_cbOmoguci_DatumPocetak
            // 
            this.Tab1_cbOmoguci_DatumPocetak.AutoSize = true;
            this.Tab1_cbOmoguci_DatumPocetak.Location = new System.Drawing.Point(142, 137);
            this.Tab1_cbOmoguci_DatumPocetak.Name = "Tab1_cbOmoguci_DatumPocetak";
            this.Tab1_cbOmoguci_DatumPocetak.Size = new System.Drawing.Size(108, 17);
            this.Tab1_cbOmoguci_DatumPocetak.TabIndex = 14;
            this.Tab1_cbOmoguci_DatumPocetak.Text = "omogucen odabir";
            this.Tab1_cbOmoguci_DatumPocetak.UseVisualStyleBackColor = true;
            this.Tab1_cbOmoguci_DatumPocetak.CheckedChanged += new System.EventHandler(this.Tab1_cbOmoguci_DatumPocetak_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Trazi podatke do";
            // 
            // Tab1_dtpDatumKraj
            // 
            this.Tab1_dtpDatumKraj.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Tab1_dtpDatumKraj.Location = new System.Drawing.Point(18, 184);
            this.Tab1_dtpDatumKraj.Name = "Tab1_dtpDatumKraj";
            this.Tab1_dtpDatumKraj.Size = new System.Drawing.Size(118, 20);
            this.Tab1_dtpDatumKraj.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Trazi podatke od";
            // 
            // Tab1_dtpDatumPocetak
            // 
            this.Tab1_dtpDatumPocetak.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Tab1_dtpDatumPocetak.Location = new System.Drawing.Point(18, 134);
            this.Tab1_dtpDatumPocetak.Name = "Tab1_dtpDatumPocetak";
            this.Tab1_dtpDatumPocetak.Size = new System.Drawing.Size(118, 20);
            this.Tab1_dtpDatumPocetak.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Uplata za godinu";
            // 
            // txtUplataZaGodinu
            // 
            this.txtUplataZaGodinu.Location = new System.Drawing.Point(18, 88);
            this.txtUplataZaGodinu.Name = "txtUplataZaGodinu";
            this.txtUplataZaGodinu.Size = new System.Drawing.Size(118, 20);
            this.txtUplataZaGodinu.TabIndex = 6;
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(18, 221);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(118, 25);
            this.btnUcitaj.TabIndex = 5;
            this.btnUcitaj.Text = "Ucitaj";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.BtnUcitaj_Click_1);
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(256, 19);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Zarada";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Prodano Paketa";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(662, 418);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Zarada po mjesecima u godini";
            this.chart1.Titles.Add(title1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Tab2_cbOmoguci_DatumKraj);
            this.tabPage2.Controls.Add(this.Tab2_cbOmoguci_DatumPocetak);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.Tab2_dtpDatumKraj);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Tab2_dtpDatumPocetak);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.Tab2_cbTipTreninga);
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Controls.Add(this.btnUcitaj2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(944, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Prisustvo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Tab2_cbOmoguci_DatumKraj
            // 
            this.Tab2_cbOmoguci_DatumKraj.AutoSize = true;
            this.Tab2_cbOmoguci_DatumKraj.Location = new System.Drawing.Point(134, 143);
            this.Tab2_cbOmoguci_DatumKraj.Name = "Tab2_cbOmoguci_DatumKraj";
            this.Tab2_cbOmoguci_DatumKraj.Size = new System.Drawing.Size(108, 17);
            this.Tab2_cbOmoguci_DatumKraj.TabIndex = 11;
            this.Tab2_cbOmoguci_DatumKraj.Text = "omogucen odabir";
            this.Tab2_cbOmoguci_DatumKraj.UseVisualStyleBackColor = true;
            this.Tab2_cbOmoguci_DatumKraj.CheckedChanged += new System.EventHandler(this.Tab2_cbOmoguci_DatumKraj_CheckedChanged);
            // 
            // Tab2_cbOmoguci_DatumPocetak
            // 
            this.Tab2_cbOmoguci_DatumPocetak.AutoSize = true;
            this.Tab2_cbOmoguci_DatumPocetak.Location = new System.Drawing.Point(134, 93);
            this.Tab2_cbOmoguci_DatumPocetak.Name = "Tab2_cbOmoguci_DatumPocetak";
            this.Tab2_cbOmoguci_DatumPocetak.Size = new System.Drawing.Size(108, 17);
            this.Tab2_cbOmoguci_DatumPocetak.TabIndex = 10;
            this.Tab2_cbOmoguci_DatumPocetak.Text = "omogucen odabir";
            this.Tab2_cbOmoguci_DatumPocetak.UseVisualStyleBackColor = true;
            this.Tab2_cbOmoguci_DatumPocetak.CheckedChanged += new System.EventHandler(this.Tab2_cbOmoguci_DatumPocetak_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Trazi podatke do";
            // 
            // Tab2_dtpDatumKraj
            // 
            this.Tab2_dtpDatumKraj.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Tab2_dtpDatumKraj.Location = new System.Drawing.Point(10, 140);
            this.Tab2_dtpDatumKraj.Name = "Tab2_dtpDatumKraj";
            this.Tab2_dtpDatumKraj.Size = new System.Drawing.Size(118, 20);
            this.Tab2_dtpDatumKraj.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Trazi podatke od";
            // 
            // Tab2_dtpDatumPocetak
            // 
            this.Tab2_dtpDatumPocetak.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Tab2_dtpDatumPocetak.Location = new System.Drawing.Point(10, 90);
            this.Tab2_dtpDatumPocetak.Name = "Tab2_dtpDatumPocetak";
            this.Tab2_dtpDatumPocetak.Size = new System.Drawing.Size(118, 20);
            this.Tab2_dtpDatumPocetak.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tip treninga";
            // 
            // Tab2_cbTipTreninga
            // 
            this.Tab2_cbTipTreninga.FormattingEnabled = true;
            this.Tab2_cbTipTreninga.Location = new System.Drawing.Point(7, 43);
            this.Tab2_cbTipTreninga.Name = "Tab2_cbTipTreninga";
            this.Tab2_cbTipTreninga.Size = new System.Drawing.Size(121, 21);
            this.Tab2_cbTipTreninga.TabIndex = 4;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(242, 6);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Rezervisano mjesta";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Prisustvovalo";
            this.chart2.Series.Add(series3);
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(676, 434);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "chart2";
            title2.Name = "Prisustvo na treninzima po danima u sedmici";
            title2.Text = "Prisustvo na treninzima po danima u sedmici";
            this.chart2.Titles.Add(title2);
            // 
            // btnUcitaj2
            // 
            this.btnUcitaj2.Location = new System.Drawing.Point(10, 176);
            this.btnUcitaj2.Name = "btnUcitaj2";
            this.btnUcitaj2.Size = new System.Drawing.Size(121, 23);
            this.btnUcitaj2.TabIndex = 2;
            this.btnUcitaj2.Text = "Ucitaj";
            this.btnUcitaj2.UseVisualStyleBackColor = true;
            this.btnUcitaj2.Click += new System.EventHandler(this.BtnUcitaj2_Click);
            // 
            // frmIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 488);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmIzvjestaj";
            this.Text = "Kreiranje izvještaja";
            this.Load += new System.EventHandler(this.FrmIzvjestaj_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUplataZaGodinu;
        private System.Windows.Forms.Button btnUcitaj;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button btnUcitaj2;
        private System.Windows.Forms.CheckBox Tab1_cbOmoguci_DatumKraj;
        private System.Windows.Forms.CheckBox Tab1_cbOmoguci_DatumPocetak;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Tab1_dtpDatumKraj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Tab1_dtpDatumPocetak;
        private System.Windows.Forms.CheckBox Tab2_cbOmoguci_DatumKraj;
        private System.Windows.Forms.CheckBox Tab2_cbOmoguci_DatumPocetak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Tab2_dtpDatumKraj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Tab2_dtpDatumPocetak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Tab2_cbTipTreninga;
        private System.Windows.Forms.Label Paket;
        private System.Windows.Forms.ComboBox Tab1_cbPaket;
    }
}